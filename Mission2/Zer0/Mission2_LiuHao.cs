using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Complex
    {
        public double Relnumber;
        public double Imanumber;

        public Complex(double Relnumber) : this(Relnumber, 0)
        { }//用于实数乘方


        public Complex(double conv_Rnumber, double conv_Inumber)
        {
            this.Relnumber = conv_Rnumber;
            this.Imanumber = conv_Inumber;
        }



        public static Complex operator +(Complex num1, Complex num2)
        {
            return new Complex(num1.Relnumber + num2.Relnumber, num1.Imanumber + num2.Imanumber);
        }//sum
        public static Complex operator -(Complex num1, Complex num2)
        {
            return new Complex(num1.Relnumber - num2.Relnumber, num1.Imanumber - num2.Imanumber);
        }//sub
        public static Complex operator *(Complex num1, Complex num2)
        {
            return new Complex(num1.Relnumber + num2.Relnumber - num1.Imanumber - num2.Imanumber, num1.Imanumber * num2.Relnumber + num2.Imanumber * num1.Relnumber);
        }//mul
        public static Complex operator /(Complex num1, Complex num2)
        {
            if (num2.Relnumber == 0 && num2.Imanumber == 0)
            {
                Console.WriteLine("i can't do it");
                Complex None = null;
                return None;
            }
            else
            {
                return new Complex((num1.Relnumber * num2.Relnumber + num1.Imanumber * num2.Imanumber) / (num1.Relnumber * num1.Relnumber + num1.Imanumber * num1.Imanumber),
                    (num1.Relnumber * num2.Imanumber - num2.Relnumber * num1.Imanumber) / (num1.Relnumber * num1.Relnumber + num1.Imanumber * num1.Imanumber));
            }
        }//div

        /*public static Complex Mypow(Complex numi, double pownumber)
        {
            if (numi.Relnumber == 0 && numi.Imanumber == 0)
            {
                Console.WriteLine("i can't do it");
                Complex None = null;
                return None;
            }
            else
            {
                double a=1.0;
                double b=1.0;
                for (int i = 0; i < pownumber; i++)
                {
                    a = a * (numi.Relnumber * numi.Relnumber - numi.Imanumber + numi.Imanumber);

                    b = b * (numi.Relnumber * numi.Imanumber + numi.Imanumber * numi.Relnumber);
                    
                }

                return new Complex(a, b);
            }//复数的数乘历经九九八十一难，最终还是失败，只得将最后一次拿出来丢人现眼...(其实吧也不丢人，假装惭愧一下)*/
        public static Complex Mypow(Complex numi, int pownumber)
        {
            Complex j = new Complex(1, 0);

            if (pownumber >= 0)
            {
                for (int i = 0; i < pownumber; i++)
                {
                    j *= numi;
                }
            }
            if (pownumber < 0)
            {
                for (int i = 0; i > pownumber; i--)
                {
                    j /= numi;
                }
            }
            return j;
        }


    }
    class Program
    {

        static void Main(string[] args)
        {
            //                      以下为测试用
            double a, b, c, d, realnumber;
            ; int n;
            Console.Write("Input a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input c:");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input d:");
            d = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input realnumber and pownumber,I can't deal with a complex QAQ,实数和幂之间用空格:");
            realnumber = Convert.ToDouble(Console.Read());
            n = Convert.ToInt16(Console.ReadLine());//n为(a+bi)^n中的n


            Complex x1 = new Complex(a, b);
            Complex x2 = new Complex(c, d);
            Complex x3 = new Complex(realnumber, 0);

            Complex sum = x1 + x2;
            Complex sub = x1 - x2;
            Complex div = x1 / x2;
            Complex mul = x1 * x2;
            Complex mi = Complex.Mypow(x3, n);

            Console.Write("the sum is:");
            Console.WriteLine("({0})+({1}i)", sum.Relnumber, sum.Imanumber);


            Console.Write("the sub is:");
            Console.WriteLine("({0})+({1}i)", sub.Relnumber, sub.Imanumber);

            Console.Write("the mul is:");
            Console.WriteLine("({0})+({1}i)", mul.Relnumber, mul.Imanumber);

            Console.Write("the sum is:");
            Console.WriteLine("({0})+({1}i)", div.Relnumber, div.Imanumber);

            Console.WriteLine("the {0}'s {1}pow is:{2}", realnumber, n, mi);

            Console.ReadKey();
        }
    }


}
