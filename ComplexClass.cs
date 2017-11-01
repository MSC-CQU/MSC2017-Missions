using System;

namespace Complex
{
    class Complex
    {
        double real, imaginary;
        public Complex()
        {
            real = 0;
            imaginary = 0;
        }
        public Complex(double r)
        {
            real = r;
            imaginary = 0;
        }
        public Complex(double r, double i)
        {
            real = r;
            imaginary = i;
        }
        public double Real
        {
            set { real = value; }
            get { return real; }
        }
        public double Imaginary
        {
            set { imaginary = value; }
            get { return imaginary; }
        }
        //ADD
        public Complex Addcomplex(Complex c1, Complex c2)//c1 c1 are the two complex numbers
        {
            return new Complex(c1.real + c2.real, c1.imaginary + c2.imaginary);
        }
        //Sub
        public Complex Subcomplex(Complex c1, Complex c2)
        {
            return new Complex(c1.real - c2.real, c1.imaginary - c2.imaginary);
        }
        //multiply
        public Complex Mulcomplex(Complex c1, Complex c2)
        {
            return new Complex(c1.real * c2.real, c1.imaginary * c2.imaginary);
        }
        //Division
        public Complex Divcomplex(Complex c1, Complex c2)
        {
            double denominator = c2.real * c2.real + c2.imaginary * c2.imaginary;
            double Newreal = c1.real * c2.real + c1.imaginary * c2.imaginary;
            double Newimag = -c1.real * c2.imaginary + c1.imaginary * c2.real;
            return new Complex(Newreal / denominator, Newimag / denominator);
        }
    }
}
