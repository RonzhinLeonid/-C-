using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les3Exercise1
{
    struct Complex
    {
        private double re;
        private double im;

        public double Re
        {
            get { return re; }
            set { re = value; }
        }
        public double Im
        {
            get { return im; }
            set { im = value; }
        }

        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }
        public static Complex Sum(Complex x, Complex y)
        {
            //Complex res;

            //res.im = x.im + y.im;
            //res.re = x.re + y.re;

            return new Complex(
                x.re + y.re, 
                x.im + y.im);
        }
        public static Complex Subtraction(Complex x, Complex y)
        {
            return new Complex(
                x.re - y.re,
                x.im - y.im);
        }
        public static Complex Multi(Complex x, Complex y)
        {
            return new Complex(
                x.re * y.re - x.im * y.im,
                x.im * y.re + x.re * y.im);
        }
        public override string ToString()
        {
            if (im == 0) return $"{re}";
            else if (re == 0) return $"{im}i";
            else return (im < 0) ? $"{re} - {-im}i" : $"{re} + {im}i";
        }

    }
}
