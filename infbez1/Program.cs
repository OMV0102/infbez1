using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace LR1__program_CS
{
    static class Program
    {
        // Главная точка входа для приложения.
        [STAThread]
        static void Main()
        {
            // Запуск windows forms
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    //-------------------------------------------------------------

    class Methods
    {
        // Функция перевод q в двоичную СС
        public string ToBinary(double q, int l) 
        {
            string code = ""; // строка с кодом символа
            if (q >= 1)  //Если вероятность больше 1
                throw new Exception("Error");

            for (int i = 0; i < l; i++)
            {
                q *= 2;  // число умножаем на 2
                code += Convert.ToString((int)q); // запоминаем целую часть числа
                if (q >= 1) // если число больше 1 , то q-1,
                    q--;
                //тк работаем только с дробной частью, 
                //целая часть нужна только для определения четности/нечетности
            }
            return code;
        }

        //-------------------------------------------------------------

        // Функция ЧТЕНИЯ ИЗ ФАЙЛА
        public string Text_Read(string filename)
        {
            string text;
            //Создаем читатель Reader из файла (в filename хранится название файла)
            var Reader = new StreamReader(File.Open(filename, FileMode.Open), Encoding.Default);
            // Считываение строки из файла
            text = Reader.ReadLine();
            // Закрываем читатель Reader
            Reader.Close();
            // Возвращаем считанный исходный текст
            return text;
        }

        //-------------------------------------------------------------

        //Функция ЗАПИСИ В ФАЙЛ 
        public void Text_Save(string file_text, string out_txt)
        {
            // Создаем поток для записи 
            using (StreamWriter outputFile = new StreamWriter(file_text))
            outputFile.WriteLine(out_txt); // Записываем строку в файл 
        }

        //-------------------------------------------------------------
    }

    //Структура для определения одного символа алфавита
    class symbol
    { 
        // кодовое слово
        public string code; 
        // символ
        public string letter;  
        // вероятность, кумулятивная вероятность
        public double p, q;   
        // целое число, отвечающиее за длину кода символа
        public int l;    
        // порядковый номер, при считывании
        public int n;
    }

    //-------------------------------------------------------------

    class Algorithm_Shannon
    {
        // таблица хранения символов алфавита со структурой определенной выше
        List<symbol> table = new List<symbol>(); 

        // КОДИРОВАНИЕ СИМВОЛОВ алфавита 
        public void Encode_Symbols(string str_alph, string str_p) 
        {
            // Запоминаем вероятности без пробелов в вспомогательный массив
            string[] p = str_p.Split(' '); 
            // Запоминаем алфавит без пробелов в вспомогательный массив
            string[] symbols = str_alph.Split(' '); 

            // Если количество символов или вероятностей меньше одного
            // Если количество символов не совпадает с количеством вероятностей
            if (p.GetLength(0) < 1  || symbols.GetLength(0) < 1 || symbols.GetLength(0) != p.GetLength(0)) 
                throw new Exception("Ошибка!");

            symbol tmp; //Вспомогательная переменная для записи алфавита в таблицу 
            for (int i = 0; i < symbols.GetLength(0); i++)
            {
                // создать новое звено
                tmp = new symbol();             
                // запоминаем порядковые номер при считывании
                tmp.n = i;                       
                // записать в него символ
                tmp.letter = symbols[i];        
                // записать в него вероятность
                tmp.p = Convert.ToDouble(p[i]); 
                // занести его в таблицу
                table.Add(tmp);                  
            }

            // Пузырьковая сортировка
            // Сортируем таблицу по убыванию вероятностей
            int n = table.Count;
            bool s = true;
            tmp = new symbol();
            while (s)
            {
                s = false;
                for (int i = 0; i < n-1 ; i++)
                {
                    //Если нашли вероятности не по убыванию
                    if(table[i].p < table[i+1].p)
                    {
                        // то меняем местами символы
                        tmp = table[i];
                        table[i] = table[i + 1];
                        table[i + 1] = tmp;
                        s = true;
                    }
                }
                n--;
            }

            var met = new Methods();
            for (int i = 0; i < table.Count; i++)
            {
                // для первого символа кумулятивная вероятность = 0
                if (i == 0) table[0].q = 0.0; 
                // для остальных 
                else table[i].q = table[i - 1].q + table[i - 1].p;

                // считаем длину кода символа алфавита
                double L = -Math.Log(table[i].p, 2);
                //округляем до целого значение
                table[i].l = (int)Math.Round(L);
                // если округленное число меньше посчитанного, то +1
                if (table[i].l < L) table[i].l++;

                // считаем код символа с помощью двоичного представления
                // перевод q в двоичную CC с точностью до дробной части 
                // передаем кумулятивную вероятность, длину кода
                table[i].code = met.ToBinary(table[i].q, table[i].l);
            }
        }

        //-------------------------------------------------------------

        public string Encode_text(string text) // КОДИРОВАНИЕ ТЕКСТА
        {
            // Если таблица пуста
            if (table.Count == 0) 
                throw new Exception("Ошибка!");
            
            //строка с результатом кодирования
            string res = "";  
            //буфер для сравнивания символов строки и алфавита
            string tmp = "";    
            int i = 0;
            
            // Допустим 1-ый символ алфавита имеет макс длину
            int l_max = table[0].letter.Length; 
            //Ищем макс длину кодов в алфавите
            for (int j = 1; j < table.Count; j++)   
                // макс длина меньше длины символа в алфавите
                if (l_max < table[j].letter.Length)   
                // найденный символ с большей длиной становится макс
                    l_max = table[j].letter.Length;     
            
            // Кодируем , пока есть еще символы считанной строки
            while (i < text.Length)        
            {
                // Кладем в буффер символ считанной строки
                    tmp += text[i];  

                // если длина буффера больше чем макс длина кода в алфавите
                if (tmp.Length > l_max)     
                    throw new Exception("Данная последовательность не может быть закодирована!");
                
                // Просматриваем всю таблицу
                for (int j = 0; j < table.Count; j++) 
                    // Если находим символ совпадающий с символом в таблице
                    if (tmp == table[j].letter) 
                    {
                        // в строку с результатом добавляем код этого символа
                        res += table[j].code; 
                        // очищаем буфер
                        tmp = "";           
                        // прекращаем поиск дальше по таблице
                        j = table.Count;     
                    } 
            // увеличиваем счетчик просмотренных символов считанной строки
                i++;      
            }
            // после кодирования возвращаем закодированную строку
            return res; 
        }

        //-------------------------------------------------------------

        public string Decode_text(string text) // ДЕКОДИРОВАНИЕ ТЕКСТА
        {
            // Если таблица пуста
            if (table.Count == 0) 
                throw new Exception("Таблица пуста!"); 
            
            // Строка расскодированного кода,
            string res = "";
            // Вспомогательная строка
            string tmp = "";  
            
            // Допустим код 1-ого символа алфавита имеет макс длину
            int l_min = table[0].l; 
            // или допустим код 1-ого символа алфавита имеет мин длину
            int l_max = table[0].l; 
            //Ищем мин и макс длину кодов в алфавите
            for (int j = 1; j < table.Count; j++) 
            {
                // мин длина кода больше длины кода символа в алфавите 
                if (l_min > table[j].l)    
                // найденный символ с меньшей длиной кода становится мин
                    l_min = table[j].l;     
                
                // макс длина кода меньше длины кода символа в алфавите 
                if (l_max < table[j].l)   
                // найденный символ с большей длиной кода становится макс
                    l_max = table[j].l;     
            }

            int k = 0;
            // рассшифровываем , пока есть еще символы считанной строки
            while (k < text.Length)  
            {
                //Накапливаем в буффере мин длину кода символов считанной строки 
                while (tmp.Length < l_min)  
                {
                    // Кладем в буффер символ считанной строки
                    tmp += text[k];        
                    // увеличиваем счетчик просмотренных символов считанной строки
                    k++;                   
                }

                // если длина буффера меньше макс длины кода и больше мин длины кода
                while (tmp.Length >= l_min && tmp.Length <= l_max)
                { 
                    // Просматриваем всю таблицу
                    for (int j = 0; j < table.Count; j++) 
                        // Если находим код совпадающий с кодом символа в таблице
                        if (tmp == table[j].code)   
                        {
                            // в строку с результатом добавляем символ по этому коду
                            res += table[j].letter; 
                            // очищаем буфер
                            tmp = "";          
                            // прекращаем поиск дальше по таблице
                            j = table.Count;           
                        }
                    // если остались еще символы в строке
                    if (k < text.Length) 
                    {
                        // Кладем в буффер символ считанной строки
                        tmp += text[k]; 
                        // увеличиваем счетчик просмотренных символов считанной строки
                        k++;  
                    }
                    // если длина буффера больше > макс длина кода в алфавите
                    if (tmp.Length > l_max)
                        throw new Exception("Данная последовательность не может быть раскодирована!");
                }
            }
            // после декодирования возвращаем закодированную строку
            return res; 
        }

        //-------------------------------------------------------------

        public string Show_Codes() //  КОДЫ АЛФАВИТА
        {
            string res = "";
            // Ищем в таблице элемент с первоначальным номер i
            for (int i = 0; i < table.Count; i++)  
                // Просматриваем всю таблицу
                for(int j = 0; j < table.Count; j++)
                    // если нашли изначальный порядковый номер при считывании
                    if (i == table[j].n)            
                    { 
                        // Выводим коды элементов в первоначальном порядке (до сортировки) 
                        res += table[j].code + " ";
                        // выходим из поиска по табл, переходим к следующему элементу
                        j = table.Count; 
                    }
            //возвращаем последовательность кодов
            return res; 
        }

        //-------------------------------------------------------------

        public string Average_Length() // СРЕДНЯЯ ДЛИНА КОДА СИМВОЛОВ
        {
            double sum = 0.0;
            // просматриваем длину кода каждого символа в таблице
            for (int i = 0; i < table.Count; i++) 
            { 
                //Средняя длина = вероятность * длина кода
                sum += table[i].p * table[i].l;
            }
            // возвращаем среднюю длину
            return Convert.ToString(sum); 
        }

        //-------------------------------------------------------------

        public double Redundancy() // ИЗБЫТОЧНОСТЬ
        {
            double red = 0.0;  //избыточность
            double Entropy = 0.0;  //энтропия

            for (int i = 0; i < table.Count; i++)
                // Энтропия = вероятность * log(вероятность)
                Entropy += table[i].p * -Math.Log(table[i].p, 2);

            // Избыточность = 1 - Энтропия / log(кол-во символов)
            red = 1 - Entropy / Math.Log(table.Count, 2);
            if(Math.Abs(red) < CONST.EPS)  // проверка: если избыточность меньше погрешности, 
                red = 0.0;  // то избыточность = 0
            return red;
        }

        //-------------------------------------------------------------

        public string Check_Craft() // проверка НЕРАВЕНСТА КРАФТА
        {
            string ans;
            double res = 0.0;

            for (int i = 0; i < table.Count; i++)
                // Сумма чисел 2^(-длина кода символа)
                res += Math.Pow(2, -table[i].l);
            // Если сумма чисел > 1, то не выполняется
            if (res <= 1.0)
                ans = "Выполняется";

            else ans = "Не выполняется";

            return ans;
        }
    }
}
