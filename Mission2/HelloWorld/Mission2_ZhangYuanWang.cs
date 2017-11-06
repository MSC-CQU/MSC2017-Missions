using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexCalculator
{
    public class Complex
    {
        public double real;
        public double imaginary;
        public Complex(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        public static Complex operator +(Complex c1, Complex c2)//复数加法重载
        {
            return new Complex(c1.real + c2.real, c1.imaginary + c2.imaginary);
        }
        public static Complex operator -(Complex c1, Complex c2)//复数减法重载
        {
            return new Complex(c1.real - c2.real, c1.imaginary + c2.imaginary);
        }
        public static Complex operator *(Complex c1, Complex c2)//复数乘法重载
        {
            return new Complex(c1.real * c2.real - c1.imaginary * c2.imaginary, c1.real * c2.imaginary + c1.imaginary * c2.real);
        }
        public static Complex operator /(Complex c1, Complex c2)//复数除法重载
        {
            if (c2.real == 0 && c2.imaginary == 0)
            {
                Console.Write("Error!!");//除数为0时报错
            }
            double real = (c1.real * c2.real + c1.imaginary * c2.imaginary) / (c2.real * c2.real + c2.imaginary * c2.imaginary);
            double imaginary = (c2.real * c1.imaginary - c1.real * c2.imaginary) / (c2.real * c2.real + c2.imaginary * c2.imaginary);
            return new Complex(real, imaginary);
        }
        public static Complex operator ^(Complex c1, int n)//复数的整数次幂
        {
            Complex temp=c1;
            for (int i = 0; i < n - 1; i++)
            {
                temp *= c1;
            }
            return temp;
        }
        public static Complex operator *(double num, Complex c1)//复数的数乘
        {
            double real = num * c1.real;//(a + bi) * (c + di) = (ac+bd) + (ad+bc)i
            double imaginary = num * c1.imaginary;
            Complex temp = new Complex(real, imaginary);
            return temp;
        }
        public static Complex operator *(Complex c1, double num)//复数的数乘
        {
            double real = c1.real * num;//(a + bi) * (c + di) = (ac+bd) + (ad+bc)i
            double imaginary = c1.imaginary * num;
            Complex temp = new Complex(real, imaginary);
            return temp;
        }

        public void Show()//输出
        {
            if (real != 0)
            {
                if (imaginary > 0)
                {
                    if (this.imaginary == 1)
                    {
                        Console.WriteLine($"{Math.Round(this.real, 5)}+i");
                    }
                    else
                    {
                        Console.WriteLine($"{Math.Round(this.real, 5)}+{Math.Round(this.imaginary, 5)}i");
                    }
                }
                else if (imaginary == 0)
                {
                    Console.WriteLine($"{Math.Round(this.real, 5)}");
                }
                else
                {
                    if (this.imaginary == -1)
                    {
                        Console.WriteLine($"{Math.Round(this.real, 5)}-i");
                    }
                    else
                    {
                        Console.WriteLine($"{Math.Round(this.real, 5)}{Math.Round(this.imaginary, 5)}i");
                    }

                }
            }
            else
            {
                if (this.imaginary == 1)
                {
                    Console.WriteLine($"i");
                }
                else if (this.imaginary == 0)
                {
                    Console.WriteLine($"0");
                }
                else if (this.imaginary == -1)
                {
                    Console.WriteLine($"-i");
                }
                else
                {
                    Console.WriteLine($"{Math.Round(this.imaginary, 5)}i");
                }
            }
        }
    }
}