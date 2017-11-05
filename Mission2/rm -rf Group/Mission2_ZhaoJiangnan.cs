using System;


namespace Complex
{
    class Complex
    {
        private double real;
        private double imaginary;      //安全起见改为private变量 
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
//乘法  幂运算时使用  我直接用的刘的函数 
        public void multiply(Complex c)
        {

            double temp1;
            double temp2;
            temp1 = real * c.real - imaginary * c.imaginary;
            temp2 = real * c.imaginary + imaginary * c.real;
            real = temp1;
            imaginary = temp2;
        }

        //（更改为运算符重载）

        //ADD
        public static complex operator +(Complex c1, Complex c2)//c1 c1 are the two complex numbers      
        {
            return new Complex(c1.real + c2.real, c1.imaginary + c2.imaginary);
        }
        //Sub
        public static complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.real - c2.real, c1.imaginary - c2.imaginary);
        }
        //multiply
        public static complex operator *(Complex c1, Complex c2)
        {
           return new Complex(c1.real * c2.real, c1.imaginary * c2.imaginary);
        }
        //Division
        public static complex operator /(Complex c1, Complex c2)
        {
            double denominator = c2.real * c2.real + c2.imaginary * c2.imaginary;
            double Newreal = c1.real * c2.real + c1.imaginary * c2.imaginary;
            double Newimag = -c1.real * c2.imaginary + c1.imaginary * c2.real;
            return new Complex(Newreal / denominator, Newimag / denominator);
        }
        //缺少一个幂运算
        public void PowerOn(int PowerOnNum)
        {
            Complex temp = new Complex(this.real, this.imaginary);
            for (int i = 1; i < PowerOnNum; i++)
            {
                this.Multiply(temp);
            }
        }

    }


}