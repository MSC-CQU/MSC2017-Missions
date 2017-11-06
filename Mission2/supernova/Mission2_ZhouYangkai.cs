using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fushulei//拼音命名大法
{
    public class Dovahkiin//某位大佬提到的龙语瞎JB命名大法
    {
        /*
         * 这就是一知半解的学习外加各论坛取经的产物，所以说格式大概会很鬼畜
         * 像summary这些完全照搬的东西...大佬们将就看看吧
         * 另外，为了养生，这个玩意没有进过任何测试QAQ
         * 还可能有敲错字母而自己还不知道的傻逼行为
         * 总的来说，感觉自己写了个bug
         * 以上
         */

        private double shibu;//实部
        private double xubu;//虚部
        ///<summary>
        ///抓取一只活蹦乱跳的实部
        ///</summary>
        public double Shibu
        {
            get { return shibu; }
            set { shibu = value; }
        }
        ///<summary>
        ///再抓一只怪迷日眼的虚部
        ///</summary>
        public double Xubu
        {
            get { return xubu; }
            set { xubu = value; }
        }
        public Dovahkiin(double shibu, double xubu)
        {
            this.shibu = shibu;
            this.xubu = xubu;
        }
        ///<summary>
        ///加法重载
        ///</summary>
        ///<param name="D">加数</param>
        ///<param name="d">加数</param>
        ///<returns>相加的结果</returns>
        public static Dovahkiin operator +(Dovahkiin D, Dovahkiin d)
        {
            return new Dovahkiin(D.shibu + d.shibu, D.xubu + d.xubu);
        }
        ///<summary>
        ///减法重载
        ///</summary>
        ///<param name="D">被减数</param>
        ///<param name="d">减数</param>
        ///<returuns>相减结果</returuns>
        public static Dovahkiin operator -(Dovahkiin D, Dovahkiin d)
        {
            return new Dovahkiin(D.shibu - d.shibu, D.xubu - d.xubu);
        }
        ///<summary>
        ///乘法
        ///</summary>
        ///<param name="D">乘数</param>
        ///<param name="d">乘数</param>
        ///<returuns>相乘结果</returuns>
        public static Dovahkiin operator *(Dovahkiin d, Dovahkiin D)
        {
            //乘法咋算的来着。。
            //算了去论坛扒一个
            //(a+b*i)*(c+d*i)=(ac-bd)+(ad+bc)*i
            return new Dovahkiin(d.shibu * D.shibu - d.xubu * D.xubu, d.shibu * D.xubu + d.xubu * D.shibu);
        }
        ///<summary>
        ///除法
        ///</summary>
        ///<param name="D">被除数</param>
        ///<param name="d">除数</param>
        ///<returns>相除结果</returns>
        public static Dovahkiin operator /(Dovahkiin D, Dovahkiin d)
        {
            if (d.shibu == 0 && d.xubu == 0)
            {
                Console.Write ("除数不为零啊亲");
            }
            return new Dovahkiin((D.shibu * d.shibu + d.xubu * D.xubu) / (d.shibu * d.shibu + d.xubu + d.xubu), (D.xubu * d.shibu - d.xubu * D.shibu) / (d.shibu * d.shibu + d.xubu + d.xubu));
        }
        ///<summary>
        ///求幂
        ///</summary>
        public static Dovahkiin Dpow(Dovahkiin d,double n)
        {
            double x = Math.Pow(d.shibu * d.shibu + d.xubu * d.xubu, n / 2);//难以言说的操作
            double y = Math.Pow(d.shibu * d.shibu + d.xubu * d.xubu, 1 / 2);//求模
            double a = Math.Asin(d.xubu / y);//求角度
            double b = Math.Cos(n * a);
            double c = Math.Sin(n * a);
            return new Dovahkiin(x * b, x * c);//用x(cosθ+sinθ)表示结果
        }
    }
    class TestComplex



    {



        static void Main()
        {

            //读入数据

            Console.WriteLine("please enter a real number:");

            int a = Console.Read();

            Console.WriteLine("please enter a imaginary number:");

            int b = Console.Read();

            Console.WriteLine("please enter a real number:");

            int c = Console.Read();

            Console.WriteLine("please enter a imaginary number:");

            int d = Console.Read();

            //数值计算

            Dovahkiin num1 = new Dovahkiin(a, b);

            Dovahkiin num2 = new Dovahkiin(c, d);

            Dovahkiin sum = num1 + num2;

            Dovahkiin sub = num1 - num2;

            Dovahkiin multiplication = num1 * num2;

            Dovahkiin division = num1 / num2;

            //输出结果

            Console.WriteLine("第一个复数:  {0}", num1);

            Console.WriteLine("第二个复数: {0}", num2);

            Console.WriteLine("复数和: {0}", sum);

            Console.WriteLine("复数差: {0}", sub);

            Console.WriteLine("复数积: {0}", multiplication);

            Console.WriteLine("复数商: {0}", division);

            Console.WriteLine("please enter a real number:");

            int g = Console.Read();

            Console.WriteLine("please enter a imaginary number:");

            int e = Console.Read();

            Console.WriteLine("please enter a  number as the power:");

            int f = Console.Read();

            //乘方运算

            Dovahkiin num3 = new Dovahkiin(g, e);

            for (int i = 1; i <= f; i++)

            {

                Dovahkiin power = num3 * num3;





                Console.WriteLine("乘方是: {0}", power);
            }
        }



    }

}

