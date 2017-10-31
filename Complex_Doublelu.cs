using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    public class Complex
    {
        private double real; //实部
        private double ima;  //虚部

        public double Real { get => real; set => real = value; }
        public double Ima { get => ima; set => ima = value; }

        public Complex(double real, double ima)
        {
            this.real = real;
            this.ima = ima;
        }

        ///重载加法 

        public static Complex operator +(Complex fir, Complex sec)
        {
            return new Complex(fir.real + sec.real, fir.ima + sec.ima);
        }

        ///重载减法

        public static Complex operator -(Complex fir, Complex sec)
        {
            return new Complex(fir.real - sec.real, fir.ima - sec.ima);
        }

        ///重载乘法

        public static Complex operator *(Complex fir, Complex sec)
        {
            return new Complex(fir.real * sec.real - fir.ima * sec.ima, fir.real * sec.ima + fir.ima * sec.real);
        }

        ///重载除法

        public static Complex operator /(Complex fir, Complex sec)
        {
            double numerator = (fir.real * sec.real + fir.ima * sec.ima) / (sec.real * sec.real + sec.ima * sec.ima);
            double denominator = (sec.real * fir.ima - fir.real * sec.ima) / (sec.real * sec.real + sec.ima * sec.ima);

            if (denominator == 0)
                Console.WriteLine("Error!");
            else
                return new Complex(numerator, denominator);
        }

        ///整数乘方

        public void PowOn(Complex InputNum, int times)
        {
            int i;
            Complex OutputNum = ImputNum ;
            for (i = 1; i < times; i++)
                OutputNum = OutputNum * InputNum;

            return OutputNum;
        }
        

    }
}
