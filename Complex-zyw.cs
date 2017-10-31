using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexCalculator
{
    public class Complex
    {
        public float real;
        public float imaginary;
        public Complex(float real, float imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        public static Complex operator +(Complex c1, Complex c2)//加法重载
        {
            return new Complex(c1.real + c2.real, c1.imaginary + c2.imaginary);
        }
        public static Complex operator -(Complex c1, Complex c2)//减法重载
        {
            return new Complex(c1.real - c2.real, c1.imaginary + c2.imaginary);
        }
        public static Complex operator *(Complex c1, Complex c2)//乘法重载
        {
            return new Complex(c1.real * c2.real - c1.imaginary * c2.imaginary, c1.real * c2.imaginary + c1.imaginary * c2.real);
        }
        public static Complex operator /(Complex c1,Complex c2)//除法重载
        {
            if (c2.real == 0 && c2.imaginary == 0)
            {
                Console.Write("Error!!"); 
            }
            float real = (c1.real * c2.real + c1.imaginary * c2.imaginary) / (c2.real * c2.real + c2.imaginary * c2.imaginary);
            float imaginary = (c2.real * c1.imaginary - c1.real * c2.imaginary) / (c2.real * c2.real + c2.imaginary * c2.imaginary);
            return new Complex(real, imaginary);
        }
        public static Complex Power(Complex c1,int n)//复数的整数次幂
        {
            int i;
            double a=0,b=0;
            if(n==0)//任何数的零次方都是1
            {
                return new Complex(1, 0);
            }
            if(n>0)//按二项式展开
            {
                for(i=0;i<=n;i=i+2)
                {
                     a += Math.Pow(c1.real, n - i)*Math.Pow(c1.imaginary,i)*Math.Pow(-1,i/2);

                }
                for(i=1;i<=n;i=i+2)
                {
                     b += Math.Pow(c1.real, n - i) * Math.Pow(c1.imaginary, i) * Math.Pow(-1, i / 2);
                }
                return new Complex((float)a,(float)b);
            }
            if(n<0)//先计算n>0的结果，再取倒数
            {
                int n0 = Math.Abs(n);
                for (i = 0; i <= n; i = i + 2)
                {
                    a = Math.Pow(c1.real, n - i) * Math.Pow(c1.imaginary, i) * Math.Pow(-1, i / 2);

                }
                for (i = 1; i <= n; i = i + 2)
                {
                    b = Math.Pow(c1.real, n - i) * Math.Pow(c1.imaginary, i) * Math.Pow(-1, i / 2);
                }
                return new Complex((float)(a / (a * a + b * b)), (float)(-(b / a * a + b * b)));
            }           
        }

    }
}
