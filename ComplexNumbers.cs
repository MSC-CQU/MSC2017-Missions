using System;

namespace complex_numbers
{
    class ComplexNumbers
    {
        private double real = 0.0;//Complex Number = (real part) + (imaginary part) i
        private double img = 0.0;

        public ComplexNumbers(double real_, double img_)
        {
            this.real = real_;
            this.img = img_;
        }

        public static ComplexNumbers operator +(ComplexNumbers num1, ComplexNumbers num2)
        {
            double real = num1.real + num2.real;
            double img = num1.img + num2.img;
            ComplexNumbers temp = new ComplexNumbers(real, img);
            return temp;
        }
        public static ComplexNumbers operator +(double num1, ComplexNumbers num2)
        {
            double real = num1 + num2.real;
            double img = num2.img;
            ComplexNumbers temp = new ComplexNumbers(real, img);
            return temp;
        }
        public static ComplexNumbers operator +(ComplexNumbers num1, double num2)
        {
            double real = num1.real + num2;
            double img = num1.img;
            ComplexNumbers temp = new ComplexNumbers(real, img);
            return temp;
        }

        public static ComplexNumbers operator -(ComplexNumbers num1, ComplexNumbers num2)
        {
            double real = num1.real - num2.real;
            double img = num1.img - num2.img;
            ComplexNumbers temp = new ComplexNumbers(real, img);
            return temp;
        }
        public static ComplexNumbers operator -(double num1, ComplexNumbers num2)
        {
            double real = num1 - num2.real;
            double img = -num2.img;
            ComplexNumbers temp = new ComplexNumbers(real, img);
            return temp;
        }
        public static ComplexNumbers operator -(ComplexNumbers num1, double num2)
        {
            double real = num1.real - num2;
            double img = num1.img;
            ComplexNumbers temp = new ComplexNumbers(real, img);
            return temp;
        }

        public static ComplexNumbers operator *(ComplexNumbers num1, ComplexNumbers num2)
        {
            double real = num1.real * num2.real - num1.img * num2.img;//(a + bi) * (c + di) = (ac+bd) + (ad+bc)i
            double img = num1.real * num2.img + num1.img * num2.real;
            ComplexNumbers temp = new ComplexNumbers(real, img);
            return temp;
        }
        public static ComplexNumbers operator *(double num1, ComplexNumbers num2)
        {
            double real = num1 * num2.real;//(a + bi) * (c + di) = (ac+bd) + (ad+bc)i
            double img = num1 * num2.img;
            ComplexNumbers temp = new ComplexNumbers(real, img);
            return temp;
        }
        public static ComplexNumbers operator *(ComplexNumbers num1, double num2)
        {
            double real = num1.real * num2;//(a + bi) * (c + di) = (ac+bd) + (ad+bc)i
            double img = num1.img * num2;
            ComplexNumbers temp = new ComplexNumbers(real, img);
            return temp;
        }

        public static ComplexNumbers operator /(ComplexNumbers num1, ComplexNumbers num2)
        {
            if (num2.real == 0 && num2.img == 0)
                throw new DivideByZeroException();
            else
            {
                double dividend = num2.real * num2.real + num2.img * num2.img;//c^2 + d^2
                double real = (num1.real * num2.real - num1.img * num2.img) / dividend;//(ac - bd) / (c^2 + d^2)
                double img = (num1.img * num2.real - num1.real * num2.img) / dividend;//(bd - ac) / (c^2 + d^2)
                ComplexNumbers temp = new ComplexNumbers(real, img);
                return temp;
            }
        }
        public static ComplexNumbers operator /(double num1, ComplexNumbers num2)
        {
            if (num2.real == 0 && num2.img == 0)
                throw new DivideByZeroException();
            else
            {
                double dividend = num2.real * num2.real + num2.img * num2.img;//a^2 + b^2
                double real = (num1 * num2.real) / dividend;//(m * a) / (a^2 + b^2)
                double img = (num1 * num2.img) / dividend;//(m * -bi) / (a^2 + b^2)
                ComplexNumbers temp = new ComplexNumbers(real, img);
                return temp;
            }
        }
        public static ComplexNumbers operator /(ComplexNumbers num1, double num2)
        {
            if (num2 == 0)
                throw new DivideByZeroException();
            else
            {
                double real = num1.real / num2;
                double img = num1.img / num2;
                ComplexNumbers temp = new ComplexNumbers(real, img);
                return temp;
            }
        }

        public static ComplexNumbers operator ^(ComplexNumbers num, int index)
        {
            ComplexNumbers temp = num;
            for (int i = 0; i < index - 1; i++)
            {
                temp *= num;
            }
            return temp;//power on integer by muiltyply
        }
        //print complex numbers
        
        public void get()//format output
        {
            if (real != 0)
            {
                if (img > 0)
                {
                    if (this.img == 1)
                    {
                        Console.WriteLine($"{Math.Round(this.real, 2)}+i");
                    }
                    else
                    {
                        Console.WriteLine($"{Math.Round(this.real, 2)}+{Math.Round(this.img, 2)}i");
                    }
                }
                else if (img == 0)
                {
                    Console.WriteLine($"{Math.Round(this.real, 2)}");
                }
                else
                {
                    if (this.img == -1)
                    {
                        Console.WriteLine($"{Math.Round(this.real, 2)}-i");
                    }
                    else
                    {
                        Console.WriteLine($"{Math.Round(this.real, 2)}{Math.Round(this.img, 2)}i");
                    }
                    
                }
            }
            else//format output
            {
                if(this.img == 1)
                {
                    Console.WriteLine($"i");
                }
                else if (this.img == 0)
                {
                    Console.WriteLine($"0");
                }
                else if (this.img == -1)
                {
                    Console.WriteLine($"-i");
                }
                else
                {
                    Console.WriteLine($"{Math.Round(this.img, 2)}i");
                }
            }
        }
        
    }
}