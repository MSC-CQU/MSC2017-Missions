using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
        class  Complex
        {
            private double realPart;
            private double imaginaryPart;

            public Complex() { realPart = 0; imaginaryPart = 0; }
            public Complex(double real, double imaginary) { realPart = real; imaginaryPart = imaginary; }

            public override string ToString()
            {
                string result = realPart.ToString();
                if (imaginaryPart >= 0) result += "+";
                result += imaginaryPart.ToString() + "i";
                return result;
            }

            static public Complex operator +(Complex a, Complex b)
            {
                Complex result = new Complex();
                result.realPart = a.realPart + b.realPart;
                result.imaginaryPart = a.imaginaryPart + b.imaginaryPart;
                return result;
            }

            static public Complex operator -(Complex a)
            {
                Complex result = new Complex(-a.realPart, -a.imaginaryPart);
                return result;
            }

            static public Complex operator -(Complex a, Complex b)
            {
                return a + (-b);
            }

            static public Complex operator *(Complex a, Complex b)
            {
                Complex result = new Complex();
                result.realPart = (a.realPart * b.realPart) - (a.imaginaryPart * b.imaginaryPart);
                result.imaginaryPart = (a.realPart * b.imaginaryPart) + (a.imaginaryPart * b.realPart);
                return result;
            }

            static public Complex operator /(Complex a, Complex b)
            {
                Complex result = new Complex();
                Complex Conjugal = new Complex(b.realPart, -b.imaginaryPart);
                double denominator = (b.realPart * b.realPart) + (b.imaginaryPart * b.imaginaryPart);
                result = a * Conjugal;
                result.realPart /= denominator;
                result.imaginaryPart /= denominator;
                return result;
            }

    }
}


