using System;

namespace HelloWorld
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

        public static ComplexNumbers operator +(ComplexNumbers num1_, ComplexNumbers num2_)
        {
            double real = num1_.real + num2_.real;
            double img = num1_.img + num2_.img;
            ComplexNumbers temp = new ComplexNumbers(real, img);
            return temp;
        }
        public static ComplexNumbers operator +(double num1_, ComplexNumbers num2_)
        {
            double real = num1_ + num2_.real;
            double img = num2_.img;
            ComplexNumbers temp = new ComplexNumbers(real, img);
            return temp;
        }
        public static ComplexNumbers operator +(ComplexNumbers num1_, double num2_)
        {
            double real = num1_.real + num2_;
            double img = num1_.img;
            ComplexNumbers temp = new ComplexNumbers(real, img);
            return temp;
        }

        public static ComplexNumbers operator -(ComplexNumbers num1_, ComplexNumbers num2_)
        {
            double real = num1_.real - num2_.real;
            double img = num1_.img - num2_.img;
            ComplexNumbers temp = new ComplexNumbers(real, img);
            return temp;
        }
        public static ComplexNumbers operator -(double num1_, ComplexNumbers num2_)
        {
            double real = num1_ - num2_.real;
            double img = -num2_.img;
            ComplexNumbers temp = new ComplexNumbers(real, img);
            return temp;
        }
        public static ComplexNumbers operator -(ComplexNumbers num1_, double num2_)
        {
            double real = num1_.real - num2_;
            double img = num1_.img;
            ComplexNumbers temp = new ComplexNumbers(real, img);
            return temp;
        }

        public static ComplexNumbers operator *(ComplexNumbers num1_, ComplexNumbers num2_)
        {
            double real = num1_.real * num2_.real - num1_.img * num2_.img;//(a + bi) * (c + di) = (ac+bd) + (ad+bc)i
            double img = num1_.real * num2_.img + num1_.img * num2_.real;
            ComplexNumbers temp = new ComplexNumbers(real, img);
            return temp;
        }
        public static ComplexNumbers operator *(double num1_, ComplexNumbers num2_)
        {
            double real = num1_ * num2_.real;//(a + bi) * (c + di) = (ac+bd) + (ad+bc)i
            double img = num1_ * num2_.img;
            ComplexNumbers temp = new ComplexNumbers(real, img);
            return temp;
        }
        public static ComplexNumbers operator *(ComplexNumbers num1_, double num2_)
        {
            double real = num1_.real * num2_;//(a + bi) * (c + di) = (ac+bd) + (ad+bc)i
            double img = num1_.img * num2_;
            ComplexNumbers temp = new ComplexNumbers(real, img);
            return temp;
        }

        public static ComplexNumbers operator /(ComplexNumbers num1_, ComplexNumbers num2_)
        {
            if (num2_.real == 0 && num2_.img == 0)
                throw new DivideByZeroException();
            else
            {
                double dividend = num2_.real * num2_.real + num2_.img * num2_.img;//c^2 + d^2
                ComplexNumbers conjugate = new ComplexNumbers(num2_.real, -num2_.img);
                ComplexNumbers temp = (num1_ * conjugate) / dividend;
                return temp;
            }
        }
        public static ComplexNumbers operator /(double num1_, ComplexNumbers num2_)
        {
            if (num2_.real == 0 && num2_.img == 0)
                throw new DivideByZeroException();
            else
            {
                double dividend = num2_.real * num2_.real + num2_.img * num2_.img;//a^2 + b^2
                double real = (num1_ * num2_.real) / dividend;//(m * a) / (a^2 + b^2)
                double img = (num1_ * num2_.img) / dividend;//(m * -bi) / (a^2 + b^2)
                ComplexNumbers temp = new ComplexNumbers(real, img);
                return temp;
            }
        }
        public static ComplexNumbers operator /(ComplexNumbers num1_, double num2_)
        {
            if (num2_ == 0)
                throw new DivideByZeroException();
            else
            {
                double real = num1_.real / num2_;
                double img = num1_.img / num2_;
                ComplexNumbers temp = new ComplexNumbers(real, img);
                return temp;
            }
        }

        public static ComplexNumbers operator ^(ComplexNumbers num_, int index_)
        {
            ComplexNumbers temp = num_;

            if (index_ > 0)
            {
                for (int i = 0; i < index_ - 1; i++)
                {
                    temp *= num_;
                }
                return temp;//power on integer by muiltyply
            }
            else if (index_ == 0)
            {
                return new ComplexNumbers(1, 0);
            }
            else
            {
                temp = temp ^ (-index_);
                temp = 1 / temp;
                return temp;
            }
        }

        public static void show(ComplexNumbers num)
        {
            num.Show();
        }

        public ComplexNumbers pow(int num)
        {
            return this ^ num;
        }

        //print complex numbers
        public void Show()//format output
        {
            if (this.real != 0)
            {
                if (this.img > 0)
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
                else if (this.img == 0)
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