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
using System.Windows.Forms.DataVisualization.Charting;

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
                        txt_in.Text = " ";
                        txt_in.Text = "";
                        //txt_in.Text = Encoding.Default.GetString(var_glob.bytearr).Replace('\0', ' ');
                    }
                    else
                    {
                        var_glob.filetext = File.ReadAllText(var_glob.path, Encoding.Default); // Кодировка ANSI
                        //var_glob.bytearr = Encoding.Default.GetBytes(var_glob.filetext);  // Кодировка ANSI
                        var_glob.TextLength = var_glob.filetext.Length;
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

            txt_out.Text = "";
            if(var_glob.isbinfile == false)
            {
                var_glob.bytearr = Encoding.Default.GetBytes(txt_in.Text);  // Кодировка ANSI
            }

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

                string res = bitFunc.hesh();
                txt_out.Text = res;
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

        // изменяем текст
        private void txt_in_TextChanged(object sender, EventArgs e)
        {
            var_glob.isbinfile = false;
            txt_file_in.Text = "";

        }

        // кнопка ИССЛЕДОВАТЬ 
        private void btn_analyz_Click(object sender, EventArgs e)
        {
            if (txt_in.Text.Length > 512)
            {
                MessageBox.Show("Длина сообщения для проверки лавинного эффекта должна быть не больше 512 бит (64 символа)!", " Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var_glob.bitMod = new string[64];
                var_glob.bitNorm = new string[64];
                var_glob.diffBitCount = new int[64];

                if (var_glob.isbinfile == false)
                {
                    var_glob.bytearr = Encoding.Default.GetBytes(txt_in.Text);  // Кодировка ANSI
                }

                var_glob.bitarr = new BitArray(var_glob.bytearr); // BitArray переделывает байты в биты little-endian
                var_glob.bitarr = messageTransform.each_byte_negativ_endian(var_glob.bitarr); // Конвертируем из полученных бит little-endian биты big-endian
                                                                                              // 1 шаг
                var_glob.bitarr = messageTransform.add_extra_bit(var_glob.bitarr); // Добавляем доп. биты до длины кратной 448
                var_glob.bitarr = messageTransform.each_4byte_negativ_endian(var_glob.bitarr); // Конвертируем биты по 4 байта (1 слову) в биты little-endian
                                                                                               // 2 шаг
                var_glob.bitarr = messageTransform.add_length_bit(var_glob.bitarr, var_glob.TextLength); // Добавили двоичное представление длины исходного текста
                var_glob.bitarr = messageTransform.each_byte_negativ_endian(var_glob.bitarr); // Конвертируем из бит big-endian в little-endian, т.к. битово-байтовая конвертация идет как little-endian

                // нашли хеш для исходного
                var_glob.bytearrnew = new byte[var_glob.bitarr.Length / 8]; // Исходный массив байтов до начала хэширования
                var_glob.bitarr.CopyTo(var_glob.bytearrnew, 0); // из битов в байты
                bitFunc.hesh_modified(false);

                // нашли хеш для измененного с одном битом
                var_glob.bitarr[(Int32)numeric.Value] = bitFunc.negativBit(var_glob.bitarr[(Int32)numeric.Value]);
                var_glob.bytearrnew = new byte[var_glob.bitarr.Length / 8];
                bitFunc.hesh_modified(true);

                //сравниваем хеши  при кажом раунде
                for(int i = 0; i < 64; i++)
                {
                    var_glob.diffBitCount[i] = bitFunc.diffBitCount(var_glob.bitNorm[i], var_glob.bitMod[i]);
                }

                Form1 n = new Form1();
                n.plot();


            }
        }

        public void plot()
        {


            //добавляем в Chart область для рисования графиков, их может быть
            //много, поэтому даем ей имя.
            chart1.ChartAreas.Add(new ChartArea("bit"));
            //Создаем и настраиваем набор точек для рисования графика, в том
            //не забыв указать имя области на которой хотим отобразить этот
            //набор точек.
            Series mySeriesOfPoint = new Series("bit_point");
            mySeriesOfPoint.ChartType = SeriesChartType.Line;
            mySeriesOfPoint.ChartArea = "bit";
            for (double x = -Math.PI; x <= Math.PI; x += Math.PI / 10.0)
            {
                mySeriesOfPoint.Points.AddXY(x, Math.Sin(x));
            }
            //Добавляем созданный набор точек в Chart
            chart1.Series.Add(mySeriesOfPoint);


            /*
            chart1.Series.Clear();

            // Add series.
            for (int i = 0; i < 64; i++)
            {
                // Add series.
                //chart1.Series.Add(seriesArray[i].ToString()); // chart1.Series.Add(i.ToString());
                chart1.Series.Add(i.ToString());
                

                //chart1.Series[0].Points.AddXY(i + 1, pointsArray[i]);
                chart1.Series[0].Points.AddXY(i + 1, var_glob.diffBitCount[i]);

            }
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Legends.Clear();
            */
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


        public static String[] bitNorm; // хеш  в битах исходного собщения
        public static String[] bitMod; // хеш  в битах измененного собщения

        public static int[] diffBitCount; // Массив с данными для графика
    }
}
