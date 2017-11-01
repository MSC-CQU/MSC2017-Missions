//CQU@苏晨林
//MSC第一次培训作业
//也是我的第二个不算成功的C#程序，可喜可贺
//上一次不算的程序，简易的万圣节主题计算器，已经被人道毁灭了，可喜可贺
//Start Time：10/31/2017 23:52
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace SMiku_Complex_counter
{
    class Complex_counter
    {
        //定义实部与虚部
        double real = 0;
        double imaginary = 0;

        public Complex_counter(double real_1, double imaginary_1)
        {
            this.real = real_1;
            this.imaginary = imaginary_1;
        }
        public Complex_counter Add (Complex_counter num1)//加法
        {
            double x;
            double y;
            x = num1.real + real;
            y = num1.imaginary + imaginary;
            return new Complex_counter(x, y);
        }
        public Complex_counter Sub(Complex_counter num1)//减法
        {
            double x;
            double y;
            x = num1.real - real;
            y = num1.imaginary - imaginary;
            return new Complex_counter(x, y);
        }
        public Complex_counter Mul(Complex_counter num1)//乘法
        {
            double x;
            double y;
            x = num1.real * real - num1.imaginary * imaginary;
            y = num1.imaginary * imaginary + num1.real * imaginary;
            return new Complex_counter(x, y);
        }
        public Complex_counter Div(Complex_counter num1)//除法
        {
            double x;
            double y;
            x = (num1.real * real + num1.imaginary * imaginary) / (num1.imaginary * num1.imaginary + num1.real * num1.real);
            y = (num1.real * imaginary - num1.imaginary * real) / (num1.imaginary * num1.imaginary + num1.real * num1.real);
            return new Complex_counter(x, y);
        }

    }
}
//Complete time: 11/01/2017 00:58
//因为本人数学能力有限，对于虚数整数幂的运算、重载运算符、欧拉公式上都没有学习（海南的高考数学）
//目前也仅仅是只完成了加减乘除的实现，甚至连运行输出都做不到，也就仅仅是这样了
