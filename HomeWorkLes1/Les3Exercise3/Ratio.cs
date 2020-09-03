using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace Les3Exercise3
{
    struct Ratio
    {
        private int m;//числитель
        private int n;//знаменатель

        public int M
        {
            get { return m; }
            set { m = value; }
        }
        public int N
        {
            get { return n; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Знаменатель не может быть равен 0");
                }
                else
                {
                    n = value;
                }
            }

        }
        public double Des
        {
            get { return (double)m / n; }
        }
        
        public Ratio(int m, int n)
        {
            this.m = m;
            if (n == 0)
            {
                throw new ArgumentException("Знаменатель не может быть равен 0");
            }
            else
            {
                this.n = n;
            }
        }
        public override string ToString()
        {
            if (m == 0) return $"0";
            else if (m == n) return $"1";
            else if (m == -n || -m == n) return $"1";
            else if ((m < 0 && n < 0) || (m > 0 && n < 0)) return $"{-m}/{-n}";
            else return $"{m}/{n}";
        }

        public static Ratio Multi(Ratio x, Ratio y)
        {
            return new Ratio(
                x.m * y.m,
                x.n * y.n);
        }
        public static Ratio Div(Ratio x, Ratio y)
        {
            Ratio temp = new Ratio(y.n, y.m);
            return Multi(x, temp);
        }
        
        public static Ratio Sum(Ratio x, Ratio y)
        {
            if (x.n == y.n ) return new Ratio(
                 x.m + y.m,
                x.n);
            else return new Ratio(
                x.m * y.n + y.m * x.n,
                x.n * y.n);
        }
        public static Ratio Minus(Ratio x, Ratio y)
        {
            if (x.n == y.n) return new Ratio(
                x.m - y.m,
               x.n);
            else return new Ratio(
                x.m * y.n - y.m * x.n,
                x.n * y.n);
        }
        public static Ratio Simplification(Ratio x)
        {
            int temp = MyMetods.NOD(x.m, x.n);
            if (temp != 1) return new Ratio(x.m / temp, x.n / temp);
            else return x;
            //else return new Ratio(x.m, x.n);
        }

    }
}
