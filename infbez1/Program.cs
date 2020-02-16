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

        // циклический сдвиг влево на m бит
        public static int shiftLeft(Byte b, int m)
        {
            


            BitArray bit = new BitArray(b);
            return 1;
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

        // Переворачивает каждые 32 битf (4 байта)
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
            if (N % 512 < 448)
                Nnew = N + 448 - (N % 512);

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
            int Nnew = 512;
            string h = Convert.ToString(b, 2); // перевели в двоичную систему длину
            string length_bin = new string('0',64 - h.Length); // определили недостающие спереди незначащие нули
            length_bin += h; // приписали двоичное значение
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
