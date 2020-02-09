using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//TODO сделать глобальную переменную под путь для всех файлов

namespace LR1__program_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //-------------------------------------------------------------

        // Если нажимаем на кнопку ПРОЧИТАТЬ
        private void btm_Rfile_text_Click(object sender, EventArgs e)
        {
            try
            {
                var n = new Methods();
            // Если какое то из полей не заполнено:
           // файл с исходным текстом или файл с символами алфавита или файл с вероятностями
                if (txt_file_in.Text == "" || txt_file_alph.Text == "" || txt_file_p.Text == "")
                {
                    MessageBox.Show("Не для всех полей указаны имена файлов!", " Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                // очистка (левого) поля исходного текста
                in_txt.Clear();  
                // очистка (правого) поля полученного текста
                out_txt.Clear();

                // Вывод исходного текста в левое поле
                in_txt.Text = n.Text_Read(txt_file_in.Text);

                // Вывод символов алфавита
                txt_alph.Text = n.Text_Read(txt_file_alph.Text);

                // Вывод количества символов в алфавите
                string[] tmp1 = txt_alph.Text.Split(' ');
                txt_count_alph.Text = Convert.ToString(tmp1.Length);

                // Вывод вероятностей алфавита
                txt_p.Text = n.Text_Read(txt_file_p.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show("Некоторые исходные данные были НЕ прочитаны!", " Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-------------------------------------------------------------

        // Если нажимаем на кнопку ЗАКОДИРОВАТЬ
        private void btm_coding_Click(object sender, EventArgs e) 
        {
            try
            {
                var m = new Algorithm_Shannon();
                // Если какое то из полей не заполнено:
                // исходный текст или символы алфавита или вероятности
                if (in_txt.Text == "" || txt_alph.Text == "" || txt_p.Text == "")
                {
                    MessageBox.Show("Не все поля заполнены данными!", " Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Проверяем: сумма вероятностей была равна единице
                string[] tmp2 = txt_p.Text.Split(' ');  //Конвертируем вероятности из строки в массив
                double p1 = 0.0;    // вероятность = 0
                //складываем вероятности
                for (int i = 0; i < tmp2.GetLength(0); i++)
                    p1 += Convert.ToDouble(tmp2[i]);

                if (Math.Abs( 1 - p1) >= CONST.EPS) // если вероятность в сумме НЕ 1 
                {
                    MessageBox.Show("Неверные данные.\nСумма вероятностей не равна 1 !", " Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Кодируем символы алфавита
                m.Encode_Symbols(txt_alph.Text, txt_p.Text);
                
                // Вывод кодов алфавита
                txt_code.Text = m.Show_Codes(); 

                // Кодируем исходный текст и выводим его в (правое) поле
                out_txt.Text = m.Encode_text(in_txt.Text);

                // Вывод средней длины кодового слова
                txt_average_length.Text = m.Average_Length();

                // Вывод избыточности
                txt_redundancy.Text = m.Redundancy().ToString();

                // Вывод выполняемости неравенства Крафта
                txt_inequality_kraft.Text = m.Check_Craft();
            }
            catch (Exception error)
            {
                MessageBox.Show("Кодирование последовательности невозможно.\nПроверьте правильность входных данных!", " Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-------------------------------------------------------------

        // Если нажимаем на кнопку РАСКОДИРОВАТЬ
        private void btm_decoding_Click(object sender, EventArgs e) 
        {
            try
            {
                var m = new Algorithm_Shannon();
                // Если какое то из полей не заполнено:
                // исходный текст или символы алфавита или вероятности
                if (in_txt.Text == "" || txt_alph.Text == "" || txt_p.Text == "")
                {
                    MessageBox.Show("Не все поля заполнены данными!", " Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Проверяем: сумма вероятностей была равна единице
                string[] tmp2 = txt_p.Text.Split(' ');  //Конвертируем вероятности из строки в массив
                double p1 = 0.0;   // вероятность = 0
                //складываем вероятности
                for (int i = 0; i < tmp2.GetLength(0); i++)
                    p1 += Convert.ToDouble(tmp2[i]);

                if (Math.Abs(1 - p1) >= CONST.EPS) // если вероятность в сумме НЕ 1 
                {
                    MessageBox.Show("Неверные данные.\nСумма вероятностей не равна 1 !", " Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Кодируем символы алфавита
                m.Encode_Symbols(txt_alph.Text, txt_p.Text);

                // Вывод кодов алфавита
                txt_code.Text = m.Show_Codes();

                // Рассшифровываем исходный текст и выводим его в (правое) поле
                out_txt.Text = m.Decode_text(in_txt.Text);

                // Вывод средней длины кодового слова
                txt_average_length.Text = m.Average_Length();

                // Вывод избыточности
                txt_redundancy.Text = m.Redundancy().ToString();

                // Вывод выполняемости неравенства Крафта
                txt_inequality_kraft.Text = m.Check_Craft();
            }
            catch (Exception error)
            {
                MessageBox.Show("Данная последовательность не может быть раскодирована!", " Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-------------------------------------------------------------

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
            if (out_txt.Text == "") 
            {
                MessageBox.Show("Запись текста невозможна.\nПоле с текстом пустое!", " Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // вызов функции, которая записывает текст
            n.Text_Save(txt_file_out.Text, out_txt.Text); 
            MessageBox.Show("Полученный текст записан в файл.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //-------------------------------------------------------------

        // Если нажимаем на кнопку ЗАПИСАТЬ КОДЫ алфавита
        private void txt_Wfile_code_Click(object sender, EventArgs e)  // Если нажимаем на кнопку ЗАПИСАТЬ КОДЫ алфавита
        {
            var n = new Methods();

            // Если не указано имя файла
            if (txt_file_code.Text == "")
            {
                MessageBox.Show("Не указано имя файла для записи кодов алфавита!", " Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
            
            //Если поле с кодами символов пустое
            if (txt_code.Text == "") 
            {
                MessageBox.Show("Запись кодов невозможна.\nПоле с кодами пустое!", " Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // вызов функции для записи кодов символов в файл
            n.Text_Save(txt_file_code.Text, txt_code.Text);  
            MessageBox.Show("Полученные коды символов записаны в файл.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    static class CONST
    {
        //точность вычислений (абсолютная погрешность)
        public static double EPS = 1e-8;
    }
}
