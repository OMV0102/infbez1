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

        static bool isbinfile; // Флаг, тип входного файла
        static string path; // Путь до выбранного файла
        static public byte[] bytearr;
        static public BitArray bitarr;

        // Если нажимаем на кнопку ПРОЧИТАТЬ
        private void btm_Rfile_text_Click(object sender, EventArgs e)
        {
            string filetext = "";

            if (txt_file_in.TextLength > 0)
            {
                if (File.Exists(path) == true)
                {
                    if (isbinfile == true)
                    {
                        bytearr = File.ReadAllBytes(path);
                        txt_in.Text = Encoding.Default.GetString(bytearr).Replace('\0', ' ');
                    }
                    else
                    {
                        filetext = File.ReadAllText(path, Encoding.Default);
                        bytearr = Encoding.Default.GetBytes(filetext);
                        txt_in.Text = filetext;
                    }
                }
                else
                {
                    MessageBox.Show("Файла \"" + path + "\" не существует!", " Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                bitarr = new BitArray(Form1.bytearr); // BitArray переделывает байты в биты little-endian
                bitarr = endian.each_byte_negativ_endian(bitarr); // Конвертируем из полученных бит little-endian биты big-endian
                bitarr = bitfunc.add_extra_bit(bitarr);
                bitarr = endian.each_4byte_negativ_endian(bitarr);


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
                    isbinfile = false; // файл обычный
                else
                    isbinfile = true; // файл считаем как бинарный

                // получаем путь С НАЗВАНИЕМ файла
                path = opf.FileName;
                txt_file_in.Text = path;
            }
        }

        // подсчет байтов текста
        private void txt_in_TextChanged(object sender, EventArgs e)
        {
            label3.Text = txt_in.TextLength.ToString();
        }
    }
}
