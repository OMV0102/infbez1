using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

//TODO сделать глобальную переменную под путь для всех файлов

namespace infbez1
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Если нажимаем на кнопку ПРОЧИТАТЬ
        private void btm_Rfile_text_Click(object sender, EventArgs e)
        {
            var_glob.filetext = "";
            
            if (txt_file_in.TextLength > 0)
            {
                if (File.Exists(var_glob.path) == true)
                {
                    if (var_glob.isbinfile == true)
                    {
                        var_glob.bytearr = File.ReadAllBytes(var_glob.path);
                        var_glob.TextLength = var_glob.bytearr.Length;
                        txt_in.Text = Encoding.Default.GetString(var_glob.bytearr).Replace('\0', ' '); // КОДИРОВКААААААААААААААААААААААААААААААААААА
                    }
                    else
                    {
                        var_glob.filetext = File.ReadAllText(var_glob.path, Encoding.Default); // КОДИРОВКААААААААААААААААААААААААААААААААААА
                        var_glob.bytearr = Encoding.Default.GetBytes(var_glob.filetext);  // КОДИРОВКААААААААААААААААААААААААААААААААААА
                        var_glob.TextLength = var_glob.bytearr.Length;
                        txt_in.Text = var_glob.filetext;
                    }
                }
                else
                {
                    MessageBox.Show("Файла \"" + var_glob.path + "\" не существует!", " Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Укажите файл для чтения!", " Не указан файл", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }   

        // Если нажимаем на кнопку ХЭШИРОВАТЬ
        private void btm_coding_Click(object sender, EventArgs e) 
        {
            try
            {
                var_glob.bitarr = new BitArray(var_glob.bytearr); // BitArray переделывает байты в биты little-endian
                var_glob.bitarr = messageTransform.each_byte_negativ_endian(var_glob.bitarr); // Конвертируем из полученных бит little-endian биты big-endian
                // 1 шаг
                var_glob.bitarr = messageTransform.add_extra_bit(var_glob.bitarr); // Добавляем доп. биты до длины кратной 448
                var_glob.bitarr = messageTransform.each_4byte_negativ_endian(var_glob.bitarr); // Конвертируем биты по 4 байта (1 слову) в биты little-endian
                // 2 шаг
                var_glob.bitarr = messageTransform.add_length_bit(var_glob.bitarr, var_glob.TextLength); // Добавили двоичное представление длины исходного текста
                var_glob.bitarr = messageTransform.each_byte_negativ_endian(var_glob.bitarr); // Конвертируем из бит big-endian в little-endian, т.к. битово-байтовая конвертация идет как little-endian

                var_glob.bytearrnew = new byte[var_glob.bitarr.Length/8]; // Исходный массив байтов до начала хэширования
                var_glob.bitarr.CopyTo(var_glob.bytearrnew, 0); // из битов в байты

                int t = var_glob.bytearrnew.Length / 64; // Количество блоков по 64 байта (512 бит)
                // Дальше хэширования начинается
                UInt64 A1, A2, B1, B2, C1, C2, D1, D2, T, h0, h1, h2, h3;
                h0 = bitFunc.h0;
                h1 = bitFunc.h1;
                h2 = bitFunc.h2;
                h3 = bitFunc.h3;

                for (int i = 0; i < t; i++)
                {
                    A1 = h0;
                    A2 = h0;
                    B1 = h1;
                    B2 = h1;
                    C1 = h2;
                    C2 = h2;
                    D1 = h3;
                    D2 = h3;

                    for(int j = 0; j < 64; j++)
                    {
                        T = bitFunc.plus_mod2_in32(A1, bitFunc.f(j, B1, C1, D1));
                        T = bitFunc.plus_mod2_in32(T, var_glob.bytearrnew[64*i+bitFunc.R1[j]]);
                        T = bitFunc.plus_mod2_in32(T, bitFunc.K1(j));
                        T = bitFunc.shiftLeft(T, bitFunc.S1[j]);

                        A1 = D1;
                        D1 = C1;
                        C1 = B1;
                        B1 = T;

                        T = bitFunc.plus_mod2_in32(A2, bitFunc.f(63-j, B2, C2, D2));
                        T = bitFunc.plus_mod2_in32(T, var_glob.bytearrnew[64 * i + bitFunc.R2[j]]);
                        T = bitFunc.plus_mod2_in32(T, bitFunc.K2(j));
                        T = bitFunc.shiftLeft(T, bitFunc.S2[j]);

                        A2 = D2;
                        D2 = C2;
                        C2 = B2;
                        B2 = T;
                    }
                    T = bitFunc.plus_mod2_in32(bitFunc.plus_mod2_in32(h1, C1), D2);
                    h1 = bitFunc.plus_mod2_in32(bitFunc.plus_mod2_in32(h2, D1), A2);
                    h2 = bitFunc.plus_mod2_in32(bitFunc.plus_mod2_in32(h3, A1), B2);
                    h3 = bitFunc.plus_mod2_in32(bitFunc.plus_mod2_in32(h0, B1), C2);
                    h0 = T;
                }
                string res = bitFunc.result_concat(h0, h1, h2, h3);
    }
            catch (Exception error)
            {
                MessageBox.Show("Ошибка при хэшировании!", " Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Если нажимаем на кнопку ЗАПИСАТЬ полученный ТЕКСТ
        private void btm_Wfile_text_Click(object sender, EventArgs e) 
        {
            
            // Если не указано имя файла
            if (txt_file_out.Text == "") 
            {
                MessageBox.Show("Не указано имя файла для записи полученного текста!!", " Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
            
            //Если поле с полученным текстом пустое
            if (txt_out.Text == "") 
            {
                MessageBox.Show("Запись текста невозможна.\nПоле с текстом пустое!", " Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // вызов функции, которая записывает текст
            //n.Text_Save(txt_file_out.Text, txt_out.Text); 
            MessageBox.Show("Полученный текст записан в файл.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        // Кнопка "..." ВЫБОР ВХОДНОГО ФАЙЛА 
        private void btn_choice_filein_Click(object sender, EventArgs e)
        {
            string tmp = "";
            OpenFileDialog opf = new OpenFileDialog();
            opf.Title = "Выбрать файл ..."; // Заголовок окна
            if (txt_file_in.TextLength == 0) //Начальный путь в окне
                opf.InitialDirectory = Application.StartupPath; // Папка проекта
            else
                opf.InitialDirectory = txt_file_in.Text;

            if (opf.ShowDialog() == DialogResult.OK)
            {
                tmp = opf.SafeFileName;
                int n = opf.SafeFileName.Length;
                string ras = tmp[n - 3].ToString() + tmp[n - 2].ToString() + tmp[n - 1].ToString();
                if (ras == "txt") //если расширение txt
                    var_glob.isbinfile = false; // файл обычный
                else
                    var_glob.isbinfile = true; // файл считаем как бинарный

                // получаем путь С НАЗВАНИЕМ файла
                var_glob.path = opf.FileName;
                txt_file_in.Text = var_glob.path;
            }
        }

        // подсчет байтов текста
        private void txt_in_TextChanged(object sender, EventArgs e)
        {
            label3.Text = txt_in.TextLength.ToString();
        }
    }

    public static class var_glob
    {
        static public bool isbinfile; // Флаг, тип входного файла
        static public string path; // Путь до выбранного файла
        static public string filetext; // Считанный текст сообщения
        static public int TextLength; // Изначальный размер сообщения в байтах (1 символ = 1 байт)
        static public byte[] bytearr; // Байтовое представление исходного текста
        static public BitArray bitarr; // Битовое представление модифицированного сообщения
        static public byte[] bytearrnew; // Байтовое представление модифицированного сообщения из битов
    }
}
