using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace fengjisuanqi
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private string anxiazhi = "";
        private double resultnum = 0.0;
        public MainWindow()
        {
            InitializeComponent();
        }
        //运算方法
        private void OperationNum(string s)
        {
            if (jiguo.Text != "")
            {
                switch (anxiazhi)
                {
                    case "":
                        resultnum = double.Parse(jiguo.Text);
                        anxiazhi = s;
                        break;
                    case "+":
                        resultnum = resultnum + double.Parse(jiguo.Text);
                        anxiazhi = s;
                        break;
                    case "-":
                        resultnum = resultnum - double.Parse(jiguo.Text);
                        anxiazhi = s;
                        break;
                    case "*":
                        resultnum = resultnum * double.Parse(jiguo.Text);
                        anxiazhi = s;
                        break;
                    case "/":
                        if (double.Parse(jiguo.Text) != 0.0)
                        {
                            resultnum = resultnum / double.Parse(jiguo.Text);
                        }
                        else
                        {
                            resultnum = 0.0;
                        }
                        anxiazhi = s;
                        break;
                    default: break;
                }
            }
            else
            {
                anxiazhi = s;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (anxiazhi == "=")
            {
                gongshi.Text = "";
                jiguo.Text = "";
                anxiazhi = "";
                resultnum = 0.0;
            }
            string s = ((Button)sender).Content.ToString();
            jiguo.Text = jiguo.Text + s;
            gongshi.Text = gongshi.Text + s;
        }
        //按运算符号的事件处理
        private void fuhao_Click_1(object sender, RoutedEventArgs e)
        {
            if (anxiazhi == "=")
            {
                gongshi.Text = jiguo.Text;
                anxiazhi = "";
            }
            string s = ((Button)sender).Content.ToString();//获得按钮文本内容
            gongshi.Text = gongshi.Text + s;
            OperationNum(s);
            jiguo.Text = "";
        }
        //按“=”号计算结果
        private void result_Click_1(object sender, RoutedEventArgs e)
        {
            OperationNum("=");
            jiguo.Text = resultnum.ToString();
        }
        //清除操作
        private void del_Click_1(object sender, RoutedEventArgs e)
        {
            jiguo.Text = "";
            gongshi.Text = "";
            anxiazhi = "";
            resultnum = 0.0;
        }
        //退格
        private void tuige_Click_1(object sender, RoutedEventArgs e)
        {
            //获取字符串长度
            int le = jiguo.Text.Length;
            int le2 = gongshi.Text.Length;
            if (le > 1 && le2 > 1)
            {
                jiguo.Text = jiguo.Text.Substring(0, le - 1);
                gongshi.Text = gongshi.Text.Substring(0, le2 - 1);
            }
        }
    }
}
