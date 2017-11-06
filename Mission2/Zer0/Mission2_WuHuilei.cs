using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{

    public class ComplexNumber
    {
        private double real;
        private double imagine;

        #region 类型转换

        /// <summary>
        /// 由复数到浮点的显式类型转换。
        /// </summary>
        /// <param name="value"></param>
        /// <returns>模长</returns>
        public static explicit operator double(ComplexNumber value)
        {
            return value.Length;
        }

        /// <summary>
        /// 由浮点到复数的隐式类型转换。
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static implicit operator ComplexNumber(double value)
        {
            return new ComplexNumber(value);
        }

        #endregion

        #region 复数构造

        /// <summary>
        /// 构造复数域零元。
        /// </summary>
        public ComplexNumber() : this(0, 0) { }

        /// <summary>
        /// 由实部构造一个复数。
        /// </summary>
        public ComplexNumber(double real) : this(real, 0) { }

        /// <summary>
        /// 由实部和虚部构造一个复数。
        /// </summary>
        /// <param name="real">实部</param>
        /// <param name="imagine">虚部</param>
        public ComplexNumber(double real, double imagine)
        {
            this.real = real;
            this.imagine = imagine;
        }

        #endregion

        #region 常用属性

        /// <summary>
        /// 此复数的实部。
        /// </summary>
        public double Re
        {
            get { return real; }
            set { real = value; }
        }

        /// <summary>
        /// 此复数的虚部。
        /// </summary>
        public double Im
        {
            get { return imagine; }
            set { imagine = value; }
        }

        /// <summary>
        /// 此复数的模长。
        /// </summary>
        /// <returns></returns>
        public double Length
        {
            get { return Math.Sqrt(real * real + imagine * imagine); }
        }

        /// <summary>
        /// 此复数的辐角主值。
        /// </summary>
        /// <returns></returns>
        public double Arg
        {
            get
            {
                if (real == 0 && imagine == 0)
                {
                    throw new DivideByZeroException("复数为0时不能取辐角。");
                }
                else
                {
                    return Math.Atan2(imagine, real);
                }
            }
        }

        #endregion

        #region 运算符重载

        /// <summary>
        /// 复数加法。
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.real + c2.real, c1.imagine + c2.imagine);
        }

        /// <summary>
        /// 复数减法。
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.real - c2.real, c1.imagine - c2.imagine);
        }

        /// <summary>
        /// 复数乘法。
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.real * c2.real - c1.imagine * c2.imagine, c1.imagine * c2.real + c1.real * c2.imagine);
        }

        /// <summary>
        /// 复数除法。
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static ComplexNumber operator /(ComplexNumber c1, ComplexNumber c2)
        {
            ComplexNumber ret = new ComplexNumber();
            double a = c1.real;
            double b = c1.imagine;
            double c = c2.real;
            double d = c2.imagine;
            ret.real = (a * c + b * d) / (c * c + d * d);
            ret.imagine = (b * c - a * d) / (c * c + d * d);
            return ret;
        }

        /// <summary>
        /// 复数乘方。
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static ComplexNumber operator ^(ComplexNumber c1, ComplexNumber c2)
        {
            return Exp(Ln(c1) * c2);
        }

        /// <summary>
        /// 复数的实数乘方。
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static ComplexNumber operator ^(ComplexNumber c1, double c2)
        {
            double arg = c1.Arg * c2;
            double mod = Math.Pow(c1.Length, c2);
            return mod * Exp(0, arg);
        }

        /// <summary>
        /// 复数共轭。
        /// </summary>
        /// <param name="c1"></param>
        /// <returns></returns>
        public static ComplexNumber operator !(ComplexNumber c1)
        {
            return c1.Conjugate();
        }

        #endregion

        #region 类功能添加与重载

        /// <summary>
        /// 获得共轭复数。
        /// </summary>
        /// <returns></returns>
        public ComplexNumber Conjugate()
        {
            return new ComplexNumber(real, -imagine);
        }

        /// <summary>
        /// 获得共轭复数。
        /// </summary>
        /// <returns></returns>
        public static ComplexNumber Conjugate(ComplexNumber a)
        {
            return a.Conjugate();
        }

        /// <summary>
        /// 对复数取自然对数。
        /// </summary>
        /// <returns></returns>
        public static ComplexNumber Ln(ComplexNumber c1)
        {
            return new ComplexNumber(Math.Log(c1.Length), c1.Arg);
        }

        /// <summary>
        /// 对复数取自然指数。
        /// </summary>
        /// <returns></returns>
        public static ComplexNumber Exp(ComplexNumber c1)
        {
            return Exp(c1.real, c1.imagine);
        }

        /// <summary>
        /// 对复数取自然指数。
        /// </summary>
        /// <returns></returns>
        public static ComplexNumber Exp(double real, double imagine)
        {
            double r = Math.Exp(real);
            double sa = Math.Sin(imagine);
            double ca = Math.Cos(imagine);
            return new ComplexNumber(r * ca, r * sa);
        }

        /// <summary>
        /// 将复数转化为可打印的一般形式。
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (real == 0 && imagine == 0)
                return "0";
            else if (real == 0)
                return string.Format("{0}i", imagine);
            else if (imagine == 0)
                return string.Format("{0}", real);
            else if (imagine > 0)
                return string.Format("{0}+{1}i", real, imagine);
            else
                return string.Format("{0}{1}i", real, imagine);
        }

        /// <summary>
        /// 将复数转化为可打印的三角形式。
        /// </summary>
        /// <returns></returns>
        public string ToArcString()
        {
            return string.Format("{0} *e^i ({1})", Length, Arg);
        }

        #endregion

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入c1的实部：");
            double real = double.Parse(Console.ReadLine());
            Console.Write("请输入c1的虚部：");
            double imag = double.Parse(Console.ReadLine());
            ComplexNumber c1 = new ComplexNumber(real, imag);
            Console.WriteLine("c1={0}={1}", c1.ToString(), c1.ToArcString());

            Console.Write("请输入c2的实部：");
            real = double.Parse(Console.ReadLine());
            Console.Write("请输入c2的虚部：");
            imag = double.Parse(Console.ReadLine());
            ComplexNumber c2 = new ComplexNumber(real, imag);
            Console.WriteLine("c2={0}={1}", c2.ToString(), c2.ToArcString());

            Console.WriteLine("c1+c2=" + (c1 + c2).ToString());
            Console.WriteLine("c1-c2=" + (c1 - c2).ToString());
            Console.WriteLine("c1*c2=" + (c1 * c2).ToString());
            Console.WriteLine("c1/c2=" + (c1 / c2).ToString());
            Console.WriteLine("c1^c2=" + (c1 ^ c2).ToString());

            Console.Write("请按任意键继续. . . ");
            Console.ReadLine();
        }
    }
}
