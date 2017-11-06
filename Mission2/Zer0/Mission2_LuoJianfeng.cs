using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Complex
    {
        private double real;//实部
        private double imaginary;//虚部

        public Complex() : this(0, 0) { }

        /// <summary>
        /// 由实部构造
        /// </summary>
        /// <param name="real"></param>
        public Complex(double real) : this(real, 0) { }

        /// <summary>
        /// 由实部和虚部构造
        /// </summary>
        /// <param name="real"></param>
        /// <param name="imaginary"></param>
        public Complex(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        /// <summary>
        /// 实部
        /// </summary>
        public double Real
        {
            get { return real; }
            set { real = value; }
        }

        /// <summary>
        /// 虚部
        /// </summary>
        public double Imaginary
        {
            get { return Imaginary; }
            set { imaginary = value; }
        }

        /// <summary>
        /// //加法：略
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.real + b.real, a.imaginary + b.imaginary);
        }

        /// <summary>
        /// 减法：略
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.real - b.real, a.imaginary - b.imaginary);
        }

        /// <summary>
        /// 乘法：(a+bi)*(c+di)=ac-bd+(bc+ad)i
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex(a.real * b.real - a.imaginary * b.imaginary, a.imaginary * b.real + a.real * b.imaginary);
        }

        /// <summary>
        /// 除法:(a+bi)/(c+di)=(ac+bd)/(c^2+d^2)+(bc-ad)/(c^2+d^2)*i 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Complex operator /(Complex a, Complex b)
        {
            if(b.real==0 && b.imaginary==0)
            {
                throw new Exception("Wrong!");
            }
            return new Complex((a.real * b.real + a.imaginary * b.imaginary) / (Math.Pow(b.real, 2) + Math.Pow(b.imaginary, 2)), (a.imaginary * b.real - a.real * b.imaginary) / (Math.Pow(b.real, 2) + Math.Pow(b.imaginary, 2)));
        }

        /// <summary>
        /// (正确性待讨论)实数次方:(a+bi)^n=(a^2+b^2)^n/2*(cosn*arctanb/a+sinn*arctanb/a*i)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static Complex Rpow(Complex a, double n)
        {
            if(n==0)
            {
                if(a.real==0 && a.imaginary==0)
                {
                    throw new Exception("F**k,it can't be 0!!!");
                }
                return new Complex(1, 0);
            }
            double x = Math.Pow(a.real * a.real + a.imaginary * a.imaginary, n / 2);
            double y = Math.Atan(a.imaginary / a.real);
            double z1 = Math.Cos(n * y);
            double z2 = Math.Sin(n * y);
            return new Complex(x * z1, x * z2);
        }

        /// <summary>
        /// 整数次方
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static Complex Npow(Complex a, int n)
         {
            if (n == 0)
            {
                if (a.real == 0 && a.imaginary == 0)
                {
                    throw new Exception("F**k,it can't be 0!!!");
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
            //指数为负,倒一下
         }

        /// <summary>
        /// 重载ToString打印复数为a+bi形式（避免输出0+bi，a+0i，a+-bi，a+1i，a-1i这些错误格式）
        /// </summary>
        /// <returns></returns>
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
    class Program
    {

        static void Main(string[] args)
        {
            //以下为测试用
            /* double a, b, c, d,n;
             Console.Write("Input a:");
             a = Convert.ToDouble(Console.ReadLine());
             Console.Write("Input b:");
             b = Convert.ToDouble(Console.ReadLine());
             Console.Write("Input c:");
             c = Convert.ToDouble(Console.ReadLine());
             Console.Write("Input d:");
             d = Convert.ToDouble(Console.ReadLine());
             Console.Write("Input n:");
             n = Convert.ToDouble(Console.ReadLine());//n为(a+bi)^n中的n*/
            Complex x1 = new Complex(-2, -3);//new一个a+bi
            Complex x2 = new Complex(0, 0);//new一个c+di
            Console.WriteLine("第一个复数：{0}", x1);
            Console.WriteLine("第二个复数：{0}", x2);
            Complex sum = x1 + x2;
            Complex cha = x1 - x2;
            Complex shang = x1 / x2;
            Complex ji = x1 * x2;
            Complex mi = Complex.Rpow(x1, -3);
            Console.WriteLine("和：{0}", sum);
            Console.WriteLine("差：{0}", cha);
            Console.WriteLine("积：{0}", ji);
            Console.WriteLine("商：{0}", shang);
            Console.WriteLine("-3次方：{0}", mi);
            Console.ReadKey();
        }
    }
}
