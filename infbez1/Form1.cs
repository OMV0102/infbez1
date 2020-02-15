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


        // Если нажимаем на кнопку ПРОЧИТАТЬ
        private void btm_Rfile_text_Click(object sender, EventArgs e)
        {
            try
            {

                string filepath = txt_file_in.Text;
                string filetext = "";
                // читаем файл в строку
                filetext = File.ReadAllText(filepath, Encoding.Default);
                byte[] bb = Encoding.Default.GetBytes(filetext);

                Byte[] b = File.ReadAllBytes(filepath);
                //filetext = filetext.Replace('\0',' ') ;
                
                filetext = Convert.ToBase64String(b);
                /*int nn = filetext.Length;
                for (int i = 0; i < nn; i++)
                {
                    char g = filetext[i];
                    txt_in.Text += g;
                }*/


                /*using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
                {
                    // пока не достигнут конец файла
                    // считываем каждое значение из файла
                    while (reader.PeekChar() > -1)
                    {
                        string tmp = reader.ReadString();
                        str += tmp;

                        
                    }
                }*/
                txt_in.Text = filetext;


                //======================================================
                var n = new Methods();
            // Если какое то из полей не заполнено:
           // файл с исходным текстом или файл с символами алфавита или файл с вероятностями
                if (txt_file_in.Text == "")
                {
                    MessageBox.Show("Не для всех полей указаны имена файлов!", " Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Некоторые исходные данные были НЕ прочитаны!", " Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   

        // Если нажимаем на кнопку ХЭШИРОВАТЬ
        private void btm_coding_Click(object sender, EventArgs e) 
        {
            try
            {
                //var m = new Algorithm_Shannon();
                // Если какое то из полей не заполнено:
                // исходный текст или символы алфавита или вероятности
                if (txt_in.Text == "")
                {
                    MessageBox.Show("Не все поля заполнены данными!", " Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Проверяем: сумма вероятностей была равна единице
                //string[] tmp2 = txt_p.Text.Split(' ');  //Конвертируем вероятности из строки в массив
                double p1 = 0.0;    // вероятность = 0
                //складываем вероятности
                //for (int i = 0; i < tmp2.GetLength(0); i++)
                //    p1 += Convert.ToDouble(tmp2[i]);

                if (Math.Abs( 1 - p1) >= CONST.EPS) // если вероятность в сумме НЕ 1 
                {
                    MessageBox.Show("Неверные данные.\nСумма вероятностей не равна 1 !", " Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Кодируем символы алфавита
                //m.Encode_Symbols(txt_alph.Text, txt_p.Text);
                
                // Вывод кодов алфавита
                //txt_code.Text = m.Show_Codes(); 

                // Кодируем исходный текст и выводим его в (правое) поле
                //txt_out.Text = m.Encode_text(txt_in.Text);

                // Вывод средней длины кодового слова
                //txt_average_length.Text = m.Average_Length();

                // Вывод избыточности
                //txt_redundancy.Text = m.Redundancy().ToString();

                // Вывод выполняемости неравенства Крафта
                //txt_inequality_kraft.Text = m.Check_Craft();
            }
            catch (Exception error)
            {
                MessageBox.Show("Кодирование последовательности невозможно.\nПроверьте правильность входных данных!", " Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Если нажимаем на кнопку ЗАПИСАТЬ полученный ТЕКСТ
        private void btm_Wfile_text_Click(object sender, EventArgs e) 
        {
            var n = new Methods();
            
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
                txt_file_in.Text = opf.FileName;
            }
        }

    }

    static class CONST
    {
        //точность вычислений (абсолютная погрешность)
        public static double EPS = 1e-8;
    }
}
