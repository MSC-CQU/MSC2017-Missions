using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace complex
{
    /**
     *  Created by HuangShiqi. 
     */
    class complex
    {
        static void Main(string[] args)
        {
            Plural output = new Plural();
            Console.WriteLine("\t请输入第一个实部");
            Console.WriteLine("\ta");
            output.a = (double)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\t请输入第一个虚部");
            Console.WriteLine("\tb:");
            output.b = (double)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\t请输入第二个实部");
            Console.WriteLine("\tc");
            output.c = (double)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\t请输入第二个虚部");
            Console.WriteLine("\td:");
            output.d = (double)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\t两个复数相加计算结果为：{0}+{1}i", output.Real_plus(), output.Virtual_plus());
            Console.WriteLine("\t两个复数相减计算结果为：{0}+{1}i", output.Real_subtrict(), output.Virtual_subtract());
            Console.WriteLine("\t两个复数相乘计算结果为：{0}+{1}i", output.Real_multply(), output.Virtual_multply());
            Console.WriteLine("\t两个复数相除计算结果为：{0}+{1}i", output.Real_divide(), output.Virtual_divide());
            Console.Read();
        }


        class Plural
        {
            public double a, b;         //实数部分
            public double c, d;         //虚数部分

            //实数部分加法
            public double Real_plus()   
            {
                double x;
                x = a + c;
                return x;
            }
            //虚数部分加法
            public double Virtual_plus()
            {
                double y;
                y = b + d;
                return y;
            }
            //虚数部分减法
            public double Real_subtrict()
            {
                double x;
                x = a - c;
                return x;
            }
            //虚数部分减法
            public double Virtual_subtract()
            {
                double y;
                y = b - d;
                return y;
            }


            /**
             *       (a+bi)(c+di)
             *      =(ac-bd)+(ac+bd)i
             *      
			 *		x = (ac-bd)
             *      y = (bc+ad)
             *     
             */
			//实数部分乘法
            public double Real_multply()
            {
                double x;
                x = a * c - b * d;
                return x;
            }
            //虚数部分乘法
            public double Virtual_multply()
            {
                double y;
                y = b * c + a * d;
                return y;
            }

            /**
             *       (a+bi)/(c+di)
             *      =(a+bi)(c-di)/(c^2+d^2)
             *      =(ac+bd)/(c^2+d^2)+(bc-ad)i/(c^2+d^2)
             *      Above all : x = (ac+bd)/(c*c+d*d)
             *                  y = (bc-ad)/(c*c+d*d)
             */
            //实数部分除法
            public double Real_divide()
            {
                double x;
                x = (a * c + b * d) / (c * c + d * d);
                return x;
            }
            //虚数部分除法
            public double Virtual_divide()
            {
                double y;
                y = (b * c - a * d) / (c * c + d * d);
                return y;
            }
        }
    }
}
