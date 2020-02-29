using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Collections;

namespace infbez1
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


    // Класс с побитовыми операциями (для самого хэширования)
    public static class bitFunc
    {
        // Начальные значения хеш-функции
        public static UInt32 h0 = 0x67452301;
        public static UInt32 h1 = 0xefcdab89;
        public static UInt32 h2 = 0x98badcfe;
        public static UInt32 h3 = 0x10325476;

        // Циклический сдвиг влево на m бит
        public static UInt32 shiftLeft(UInt32 b, UInt32 m)
        {
            string a_str = Convert.ToString(b, 2).PadLeft(32, '0'); // Перевели число в двоичное в строку

            string b_str = a_str.Substring((int)m);
            b_str += a_str.Remove((int)m);

            UInt32 res = bitFunc.binToDec(b_str);

            return res;
        }

        // перевод из двоичного числа (строки) в число десятичное
        public static UInt32 binToDec(string bin) 
        {
            UInt32 result = 0;
            int N = bin.Length;
            for (int i = N-1; i >= 0; i--)
            {
                if (bin[i] == '1')
                {
                    result += (UInt32)Math.Pow(2, N-1-i);
                }
            }
            return result;
        }

        // Сложением по модулю  (a + b) mod (2^32)
        public static UInt32 plus_mod2_in32(UInt32 a, UInt32 b)
        {
            UInt32 c = Convert.ToUInt32(Convert.ToUInt64(a + b) % Convert.ToUInt64((Math.Pow(2.0,32.0))));
            return c;
        }

        // Функция f
        public static UInt32 f(int j, UInt32 x, UInt32 y, UInt32 z)
        {
            UInt32 res = 0;
            if ((j> 0 && j < 15) || j == 0 || j == 15)
            {
                res = x ^ y ^ z;
            }
            else if ((j > 16 && j < 31) || j == 16 || j == 31)
            {
                res = (x & y) | ((~x) & z);
            }
            else if ((j > 32 && j < 47) || j == 32 || j == 47)
            {
                res = (x | (~y)) ^ z;
            }
            else if ((j > 48 && j < 63) || j == 48 || j == 63)
            {
                res = (x & y) | (y & (~z));
            }
            else if ((j > 64 && j < 79) || j == 64 || j == 79)
            {
                res = x ^ (y | (~z));
            }

            return res;
        }

        // Константа K1
        public static UInt32 K1(int j)
        {
            UInt32 res = 0;
            if ((j > 0 && j < 15) || j == 0 || j == 15)
            {
                res = 0x00000000;
            }
            else if ((j > 16 && j < 31) || j == 16 || j == 31)
            {
                res = 0x5a827999;
            }
            else if ((j > 32 && j < 47) || j == 32 || j == 47)
            {
                res = 0x6ed9eba1;
            }
            else if ((j > 48 && j < 63) || j == 48 || j == 63)
            {
                res = 0x8f1bbcdc;
            }
            else if ((j > 64 && j < 79) || j == 64 || j == 79)
            {
                res = 0xa953fd4e;
            }

            return res;
        }

        // Константа K2
        public static UInt32 K2(int j)
        {
            UInt32 res = 0;

            if ((j > 0 && j < 15) || j == 0 || j == 15)
            {
                res = 0x50a28be6;
            }
            else if ((j > 16 && j < 31) || j == 16 || j == 31)
            {
                res = 0x5c4dd124;
            }
            else if ((j > 32 && j < 47) || j == 32 || j == 47)
            {
                res = 0x6d703ef3;
            }
            else if ((j > 48 && j < 63) || j == 48 || j == 63)
            {
                res = 0x7a6d76e9;
            }
            else if ((j > 64 && j < 79) || j == 64 || j == 79)
            {
                res = 0x0000000;
            }

            return res;
        }

        // Константа R1 Номера выбираемых 32-битных слов из сообщения
        public static UInt32[] R1 = new UInt32[80] {
                                              0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15,
                                              7, 4, 13, 1, 10, 6, 15, 3, 12, 0, 9, 5, 2, 14, 11, 8,
                                              3, 10, 14, 4, 9, 15, 8, 1, 2, 7, 0, 6, 13, 11, 5, 12,
                                              1, 9, 11, 10, 0, 8, 12, 4, 13, 3, 7, 15, 14, 5, 6, 2,
                                              4, 0, 5, 9, 7, 12, 2, 10, 14, 1, 3, 8, 11, 6, 15, 13};

        // Константа R2 Номера выбираемых 32-битных слов из сообщения
        public static UInt32[] R2 = new UInt32[80] {
                                              5, 14, 7, 0, 9, 2, 11, 4, 13, 6, 15, 8, 1, 10, 3, 12,
                                              6, 11, 3, 7, 0, 13, 5, 10, 14, 15, 8, 12, 4, 9, 1, 2,
                                              15, 5, 1, 3, 7, 14, 6, 9, 11, 8, 12, 2, 10, 0, 4, 13,
                                              8, 6, 4, 1, 3, 11, 15, 0, 5, 12, 2, 13, 9, 7, 10, 14,
                                              12, 15, 10, 4, 1, 5, 8, 7, 6, 2, 13, 14, 0, 3, 9, 11};

        // Константа S1 Количество бит, на которое делается сдвиг
        public static UInt32[] S1 = new UInt32[80] {
                                              11, 14, 15, 12, 5, 8, 7, 9, 11, 13, 14, 15, 6, 7, 9, 8,
                                              7, 6, 8, 13, 11, 9, 7, 15, 7, 12, 15, 9, 11, 7, 13, 12,
                                              11, 13, 6, 7, 14, 9, 13, 15, 14, 8, 13, 6, 5, 12, 7, 5,
                                              11, 12, 14, 15, 14, 15, 9, 8, 9, 14, 5, 6, 8, 6, 5, 12,
                                              9, 15, 5, 11, 6, 8, 13, 12, 5, 12, 13, 14, 11, 8, 5, 6};

        // Константа S2 Количество бит, на которое делается сдвиг
        public static UInt32[] S2 = new UInt32[80] {
                                              8, 9, 9, 11, 13, 15, 15, 5, 7, 7, 8, 11, 14, 14, 12, 6,
                                              9, 13, 15, 7, 12, 8, 9, 11, 7, 7, 12, 7, 6, 15, 13, 11,
                                              9, 7, 15, 11, 8, 6, 6, 14, 12, 13, 5, 14, 13, 13, 7, 5,
                                              15, 5, 8, 11, 14, 14, 6, 14, 6, 9, 12, 9, 12, 5, 15, 8,
                                              8, 5, 12, 9, 12, 5, 14, 6, 8, 13, 6, 5, 15, 13, 11, 11};

        // Соединение результата и вывод в виде строки
        public static string result_concat(UInt32 h0, UInt32 h1, UInt32 h2, UInt32 h3)
        {
            string res = "";
            res += Convert.ToString(h0, 16).PadLeft(8, '0');
            res += Convert.ToString(h1, 16).PadLeft(8, '0');
            res += Convert.ToString(h2, 16).PadLeft(8, '0');
            res += Convert.ToString(h3, 16).PadLeft(8, '0');

            return res;
        }

        // Соединение результата в двоичный формат и вывод в виде строки
        public static string result_concat_bin(UInt32 h0, UInt32 h1, UInt32 h2, UInt32 h3)
        {
            string res = "";
            res += Convert.ToString(h0, 2).PadLeft(32, '0');
            res += Convert.ToString(h1, 2).PadLeft(32, '0');
            res += Convert.ToString(h2, 2).PadLeft(32, '0');
            res += Convert.ToString(h3, 2).PadLeft(32, '0');

            return res;
        }

        // Функция возвращает 0, если на входе 1 , и наоборот
        public static Int32 negativBit(Int32 num)
        {
            if (num == 1)
                return 0;
            else if (num == 0)
                return 1;
            else
                return num;
        }

        public static bool negativBit(bool num)
        {
            if (num == true)
                return false;
            else if (num == false)
                return true;
            else
                return num;
        }

        public static int diffBitCount(String a, String b)
        {
            int count = 0;
            for(int i = 0; i < 128; i++)
            {
                if (a[i] != b[i])
                    count++;
            }



            return count;
        }


        // Основной цикл алгоритма хэширования
        public static string hesh()
        {

            int t = var_glob.bytearrnew.Length / 64; // Количество блоков по 64 байта (512 бит)
                                                     // Дальше хэширования начинается
            UInt32 A1, A2, B1, B2, C1, C2, D1, D2, T, h0, h1, h2, h3;
            h0 = bitFunc.h0;
            h1 = bitFunc.h1;
            h2 = bitFunc.h2;
            h3 = bitFunc.h3;

            for (int i = 0; i < t; i++) // Основной цикл алгоритма
            {
                A1 = h0;
                A2 = h0;
                B1 = h1;
                B2 = h1;
                C1 = h2;
                C2 = h2;
                D1 = h3;
                D2 = h3;

                for (int j = 0; j < 64; j++)
                {
                    T = bitFunc.plus_mod2_in32(A1, bitFunc.f(j, B1, C1, D1));
                    T = bitFunc.plus_mod2_in32(T, var_glob.bytearrnew[64 * i + bitFunc.R1[j]]);
                    T = bitFunc.plus_mod2_in32(T, bitFunc.K1(j));
                    T = bitFunc.shiftLeft(T, bitFunc.S1[j]);

                    A1 = D1;
                    D1 = C1;
                    C1 = B1;
                    B1 = T;

                    T = bitFunc.plus_mod2_in32(A2, bitFunc.f(63 - j, B2, C2, D2));
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

            return bitFunc.result_concat(h0, h1, h2, h3); 
        }

        // Цикл алгоритма хэширования для лавинного эффекта
        public static void hesh_modified(bool mod)
        {
            UInt32 A1, A2, B1, B2, C1, C2, D1, D2, T, h0, h1, h2, h3;
            h0 = bitFunc.h0;
            h1 = bitFunc.h1;
            h2 = bitFunc.h2;
            h3 = bitFunc.h3;

            for (int j = 0; j < 64; j++) // Основной цикл алгоритма
            {
                A1 = h0;
                A2 = h0;
                B1 = h1;
                B2 = h1;
                C1 = h2;
                C2 = h2;
                D1 = h3;
                D2 = h3;

                
                T = bitFunc.plus_mod2_in32(A1, bitFunc.f(j, B1, C1, D1));
                T = bitFunc.plus_mod2_in32(T, var_glob.bytearrnew[bitFunc.R1[j]]);
                T = bitFunc.plus_mod2_in32(T, bitFunc.K1(j));
                T = bitFunc.shiftLeft(T, bitFunc.S1[j]);

                A1 = D1;
                D1 = C1;
                C1 = B1;
                B1 = T;

                T = bitFunc.plus_mod2_in32(A2, bitFunc.f(63 - j, B2, C2, D2));
                T = bitFunc.plus_mod2_in32(T, var_glob.bytearrnew[bitFunc.R2[j]]);
                T = bitFunc.plus_mod2_in32(T, bitFunc.K2(j));
                T = bitFunc.shiftLeft(T, bitFunc.S2[j]);

                A2 = D2;
                D2 = C2;
                C2 = B2;
                B2 = T;

                T = bitFunc.plus_mod2_in32(bitFunc.plus_mod2_in32(h1, C1), D2);
                h1 = bitFunc.plus_mod2_in32(bitFunc.plus_mod2_in32(h2, D1), A2);
                h2 = bitFunc.plus_mod2_in32(bitFunc.plus_mod2_in32(h3, A1), B2);
                h3 = bitFunc.plus_mod2_in32(bitFunc.plus_mod2_in32(h0, B1), C2);
                h0 = T;

                if(mod == false)
                {
                    var_glob.bitNorm[j] = bitFunc.result_concat_bin(h0, h1, h2, h3);
                }
                else
                    var_glob.bitMod[j] = bitFunc.result_concat_bin(h0, h1, h2, h3);
            }

        }

    }

    // Класс преобразованием сообщения для дальнейшего хэширования
    public static class messageTransform
    {
        // Переворачивает каждые 8 бит (каждый байт) в последовательности бит
        // big -> little или little -> big endian
        public static BitArray each_byte_negativ_endian(BitArray x)
        {
            BitArray y = new BitArray(x.Length);
            int N = x.Length;
            int i = 0, j = 0, k = 0, count = 0;

            while( i < N/8)
            {
                j = i*8 + 7;
                count = 8;
                while ( count > 0)
                {
                    y[k] = x[j];
                    k++;
                    j--;
                    count--;
                }
                i++;
            }
            return y;
        }

        // Переворачивает каждые 32 бит (4 байта)
        // из обычной последовательности 32 бит делает слово 
        public static BitArray each_4byte_negativ_endian(BitArray x)
        {
            BitArray y = new BitArray(x.Length);
            int N = x.Length;
            int i = 0, j = 0, k = 0, count = 0;

            while (i < N / 32)
            {
                j = i * 32 + 31;
                count = 32;
                while (count > 0)
                {
                    y[k] = x[j];
                    k++;
                    j--;
                    count--;
                }
                i++;
            }

            return y;
        }

        // Дополняет дополнительные биты к битам текста для кратности длины = 448
        public static BitArray add_extra_bit(BitArray x)
        {
            int N = x.Length;
            int Nnew = 0;

            if (N <= 447)
                Nnew = 448;
            else if(N > 447)
            {
                Nnew = N + 448 - (N % 448);
            }


            BitArray y = new BitArray(Nnew);

            // скопировали уже имеющийся биты
            for(int j = 0; j < N; j++)
            {
                y[j] = x[j];
            }
            
            y[N] = true; // Добавляем бит 1
            int i = N+1;
            while(i < Nnew) // Дополняются нулевыми битами до 448
            {
                y[i] = false;
                i++;
            }
            return y;
        }

        // Дополняет биты длины исходного сообщения к битам текста до кратности длины = 512
        public static BitArray add_length_bit(BitArray x, int b)
        {
            int N = x.Length;
            int Nnew = N + 64; 
            string length_bin = Convert.ToString(b, 2).PadLeft(64,'0'); // перевели в двоичную систему длину

            // переконвертировали нули и единицы в "true" и "false"
            string[] length_bin_str = new string[64];
            for(int j = 0; j < 64; j++)
            {
                if (length_bin[j] == '0')
                    length_bin_str[j] = "false";
                else if (length_bin[j] == '1')
                    length_bin_str[j] = "true";
            }

            BitArray y = new BitArray(Nnew);

            // скопировали уже имеющийся биты
            for (int j = 0; j < N; j++)
            {
                y[j] = x[j];
            }
            // Дополняем 448 бит до 512 битов двоичным представлением длины
            int i = N;
            int k = 32;
            // дописываем младшие 4 байта (последние 32 бита)
            bool val_bin = false;
            while (k < 64) 
            {
                Boolean.TryParse(length_bin_str[k], out val_bin);
                y[i] = val_bin;
                i++;
                k++;
            }
            k = 0;
            // дописываем с 1 до 32 бита (старшие 4 байта)
            while (k < 32)
            {
                Boolean.TryParse(length_bin_str[k], out val_bin);
                y[i] = val_bin;
                i++;
                k++;
            }
            return y;
        }

    }
}
