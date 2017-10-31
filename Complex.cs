using System;

namespace Complex
{
	public class Complex
    {
		public double RealPart { get; set; } = 0.0;
		public double ImagPart { get; set; } = 0.0;

		public static Complex operator + (Complex lhs, Complex rhs)
		{
			return new Complex(lhs.RealPart + rhs.RealPart, lhs.ImagPart + rhs.ImagPart);
		}
		public static Complex operator +(double lhs, Complex rhs)
		{
			return new Complex(lhs + rhs.RealPart, rhs.RealPart);
		}
		public static Complex operator +(Complex lhs, double rhs)
		{
			return rhs + lhs;
		}

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
				throw new DivideByZeroException();
			}
			return new Complex(lhs.RealPart / rhs, lhs.ImagPart / rhs);
		}
		public static Complex operator /(Complex lhs, Complex rhs)
		{
			if(rhs.RealPart == 0 && rhs.ImagPart == 0)
			{
				throw new DivideByZeroException();
			}
			if(rhs.ImagPart == 0)
			{
				return new Complex(lhs.RealPart / rhs.RealPart, lhs.ImagPart / rhs.RealPart);
			}
			return (lhs * rhs.Conjunction()) / (rhs.RealPart * rhs.RealPart + rhs.ImagPart * rhs.ImagPart);
		}
		public static Complex operator /(double lhs, Complex rhs)
		{
			return new Complex(lhs, 0) / rhs;
		}

		public Complex Conjunction()
		{
			return new Complex(RealPart, -ImagPart);
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
		}
		//public static Complex Power(Complex x, double y)
		//{
		//	throw new NotImplementedException();
		//}

		public Complex() { }
		public Complex(double real, double imaginary)
		{
			RealPart = real;
			ImagPart = imaginary;
		}

		public override string ToString()
		{
			string str = "";
			if(RealPart == 0 && ImagPart == 0)
			{
				return "0";
			}
			if(RealPart != 0)
			{
				str += String.Format("{0:G}", RealPart);
			}
			if(/*RealPart != 0 && */ImagPart != 0)
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
