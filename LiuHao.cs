using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sir_Hao_Liu
{
    class Complex
    {
        public double Relnumber;
        public double Imanumber;



        public Complex(double conv_Rnumber, double conv_Inumber)
        {
            this.Relnumber = conv_Rnumber;
            this.Imanumber = conv_Inumber;
        }



        public static Complex operator + (Complex num1, Complex num2)
        {
            return new Complex(num1.Relnumber + num2.Relnumber, num1.Imanumber + num2.Imanumber);
        }//sum
        public static Complex operator - (Complex num1, Complex num2)
        {
            return new Complex(num1.Relnumber - num2.Relnumber, num1.Imanumber - num2.Imanumber);
        }//sub
        public static Complex operator * (Complex num1, Complex num2)
        {
            return new Complex(num1.Relnumber + num2.Relnumber - num1.Imanumber - num2.Imanumber, num1.Imanumber * num2.Relnumber + num2.Imanumber * num1.Relnumber);
        }//mul
        public static Complex operator / (Complex num1, Complex num2)
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

        public static Complex Mypow (Complex numi, double pownumber)
        {
            if (numi.Relnumber == 0 && numi.Imanumber == 0)
            {
                Console.WriteLine("i can't do it");
                Complex None = null;
                return None;
            }
            else
            {
                double a = Math.Pow(numi.Relnumber * numi.Relnumber + numi.Imanumber * numi.Imanumber, pownumber / 2);
                double b = Math.Asin(numi.Imanumber / Math.Sqrt(numi.Relnumber * numi.Relnumber + numi.Imanumber * numi.Imanumber));
                return new Complex(a * Math.Sin(pownumber * b), a * Math.Cos(pownumber * b));
            }
        }//复数的数乘




    }
}
