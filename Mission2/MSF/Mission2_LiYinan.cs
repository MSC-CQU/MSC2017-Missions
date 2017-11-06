using System;

namespace Complex
{
	public class Complex
    {
		public double RealPart { get; set; } = 0.0;
		public double ImagPart { get; set; } = 0.0;
		// 使用属性封装变量

		public static Complex operator + (Complex lhs, Complex rhs)
		{
			// 运算符重载
			return new Complex(lhs.RealPart + rhs.RealPart, lhs.ImagPart + rhs.ImagPart);
		}
		public static Complex operator +(double lhs, Complex rhs)
		{
			// 方法的多个重载
			return new Complex(lhs + rhs.RealPart, rhs.ImagPart);
		}
		public static Complex operator +(Complex lhs, double rhs)
		{
			// 代码重用
			return rhs + lhs;
		}

		// 下同
		public static Complex operator - (Complex lhs, Complex rhs)
		{
			return new Complex(lhs.RealPart - rhs.RealPart, lhs.ImagPart - rhs.ImagPart);
		}
		public static Complex operator -(Complex lhs, double rhs)
		{
			return new Complex(lhs.RealPart - rhs, lhs.RealPart);
		}
		public static Complex operator -(double lhs, Complex rhs)
		{
			return new Complex(lhs - rhs.RealPart, -rhs.RealPart);
		}


		public static Complex operator * (Complex lhs, Complex rhs)
		{
			double real = lhs.RealPart * rhs.RealPart - lhs.ImagPart * rhs.ImagPart;
			double imaginary = lhs.RealPart * rhs.ImagPart + lhs.ImagPart * rhs.RealPart;
			return new Complex(real, imaginary);
		}
		public static Complex operator *(double lhs, Complex rhs)
		{
			return new Complex(rhs.RealPart * lhs, rhs.ImagPart * lhs);
		}
		public static Complex operator *(Complex lhs, double rhs)
		{
			return rhs * lhs;
		}

		public static Complex operator /(Complex lhs, double rhs)
		{
			if(rhs == 0)
			{
				// 考虑 rhs == 0
				throw new DivideByZeroException();
				// 异常
			}
			return new Complex(lhs.RealPart / rhs, lhs.ImagPart / rhs);
		}
		public static Complex operator /(Complex lhs, Complex rhs)
		{
			if(rhs.RealPart == 0 && rhs.ImagPart == 0)
			{
				throw new DivideByZeroException();
				// 考虑 rhs == 0
			}
			if(rhs.ImagPart == 0)
			{
				return new Complex(lhs.RealPart / rhs.RealPart, lhs.ImagPart / rhs.RealPart);
				// 数除
			}
			return (lhs * rhs.Conjunction()) / (rhs.RealPart * rhs.RealPart + rhs.ImagPart * rhs.ImagPart);
			// 调用共轭复数方法，重用
		}
		public static Complex operator /(double lhs, Complex rhs)
		{
			return new Complex(lhs, 0) / rhs;
		}

		public Complex Conjunction()
		{
			return new Complex(RealPart, -ImagPart);
			// 共轭复数
		}
		public static Complex Power(Complex x, int y)
		{
			Complex temp = x;
			if(y == 0)
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
				temp = new Complex(1,0) / x;
				for (int i = -1; i > y; i--)
				{
					temp /= x;
				}
			}
			return temp;
			// 整数乘方： 反复自乘
		}

		public static Complex Power(Complex x, double y)
		{
			// 本人数学非常一般，这里参考了 .NET Core 中的复数乘方实现。
			double chord = Math.Sqrt(x.ImagPart * x.ImagPart + x.RealPart * x.RealPart);
			Double theta = Math.Asin(x.ImagPart / x.RealPart);
			double real = Math.Pow(chord, y) * Math.Cos(y * theta);
			double imag = Math.Pow(chord, y) * Math.Sin(y * theta);
			return new Complex(real, imag);
		}

		public Complex() { }
		// 默认构造函数, 将两个属性设置为 0
		public Complex(double real, double imaginary)
		{
			RealPart = real;
			ImagPart = imaginary;
			// 构造函数
		}

		public override string ToString()
		{
			// 重载 ToString() 方法
			// 考虑： 输出精度，数值为 0，实部或虚部 == 0，虚部 == 1
			string str = "";
			if(RealPart == 0 && ImagPart == 0)
			{
				return "0";
			}
			if(RealPart != 0)
			{
				str += String.Format("{0:G}", RealPart);
			}
			if(ImagPart != 0)
			{
				if(ImagPart < 0)
				{
					str += "-";
				}
				else
				{
					if(RealPart != 0)
					{
						str += "+";
					}
				}
				//str += ImagPart > 0 ? " + " : " - ";
			}
			if(ImagPart != 0)
			{
				str += ((ImagPart == 1) || (ImagPart == -1) ? "i" : String.Format("{0:G}i", Math.Abs(ImagPart)));
			}
			return str;
		}
	}
}
