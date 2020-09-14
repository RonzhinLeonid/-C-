using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;
using System.IO;
using System.Diagnostics;

namespace Les6Exercise4
{
    class Program
    {
        //Сергей в этом задании смог реализовать толкьо для байтового потока метод,
        //для символьного и двоичного потоков есть затруднения с определением размера массива под данные из файла
        //как определять в данном случае размер под массив, или тут подходит метод который мы описывали для массива
        //на предыдущих уроках с увеличенем размера массива в 2 раза?
        

        //Ронжин Л.
        //**Считайте файл различными способами. Смотрите “Пример записи файла различными способами”.
        //Создайте методы, которые возвращают массив byte (FileStream, BufferedStream),
        //строку для StreamReader и массив int для BinaryReader.

        static void Main(string[] args)
        {
            long kbyte = 1024;
            long mbyte = 1024 * kbyte;
            long gbyte = 1024 * mbyte;
            long size = mbyte;
            //Write FileStream
            //Write BinaryStream
            //Write StreamReader/StreamWriter
            //Write BufferedStream

            Console.WriteLine("FileStream. Milliseconds:{0}", FileStreamSample("bigdata0.bin", size));
            Console.WriteLine("BinaryStream. Milliseconds:{0}", BinaryStreamSample("bigdata1.bin", size));
            Console.WriteLine("StreamWriter. Milliseconds:{0}", StreamWriterSample("bigdata2.bin", size));
            Console.WriteLine("BufferedStream. Milliseconds:{0}", BufferedStreamSample("bigdata3.bin", size));

            byte[] FSArr = FileStreamSampleArr("bigdata0.bin", size);
            int[] BinSArr = BinaryStreamSampleArr("bigdata1.bin", size);
            string[] SWArr = StreamWriterSampleArr("bigdata2.bin", size);
            byte[] BufSArr = BufferedStreamSampleArr("bigdata3.bin", size);


            Console.ReadKey();
        }

        static long FileStreamSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
           //FileStream fs = new FileStream("bigdata.bin", FileMode.CreateNew, FileAccess.Write);
            for (int i = 0; i < size; i++)
                fs.WriteByte(34);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }
        static byte[] FileStreamSampleArr(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            byte[] temp = new byte[fs.Length / sizeof(byte)]; 
            //FileStream fs = new FileStream("bigdata.bin", FileMode.CreateNew, FileAccess.Write);
            for (int i = 0; i < size; i++)
                temp[i] = (byte)fs.ReadByte();
            fs.Close();
            stopwatch.Stop();
            return temp;
        }

        static long BinaryStreamSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            for (int i = 0; i < size; i++)
                bw.Write((byte)35);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }
        static int[] BinaryStreamSampleArr(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            int[] temp = new int[fs.Length / sizeof(int)];
            for (int i = 0; i < fs.Length / sizeof(int); i++)
                temp[i] = br.ReadInt32();
            fs.Close(); 
            stopwatch.Stop();
            return temp;
        }

        static long StreamWriterSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < size; i++)
                sw.Write("ffg");
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }
        static string[] StreamWriterSampleArr(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            string[] temp = new string[fs.Length ];// / sizeof(string)
            StreamReader sw = new StreamReader(fs);
            for (int i = 0; i < size; i++)
                temp[i] = Convert.ToString(sw.Read());
            fs.Close();
            stopwatch.Stop();
            return temp;
        }

        static long BufferedStreamSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            int countPart = 4;//количество частей
            int bufsize = (int)(size / countPart);
            byte[] buffer = new byte[size];
            BufferedStream bs = new BufferedStream(fs, bufsize);
            //bs.Write(buffer, 0, (int)size);//Error!
            for (int i = 0; i < countPart; i++)
                bs.Write(buffer, 0, (int)bufsize);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }
        static byte[] BufferedStreamSampleArr(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            int countPart = 4;//количество частей
            int bufsize = (int)(size / countPart);
            byte[] buffer = new byte[size];
            BufferedStream bs = new BufferedStream(fs, bufsize);
            //bs.Write(buffer, 0, (int)size);//Error!
            for (int i = 0; i < countPart; i++)
                bs.Read(buffer, 0, (int)bufsize);
            fs.Close();
            stopwatch.Stop();
            return buffer;
        }
    }
}
