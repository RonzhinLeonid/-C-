using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Les4Exercise2
{
    static class StaticClass
    {

        static public int[] Add(int n, int x)
        {
            int[] arr = new int[n];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(x * (rand.NextDouble() * 2 - 1));
            }
            return arr;
        }

        static public void PrintArray(int[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"{i} - {items[i]}");
            }
        }
        static public int CountPairs(int[] items)
        {
            int count = 0;
            for (int i = 1; i < items.Length; i++)
            {
                if (items[i - 1] % 3 == 0 && items[i] % 3 == 0)
                    count++;
            }
            return count;
        }
        static public void SaveToFile(string path, int x, int[] arr)
        {
            StreamWriter sw = new StreamWriter(path);

            for (int i = 0; i < x; i++)
            {
                sw.WriteLine(arr[i].ToString());
            }
            sw.Close();
        }
        static public int[] AddFromFile(string path)
        {
            string temp;

                StreamReader sr = new StreamReader(path);
                temp = sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    temp += ";" + sr.ReadLine() ;
                }
                sr.Close();

            var tempArr = temp.Split(';');
                int[] arr = new int[tempArr.Length];  
                for (int i = 0; i < tempArr.Length; i++)
                {
                    arr[i] = Convert.ToInt32(tempArr[i]);
                }
            
            return arr;
        }
    }
}
