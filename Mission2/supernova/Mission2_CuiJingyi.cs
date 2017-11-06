using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**     
 *      Author: 崔静怡
 */
namespace ComplexCalculator
{   
    class Complex
    {
        //实部与虚部
        float real = 0;
        float imaginary = 0;

        //0复数
        private Complex()
        {
        }

        //构造函数
        public Complex(float real,float imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        
        //复数加法
        //实部虚部分别相加
        public static Complex operator +(Complex com1, Complex com2)
        {
            return new Complex(com1.real + com2.real,com1.imaginary + com2.imaginary);
        }

        //复数减法
        //实部虚部分别相减
        public static Complex operator -(Complex com1, Complex com2)
        {
            return new Complex(com1.real - com2.real, com1.imaginary - com2.imaginary);
        }

        //复数乘法
        // （a+bi)(c+di)=ac+bd + (ad+bc)i
        public static Complex operator *(Complex com1, Complex com2)
        {
            float real = com1.real * com2.real + com1.imaginary * com2.imaginary;
            float imaginary = com1.real * com2.imaginary + com1.imaginary * com2.real;
            return new Complex(real,imaginary);
        }

        //复数除法
        public static Complex operator /(Complex com1, Complex com2)
        {
            return (com1* GetConjugateComplex(com2)) /(com2.real*com2.real-com2.imaginary*com2.imaginary);
        }

        //复数的数乘
        // c(a+bi) = ac + bci
        public static Complex operator *(Complex complex,float i)
        {
            return new Complex(complex.real*i,complex.imaginary *i);
        }
        //数乘满足交换律，数乘函数
        public static Complex operator *(float i,Complex complex)
        {
            return complex*i;
        }

        //复数除以常数的运算
        public static Complex operator /(Complex complex,float div)
        {
            return new Complex(complex.real/div, complex.imaginary/div);
        }

        /**
         *      复数乘方（整数）
         *      (a+bi)^n = C(n,k)a^k * b^(n-k) * i^(n-k);
         *      
         */
        public static Complex operator ^(Complex complex, int pow)
        {
            //分类讨论
            if (pow == 0) //指数等于零
            {
                //判断该复数是否等于零，等于零无意义
                if (! (complex.real ==0 & complex.imaginary ==0)) {
                    throw new Exception("0^0 = 0/0 is invaild.");
                }
                //除零以外任何数的零次方等于1，返回值为 1
                return new Complex(1,0);
            } else if (pow > 0) //指数大于零
            {
                //用于储存结果的复数实例
                Complex result =  new Complex();
                //根据二项式展开公式 (a+bi)^n = C(n,k) * a^k * b^(n-k) * i^(n-k) 计算
                for (int k=0;k<=pow;k++)
                {
                   result += CombineNumber(pow,k) * (float)Math.Pow(complex.real,k) * (float)Math.Pow(complex.imaginary, pow -k) * IPow( pow -k);
                }
                return result;
            }
            else //指数小于零
            {
                return new Complex(1, 0) / complex^-pow;
            }
        }

        //共轭复数的计算
        private static Complex GetConjugateComplex(Complex src)
        {
            return new Complex(src.real,-src.imaginary);
        }


        /**  用于计算i^n :
         *   首先根据 i^n 的周期性先化简，后根据数表得出结果
         *   i^(-1) = -i
         *      i^0 = 1
         *      ========
         *      i^1 = i
         *      i^2 = -1
         *      i^3 = -i
         *      i^4 = 1
         *      ========
         *      
         *      对n>0    直接求模
         *      对n=0    返回1
         *      对n<0   令t=-n,  那么t>0,
         *      i^-n = (i^-1)^n = (-i)^n=(-1)^-n * i^-n = （-1）^t * i ^t
         */
        private static Complex IPow(int n)
        {
            if (n<0)
            {
                return (float)Math.Pow(-1,-n)* IPow(-n);
            }else if (n == 0)
            {
                return new Complex(1, 0);
            }
            //取第一周期
            int standlizedN = n % 4;

            //暂存结果的变量
            float real = 0;
            float imaginary = 0;

            switch (standlizedN)
            {
                case 1:imaginary = 1;
                    break;
                case 2:real = -1;
                    break;
                case 3:imaginary = -1;
                    break;
                case 4:real = 1;
                    break;
            }
            return new Complex(real,imaginary);
        }
        
        //组合数计算函数C(n,k)
        //C(n,k)=n!/k!(n-k)!
        private static int CombineNumber(int n,int k)
        {
            int result = 1;
            for (int i = k+1;i<=n;i++)
            {
                result *= i;
            }

            for (int j = 2; j<=n-k; j++)
            {
                result /= j;
            }
            return result;
        }

		
        public override String ToString()
        {
            return "("+real.ToString() + ") + (" + imaginary.ToString() + ") i ";
        }
    }



}
