using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumber
{
    public class ComplexNumber
    {
        public double real_part;
        public double imaginary_part;   //构建复数的实部和虚部

        public ComplexNumber()
        {
            real_part = 0;
            imaginary_part = 0;
        }
        public ComplexNumber(double real,double imaginary)
        {
            real_part = real;
            imaginary_part = imaginary;    //初始化一个复数
        }
        public ComplexNumber Add (ComplexNumber num1)
        {
            double x;
            double y;
            x = num1.real_part + real_part;
            y = num1.imaginary_part + imaginary_part;
            return new ComplexNumber(x, y);     //加法
        }
        public ComplexNumber Substract(ComplexNumber num1)
        {
            double x;
            double y;
            x = real_part - num1.real_part;
            y = imaginary_part - num1.imaginary_part;
            return new ComplexNumber(x, y);    //减法
        }
        public ComplexNumber Multiply(ComplexNumber num1)
        {
            double x;
            double y;
            x = real_part * num1.real_part - imaginary_part * num1.imaginary_part;
            y = real_part * num1.imaginary_part + imaginary_part * num1.real_part;
            return new ComplexNumber(x, y);   //乘法
        }
        public ComplexNumber Divide(ComplexNumber num1)
        {
            double x;
            double y;
            x = (num1.real_part * real_part + num1.imaginary_part * imaginary_part) / (num1.imaginary_part * num1.imaginary_part + num1.real_part * num1.real_part);
            y=(imaginary_part*num1.real_part-real_part*num1.imaginary_part)/ (num1.imaginary_part * num1.imaginary_part + num1.real_part * num1.real_part);
            return new ComplexNumber(x, y);     //除法
        }
        public ComplexNumber PowerOn(int power)
        {
            double x=real_part;
            double y=imaginary_part;
            ComplexNumber temp = new ComplexNumber(x, y);
            ComplexNumber num = new ComplexNumber(x, y);
            for (int i=0;i<power;++i)
            {
              num=  temp.Multiply(temp);
            }
            return num;
        }
           public  static  ComplexNumber operator + (ComplexNumber num1,ComplexNumber num2)
        {
            return num1.Add(num2);
        }
        public  static ComplexNumber operator - (ComplexNumber num1,ComplexNumber num2)
        {
            return num1.Substract(num2);
        }
        public static ComplexNumber operator * (ComplexNumber num1, ComplexNumber num2)
        {
            return num1.Multiply(num2);
        }
        public static ComplexNumber operator / (ComplexNumber num1,ComplexNumber num2)
        {
            return num1.Divide(num2);
        }
        public override string ToString()
        {
            if (real_part == 0 && imaginary_part == 0)
            {
                return string.Format("{0}", 0);
            }
            if (real_part == 0 && (imaginary_part != 1 && imaginary_part != -1))
            {
                return string.Format("{0}i", imaginary_part);
            }
            if (imaginary_part == 0)
            {
                return string.Format("{0}", real_part);
            }
            if (imaginary_part == 1&&real_part==0)
            {
                return string.Format("i");
            } 
           if (imaginary_part == -1&&real_part==0)
            {
                return string.Format("-i");
            } 
           if(imaginary_part==1&&real_part!=0)
            {
                return string.Format("{0}+i", real_part);
            }
           if(imaginary_part==-1&&real_part!=0)
            {
                return string.Format("{0}-i", real_part);
            }
            if (imaginary_part < 0)
            {
                return string.Format("{0}-{1}i", real_part, -imaginary_part);
            }
            return string.Format("{0}+{1}i", real_part, imaginary_part);
        }
    }//
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber cm1 = new ComplexNumber(1, 2);
            ComplexNumber cm2 = new ComplexNumber(2, 3);
            ComplexNumber cm3 = new ComplexNumber();

            cm3 = cm1 + cm2;
           string cmstring= cm3.ToString();
             Console.Write("1+2i+2+3i=");
             Console.WriteLine(cmstring);
           
            cm3 = cm1 - cm2;
            cmstring = cm3.ToString();
            Console.Write("1+2i-2+3i=");
            Console.WriteLine(cmstring);

            cm3 = cm1 * cm2;
            cmstring = cm3.ToString();
            Console.Write("(1+2i)*(2+3i)=");
            Console.WriteLine(cmstring);
        }
    }
}
