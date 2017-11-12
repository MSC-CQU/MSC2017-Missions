using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Caculator {
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        int numFirtst;
        int numSecond;
        string yunsuanfu="";
        private void ChangeNum(object sender, RoutedEventArgs e) {
            int s = Convert.ToInt32(((Button)sender).Content);
            if (yunsuanfu == "") {
                if (lab.Content.ToString() == "0") {
                    lab.Content = s;
                    numFirtst = s;
                }
                else {
                    lab.Content = lab.Content + s.ToString();
                    numFirtst = Convert.ToInt32(numFirtst.ToString() + s.ToString());
                }

            }
            else {
                lab.Content = lab.Content + s.ToString();
                numSecond = Convert.ToInt32(numSecond.ToString() + s.ToString());
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            yunsuanfu = "+";
            lab.Content = lab.Content.ToString() + "+";
        }

        private void Caculate(object sender, RoutedEventArgs e) {
            int sum;
            switch (yunsuanfu) {
                case "+":
                    sum = numFirtst + numSecond;
                    lab.Content = sum.ToString();
                    yunsuanfu = "";
                    numFirtst = sum;
                    numSecond = 0;
                    break;
                case "-":
                    sum = numFirtst - numSecond;
                    lab.Content = sum.ToString();
                    yunsuanfu = "";
                    numFirtst = sum;
                    numSecond = 0;
                    break;
                case "X":
                    sum = numFirtst * numSecond;
                    lab.Content = sum.ToString();
                    yunsuanfu = "";
                    numFirtst = sum;
                    numSecond = 0;
                    break;
                case "/":
                    sum = numFirtst / numSecond;
                    lab.Content = sum.ToString();
                    yunsuanfu = "";
                    numFirtst = sum;
                    numSecond = 0;
                    break;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            yunsuanfu = "-";
            lab.Content = lab.Content.ToString() + "-";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) {
            yunsuanfu = "X";
            lab.Content = lab.Content.ToString() + "X";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) {
            yunsuanfu = "/";
            lab.Content = lab.Content.ToString() + "/";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e) {
            yunsuanfu = "";
            lab.Content = "0";
            numFirtst = 0;
            numSecond = 0;
        }
    }
}
