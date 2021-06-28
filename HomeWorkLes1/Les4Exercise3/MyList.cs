using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Les4Exercise3
{
    class MyList
    {
        int[] temp;
        int size;

        public MyList()
        {
            temp = new int[1];
            size = 0;
        }

        public MyList(int start, int step, int n)
        {
            temp = new int[1];
            size = 0;
            for (int i = 0; i < n; i++)
            {
                Add(start + step * i);
            }
        }
        public MyList(string path)
        {
            StreamReader sr = new StreamReader(path);
            temp = new int[1];
            size = 0;
            var arr = sr.ReadLine().Split(',');
            //while (!sr.EndOfStream)
            //{
            //    int t = Convert.ToInt32(sr.ReadLine());
            //    Add(t);
            //}
            foreach (var item in arr)
            {
                //int t = Convert.ToInt32(item);
                int t;
                var res = int.TryParse(item, out t);

                if (res) Add(t);
            }
            sr.Close();
        }

        public void SaveToFile(string path)
        {
            StreamWriter sw = new StreamWriter(path);

            for (int i = 0; i < size; i++)
            {
                sw.Write($"{temp[i].ToString()},");
                //sw.WriteLine(temp[i].ToString());
            }
            sw.Close();
        }
        public MyList(int count)
        {
            temp = new int[count];
            size = 0;
        }

        public int this[int index]
        {
            get { return temp[index]; }
            set { temp[index] = value; }
        }

        public int Count { get { return size; } }

        public void Add(int item)
        {
            if (temp.Length <= size) Array.Resize(ref temp, temp.Length * 2);
            temp[size++] = item;
        }


        public void Add(params int[] items)
        {

            for (int i = 0; i < items.Length; i++)
            {
                if (temp.Length <= size) Array.Resize(ref temp, temp.Length * 2);
                temp[size++] = items[i];
            }
        }


        public void Add(int skipIndex, string s = "", params int[] items)
        {

            for (int i = 0; i < items.Length; i++)
            {
                if (temp.Length <= size) Array.Resize(ref temp, temp.Length * 2);
                if (i != skipIndex - 1) temp[size++] = items[i];
            }
        }

        public string GetData()
        {
            string res = "";
            for (int i = 0; i < size; i++)
            {
                res += $"{temp[i]} ";
            }
            return res;
            //return $"{res}";
        }

        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < temp.Length; i++)
                {
                    sum += temp[i];
                }
                return sum; }
        }
        public int Max
        {
            get
            {
                int max = temp[0];
                for (int i = 1; i < temp.Length; i++)
                {
                    if (max < temp[i]) max = temp[i];
                }
                return max;
            }
        }
        public int MaxCount
        {
            get
            {
                int MaxCount = 0;
                int max = temp[0];
                for (int i = 1; i < temp.Length; i++)
                {
                    if (max < temp[i]) max = temp[i];
                }
                for (int i = 0; i < temp.Length; i++)
                {
                    if (max == temp[i]) MaxCount++;
                }
                return MaxCount;
            }
        }
        public int[] Inverse(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = -temp[i];
            }
            return arr;
        }
        public int[] Multi(int n)
        {
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] *= n;
            }
            return temp;
        }

    }
}
