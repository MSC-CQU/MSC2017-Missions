using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace complex
{
    class complex
    {
        static void Main(string[] args)
        {
            Plural output = new Plural();
            Console.WriteLine("请输入第一个实部");
            Console.WriteLine("a");
            output.a = (double)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入第一个虚部");
            Console.WriteLine("b:");
            output.b = (double)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入第二个实部");
            Console.WriteLine("c");
            output.c = (double)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入第二个虚部");
            Console.WriteLine("d:");
            output.d = (double)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("两个复数相加计算结果为：{0}+{1}i", output.Real1(), output.Virtual1());
            Console.WriteLine("两个复数相减计算结果为：{0}+{1}i", output.Real2(), output.Virtual2());
            Console.WriteLine("两个复数相乘计算结果为：{0}+{1}i", output.Real3(), output.Virtual3());
            Console.WriteLine("两个复数相除计算结果为：{0}+{1}i", output.Real4(), output.Virtual4());
            Console.Read();
        }
        class Plural
        {
            public double a, b, c, d;
            public double Real1()
            {
                double x;
                x = a + c;
                return x;
            }
            public double Virtual1()
            {
                double y;
                y = b + d;
                return y;
            }
            public double Real2()
            {
                double x;
                x = a - c;
                return x;
            }
            public double Virtual2()
            {
                double y;
                y = b - d;
                return y;
            }
            public double Real3()
            {
                double x;
                x = a * c - b * d;
                return x;
            }
            public double Virtual3()
            {
                double y;
                y = b * c + a * d;
                return y;
            }
            public double Real4()
            {
                double x;
                x = (a * c + b * d) / (c * c + d * d);
                return x;
            }
            public double Virtual4()
            {
                double y;
                y = (b * c - a * d) / (c * c + d * d);
                return y;
            }
        }
    }
}
