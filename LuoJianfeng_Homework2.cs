using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Complex//复数类
    {
        private double real;//实部
        private double imaginary;//虚部
        public Complex(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }//构造函数
        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.real + b.real, a.imaginary + b.imaginary);
        }//加法
        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.real - b.real, a.imaginary - b.imaginary);
        }//减法
        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex(a.real * b.real - a.imaginary * b.imaginary, a.imaginary * b.real + a.real * b.imaginary);
        }//乘法
        public static Complex operator /(Complex a, Complex b)
        {
            return new Complex((a.real * b.real + a.imaginary * b.imaginary) / (Math.Pow(b.real, 2) + Math.Pow(b.imaginary, 2)), (a.imaginary * b.real - a.real * b.imaginary) / (Math.Pow(b.real, 2) + Math.Pow(b.imaginary, 2)));
        }//除法
        public static Complex Cpow(Complex a, double n)
        {
            double x = Math.Pow(a.real * a.real + a.imaginary * a.imaginary, n / 2);
            double y = Math.Atan(a.imaginary / a.real);
            double z1 = Math.Cos(n * y);
            double z2 = Math.Sin(n * y);
            return new Complex(x * z1, x * z2);
        }//实数幂
        public static void Output(Complex a)
        {
            if(a.imaginary>=0)
                Console.Write(a.real+"+" + a.imaginary + "*i");
            else
                Console.Write(a.real+""+a.imaginary + "*i");
        }//输出
    }
    class Program
    {

        static void Main(string[] args)
        {
            //以下为测试用
            double a, b, c, d,n;
            Console.Write("Input a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input c:");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input d:");
            d = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input n:");
            n = Convert.ToDouble(Console.ReadLine());
            Complex x1 = new Complex(a, b);
            Complex x2 = new Complex(c, d);
            Complex sum = x1 + x2;
            Complex cha = x1 - x2;
            Complex shang = x1 / x2;
            Complex ji = x1 * x2;
            Complex mi = Complex.Cpow(x1,n);
            Complex.Output(sum);
            Console.WriteLine();
            Complex.Output(cha);
            Console.WriteLine();
            Complex.Output(ji);
            Console.WriteLine(); 
            Complex.Output(shang);
            Console.WriteLine();
            Complex.Output(mi);
            Console.ReadKey();
        }
    }
}
