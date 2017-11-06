//CQU@苏晨林
//MSC第一次培训作业修改版
//我们组经过了长时间的讨论后，完成这次任务
//是我的第一个比较完善的C#程序，可喜可贺
//只算不完善的程序，已经被人道毁灭了，可喜可贺
//Start Time：11/05/2017 00:49
using System;//于是经过讨论后，就用了这一个



namespace SMiku_Complex_counter
{
    public class Complex_counter
    {
        //定义实部与虚部
        public double Real { get; set; } = 0.0;
        public double Imaginary { get; set; } = 0.0;

        //加法重定义
        public static Complex_counter operator +(Complex lhs, Complex rhs)//当两个数均为复数时
        {
            return new Complex_counter(lhs.Real + rhs.Real, lhs.Imaginary + rhs.Imaginary);
        }
        public static Complex_counter operator +(double lhs, Complex rhs)//当第一个实数第二个复数
        {
            return new Complex_counter(lhs + rhs.Real, rhs.Real);
        }
        public static Complex_counter operator +(Complex lhs, double rhs)//第一个复数第一个实数
        {
            return rhs + lhs;
        }

        //减法重定义
        public static Complex operator -(Complex lhs, Complex rhs)//复复
        {
            return new Complex(lhs.Real - rhs.Real, lhs.Imaginary - rhs.Imaginary);
        }
        public static Complex operator -(Complex lhs, double rhs)//复实
        {
            return new Complex(lhs.Real - rhs, lhs.Real);
        }
        public static Complex operator -(double lhs, Complex rhs)//实复
        {
            return new Complex(lhs - rhs.Real, -rhs.Real);
        }

        //乘法重定义
        public static Complex operator *(Complex lhs, Complex rhs)//复复
        {
            double real2 = lhs.Real * rhs.Real - lhs.Imaginary * rhs.Imaginary;
            double imaginary2 = lhs.Real * rhs.Imaginary + lhs.Imaginary * rhs.Real;
            return new Complex(real2, imaginary2);
        }
        public static Complex operator *(double lhs, Complex rhs)//实复
        {
            return new Complex(rhs.Real * lhs, rhs.Imaginary * lhs);
        }
        public static Complex operator *(Complex lhs, double rhs)//复实
        {
            return rhs * lhs;
        }

        //除法重定义
        public static Complex operator /(Complex lhs, double rhs)//当第一个数为复数，第二个数为零
        {
            if (rhs == 0)
            {
                throw new DivideByZeroException();
            }
            return new Complex(lhs.Real / rhs, lhs.Imaginary / rhs);
        }
        public static Complex operator /(Complex lhs, Complex rhs)//复复
        {
            if (rhs.Real == 0 && rhs.Imaginary == 0)//当其中一个复数的的实部和虚部都为零时错误
            {
                throw new DivideByZeroException();
            }
            if (rhs.Imaginary == 0)//当第二个复数的虚部为零时
            {
                return new Complex(lhs.Real / rhs.Real, lhs.Imaginary / rhs.Real);
            }
            return (lhs * rhs.Conjunction()) / (rhs.Real * rhs.Real + rhs.Imaginary * rhs.Imaginary);// 调用共轭复数
        }
        public static Complex operator /(double lhs, Complex rhs)
        {
            return new Complex(lhs, 0) / rhs;
        }

        //定义共轭复数
        public Complex Conjunction()
        {
            return new Complex(Real, -Imaginary);
        }

        // 整数乘方： 反复自乘
        public static Complex Power(Complex x, int y)
        {
            Complex temp = x;
            if (y == 0)
            {
                return new Complex(1, 0);
            }
            else if (y > 0)
            {
                for (int i = 1; i < y; i++)
                {
                    temp *= x;
                }
            }
            else
            {
                temp = new Complex(1, 0) / x;
                for (int i = -1; i > y; i--)
                {
                    temp /= x;
                }
            }
            return temp;
        }

        // 默认构造函数
        public Complex_counter() { }

        //构造函数
        public Complex_counter(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        // 重载 ToString() 方法
        public override string ToString()
        {
            string str = "";
            if (Real == 0 && Imaginary == 0)
            {
                return "0";
            }
            if (Real != 0)
            {
                str += String.Format("{0:G}", Real);
            }
            if (Imaginary != 0)
            {
                if (Imaginary < 0)
                {
                    str += "-";
                }
                else
                {
                    if (Real != 0)
                    {
                        str += "+";
                    }
                }
            }
            if (Imaginary != 0)
            {
                str += ((Imaginary == 1) || (Imaginary == -1) ? "i" : String.Format("{0:G}i", Math.Abs(Imaginary)));
            }
            return str;
        }


    }
}
//Complete time: 11/05/2017 01:32
//经过我们组的讨论，我们终于完成了
//虽然复数的实数次方还是没弄出来
//我觉得我应该背锅
//讨论到一半我去接电话了
//后面就都散了
//唉

