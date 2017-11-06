using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstAPP
{
    class Complex
    {
        private double _real;
        private double _image;
        private double _modulus;
        private double _argument;


        public double Real { get => _real; set => _real = value; }
        public double Image { get => _image; set => _image = value; }
        public double Mod { get => _modulus; set => _modulus = value; }
        public double Arg { get => _argument; set => _argument = value; }
        //构造方法
        public Complex() { }

        public Complex(double re, double im)
        {
            Real = re;
            Image = im;
            Mod = Math.Sqrt(re * re + im * im);
            Arg = Math.Acos(re / Mod);
        }
        //展示复数的值
        public void Showvalue()
        {
            if (Image == 0)
                Console.WriteLine(Real);
            else if (Real == 0)
                Console.WriteLine("{0}i", Image);
            else
                Console.WriteLine("{0}+{1}i", Real, Image);
        }
        //加法运算符重载
        public static Complex operator +(Complex complex1, Complex complex2)
        {
            double r = complex1.Real + complex2.Real;
            double i = complex1.Image + complex2.Image;
            Complex complex3 = new Complex(r, i);
            return complex3;
        }
        //减法运算符重载
        public static Complex operator -(Complex complex1, Complex complex2)
        {
            double r = complex1.Real - complex2.Real;
            double i = complex1.Image - complex2.Image;
            Complex complex3 = new Complex(r, i);
            return complex3;
        }
        //乘法运算符重载
        public static Complex operator *(Complex complex1, Complex complex2)
        {
            double r = complex1.Real * complex2.Real - complex1.Image * complex2.Image;
            double i = complex1.Real * complex2.Image + complex2.Real * complex1.Image;
            Complex complex3 = new Complex(r, i);
            return complex3;
        }
        //数乘复数
        public static Complex operator *(double m, Complex complex)
        {
            double r = complex.Real * m;
            double i = complex.Image * m;
            return new Complex(r, i);

        }
        public static Complex operator *(Complex complex, double m)
        {
            double r = complex.Real * m;
            double i = complex.Image * m;
            return new Complex(r, i);

        }
        //除法运算符重载
        public static Complex operator /(Complex c1, Complex c2)
        {
            double d = c2.Real * c2.Real + c2.Image * c2.Image;
            double re = (c1.Real * c2.Real + c1.Image * c2.Image) / d;
            double im = (c2.Real * c1.Image - c1.Real * c2.Image) / d;
            return new Complex(re, im);
        }
        //复数的整数次幂
        public static Complex Pow(Complex c, int n)
        {
            double Mod = Math.Pow(c.Mod, n);
            double Arg = n * c.Arg;
            double re = Mod * Math.Cos(Arg);
            double im = Mod * Math.Sin(Arg);
            return new Complex(re, im);
        }
    }
}
