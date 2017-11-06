using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Plural
    {
        private double _real_part;
        private double _imaginary_part;

        public double Real_part { get => _real_part; set => _real_part = value; }
        public double Imaginary_part { get => _imaginary_part; set => _imaginary_part = value; }

        public Plural()
        {
            this.Real_part = 0;
            this.Imaginary_part = 0;
        }

        public Plural(double num)
        {
            this.Real_part = num;
            this.Imaginary_part = 0;
        }

        public Plural(double num1, double num2)
        {
            this.Real_part = num1;
            this.Imaginary_part = num2;
        }
        /// <summary>
        /// 重载
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static Plural operator +(Plural num1, Plural num2)//加法
        {
            Plural ans=new Plural();
            ans.Real_part = num1.Real_part + num2.Real_part;
            ans.Imaginary_part = num1.Imaginary_part + num2.Imaginary_part;
            return ans;
        }

        public static Plural operator -(Plural num1, Plural num2)//减法
        {
            Plural ans = new Plural();
            ans.Real_part = num1.Real_part - num2.Real_part;
            ans.Imaginary_part = num1.Imaginary_part - num2.Imaginary_part;
            return ans;
        }

        public static Plural operator *(Plural num1, Plural num2)//乘法
        {
            Plural ans = new Plural();
            ans.Real_part = num1.Real_part * num2.Real_part - num1.Imaginary_part * num2.Imaginary_part;
            ans.Imaginary_part = num2.Real_part * num1.Imaginary_part + num1.Real_part * num2.Imaginary_part;
            return ans;
        }

        public static Plural operator /(Plural num1, Plural num2)//除法
        {
            Plural ans = new Plural();
            ans.Real_part = (num1.Real_part * num2.Real_part + num1.Imaginary_part * num2.Imaginary_part) / (num2.Real_part * num2.Real_part + num2.Imaginary_part * num2.Imaginary_part);
            ans.Imaginary_part = (num2.Real_part * num1.Imaginary_part - num1.Real_part * num2.Imaginary_part) / (num2.Real_part * num2.Real_part + num2.Imaginary_part * num2.Imaginary_part);
            return ans;
        }

        public Plural Pow(int num2)//幂方法
        {
            Plural ans = new Plural();
            ans.Real_part = 1;
            ans.Imaginary_part = 1;
            for (int i = 0; i < num2; ++i)
                ans = ans * this;
            return ans;
        }
    }
}
