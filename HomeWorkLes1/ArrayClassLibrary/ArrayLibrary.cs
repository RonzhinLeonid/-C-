using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArrayClassLibrary
{
    public class ArrayLibrary
    {
        private int[,] a;
        Random rnd = new Random();
        public ArrayLibrary(int n, int m)
        {
            a = new int[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    a[i, j] = rnd.Next(1, 101);
        }

        public int Min
        {
            get {
                int min = a[0, 0];
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i, j] < min) min = a[i, j];
                    }
                }
                return min;
            }
        }
        public int Max
        {
            get
            {
                int max = a[0, 0];
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i, j] > max) max = a[i, j];
                    }
                }
                return max;
            }
        }

        public int this[int i, int j]
        {
            get { return a[i,j]; }
            set { a[i,j] = value; }
        }

        public void Print()
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0,4}", a[i,j]);
                }
                Console.WriteLine();
            }
        }

        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                   sum += a[i, j];
                }
            }
            return sum;
        }
        public int Sum(int n)
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j]>n)
                    sum += a[i, j];
                }
            }
            return sum;
        }

    }
}
