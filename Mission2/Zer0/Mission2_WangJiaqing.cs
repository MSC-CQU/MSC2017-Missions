using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miscrosoft_wjq_homework
{
    class Complex

    {

        public double real;
        public double imaginary;
        public Complex() : this(0, 0) { }
        public Complex(double real) : this(real, 0) { }
        public Complex(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.real + c2.real, c1.imaginary + c2.imaginary);
        }
        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.real - c2.real, c1.imaginary - c2.imaginary);
        }
        public static Complex operator *(Complex c1, Complex c2)
        {
            return new Complex(c1.real * c2.real - c1.imaginary * c2.imaginary, c1.real * c2.imaginary + c1.imaginary * c2.real);
        }
        public static Complex operator /(Complex c1, Complex c2)
        {
            if (c2.real == 0 && c2.imaginary == 0)
                throw new Exception("Wrong!");
            double cd = c2.real * c2.real + c2.imaginary * c2.imaginary;
            return new Complex((c1.real * c2.real + c1.imaginary * c2.imaginary) / cd, (c1.imaginary * c2.real - c1.real * c2.imaginary) / cd);
        }
        public static Complex Rpow(Complex a, double n)
        {
            if (n == 0)
            {
                if (a.real == 0 && a.imaginary == 0)
                {
                    throw new Exception("Wrong!");
                }
                return new Complex(1, 0);
            }
            double x = Math.Pow(a.real * a.real + a.imaginary * a.imaginary, n / 2);
            double y = Math.Atan(a.imaginary / a.real);
            double z1 = Math.Cos(n * y);
            double z2 = Math.Sin(n * y);
            return new Complex(x * z1, x * z2);
        }
        public static Complex Npow(Complex a, int n)
        {
            if (n == 0)
            {
                if (a.real == 0 && a.imaginary == 0)
                {
                    throw new Exception("Wrong!");
                }
                return new Complex(1, 0);
            }
            if (n > 0)
            {
                Complex r = new Complex(1, 0);
                for (int i = 0; i < n; i++)
                {
                    r = r * a;
                }
                return r;
            }
            else
            {
                return new Complex(1, 0) / Npow(a, -n);
            }
        }
        public override string ToString()
        {
            if (real != 0)
            {
                if (imaginary > 0)
                {
                    if (imaginary == 1)
                        return (String.Format("{0}+i", real));
                    else
                        return (String.Format("{0}+{1}i", real, imaginary));
                }
                if (imaginary == 0)
                    return (String.Format("{0}", real));
                else
                {
                    if (imaginary == -1)
                        return (String.Format("{0}-i", real));
                    else
                        return (String.Format("{0}{1}i", real, imaginary));
                }
            }
            else
            {
                if (imaginary > 0)
                {
                    if (imaginary == 1)
                        return (String.Format("i"));
                    else
                        return (String.Format("{0}i", imaginary));
                }
                if (imaginary == 0)
                    return (String.Format("0"));
                else
                {
                    if (imaginary == -1)
                        return (String.Format("-i"));
                    else
                        return (String.Format("{0}i", imaginary));
                }
            }
        }

    }
    class TestComplex
    {
        static void Main()
        {
            double a, b, c, d, n, e, f;
            Console.Write("Input a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input c:");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input d:");
            d = Convert.ToDouble(Console.ReadLine());
            Complex num1 = new Complex(a, b);
            Complex num2 = new Complex(c, d);
            Complex sum = num1 + num2;
            Complex sub = num1 - num2;
            Complex multiplication = num1 * num2;
            Complex division = num1 / num2;
            Console.WriteLine("第一个复数:  {0}", num1);
            Console.WriteLine("第二个复数: {0}", num2);
            Console.WriteLine("复数和: {0}", sum);
            Console.WriteLine("复数差: {0}", sub);
            Console.WriteLine("复数积: {0}", multiplication);
            Console.WriteLine("复数商: {0}", division);
            Console.Write("Input e:");
            e = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input f:");
            f = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input n:");
            n = Convert.ToDouble(Console.ReadLine());
            Complex num3 = new Complex(e, f);
            Complex power = Complex.Rpow(num3, n);
            Console.WriteLine("复数乘方: {0}", power);
        }

    }
}
