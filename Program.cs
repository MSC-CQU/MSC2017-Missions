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

            double cd = c2.real * c2.real + c2.imaginary * c2.imaginary;

            return new Complex((c1.real * c2.real + c1.imaginary * c2.imaginary) / cd, (c1.imaginary * c2.real - c1.real * c2.imaginary) / cd);

        }
       



        public override string ToString()

        {

            return (String.Format("{0} + {1}i", real, imaginary));

        }

    }

    class TestComplex

    {

        static void Main()

        {
            Console.WriteLine("please enter a real number:");
            int a =  Console.Read();
            Console.WriteLine("please enter a imaginary number:");
            int b = Console.Read();
            Console.WriteLine("please enter a real number:");
            int c = Console.Read();
            Console.WriteLine("please enter a imaginary number:");
            int d = Console.Read();

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

            Console.WriteLine("please enter a real number:");
            int g = Console.Read();
            Console.WriteLine("please enter a imaginary number:");
            int e = Console.Read();

            Console.WriteLine("please enter a  number as the power:");
            int f = Console.Read();

            Complex num3 = new Complex(g, e);
            
            for (int i = 1; i <= f;i++)
            {
                Complex power = num3 * num3;
                
            }
            

            Console.WriteLine("乘方是: {0}", power);
        }

    }
}
