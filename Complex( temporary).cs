using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Program
    {
        public class Complex
        {
            private double real;
            private double image;

            /// <summary>
            /// 默认构造函数
            /// </summary>
            public Complex() : this(0, 0)
            {
            }

            /// <summary>
            /// 只有实部的构造函数
            /// </summary>
            public Complex(double real) : this(real, 0)
            {

            }

            /// <summary>
            /// 由实部和虚部构造
            /// </summary>
            /// <param name="real">实部</param>
            /// <param name="image">虚部</param>
            public Complex(double real, double image)
            {
                this.real = real;
                this.image = image;
            }
            public double Real
            {
                get { return real; }
                set { real = value; }
            }

            public double Image
            {
                get { return image; }
                set { image = value; }
            }

            /// <summary>
            /// 重载加法
            /// </summary>
            /// <param name="c1"></param>
            /// <param name="c2"></param>
            /// <returns></returns>
            public static Complex operator +(Complex c1, Complex c2)
            {
                return new Complex(c1.real + c2.real, c1.image + c2.image);
            }


            /// <summary>
            /// 重载减法
            /// </summary>
            /// <param name="c1"></param>
            /// <param name="c2"></param>
            /// <returns></returns>
            public static Complex operator -(Complex c1, Complex c2)
            {
                return new Complex(c1.real - c2.real, c1.image - c2.image);
            }


            /// <summary>
            /// 重载乘法
            /// </summary>
            /// <param name="c1"></param>
            /// <param name="c2"></param>
            /// <returns></returns>
            public static Complex operator *(Complex c1, Complex c2)
            {
                return new Complex(c1.real * c2.real - c1.image * c2.image, c1.image * c2.real + c1.real * c2.image);
            }


            /// <summary>
            /// 重载除法运算符
            /// </summary>
            /// <param name="c1"></param>
            /// <param name="c2"></param>
            /// <returns></returns>
            public static Complex operator /(Complex c1, Complex c2)
            {
                Complex ret = new Complex();
                double a = 0;
                double b = 0;
                double c = 0;
                double d = 0;
                a = c1.real;
                b = c1.image;
                c = c2.real;
                d = c2.image;
                ret.real = (a * c + b * d) / (c * c + d * d);
                ret.image = (b * c - a * d) / (c * c + d * d);
                return ret;

            }

        }
    }
}