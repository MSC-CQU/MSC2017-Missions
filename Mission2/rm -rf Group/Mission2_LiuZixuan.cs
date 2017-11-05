using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexClass
{
    public class Complex
    {
        private float constant;
        private float coefficient;
        //外部程序访问类内部属性  比较安全
        public float coefficient
        {
            get { return coefficient; } 
            set { coefficient = value; }
        }
        public Complex(float constant, float coefficient)
        {
            this.constant = constant;
            this.coefficient = coefficient;
        }

        public Complex(float inputValue1, float inputValue2)
        {
            constant = inputValue1;
            coefficient = inputValue2;
        }

        public void Add(Complex ComplexObj)
        {
            constant += ComplexObj.constant;
            coefficient += ComplexObj.coefficient;
        }

        public void Substract(Complex ComplexObj)
        {
            constant -= ComplexObj.constant;
            coefficient -= ComplexObj.coefficient;
        }

        public void Multiply(Complex ComplexObj)
        {

            float constantTemp, coefficientTemp;
            constantTemp = constant * ComplexObj.constant - coefficient * ComplexObj.coefficient;
            coefficientTemp = constant * ComplexObj.coefficient + coefficient * ComplexObj.constant;
            constant = constantTemp;
            coefficient = coefficientTemp;
        }

        public void Divide(Complex ComplexObj)
        {

            float constantTemp, coefficientTemp;
            constantTemp = (constant * ComplexObj.constant + coefficient * ComplexObj.coefficient) / (ComplexObj.constant * ComplexObj.constant + ComplexObj.coefficient * ComplexObj.coefficient);
            coefficientTemp = (coefficient * ComplexObj.constant - constant * ComplexObj.coefficient) / (ComplexObj.constant * ComplexObj.constant + ComplexObj.coefficient * ComplexObj.coefficient);
            constant = constantTemp;
            coefficient = coefficientTemp;
        }
        //幂运算
        public void PowerOn(int PowerOnNum)
        {
            Complex ComplexObjTemp = new Complex(this.constant, this.coefficient);
            for (int i = 1; i < PowerOnNum; i++)
            {
                this.Multiply(ComplexObjTemp);
            }
        }

        public string Out()
        {
            string coefficientTemp;
            if (coefficient >= 0)
            {
                coefficientTemp = "+" + coefficient.ToString();
            }
            else
            {
                coefficientTemp = coefficient.ToString();
            }
            return constant.ToString() + coefficientTemp + "i";
        }
        //重载操作符
        public static Complex operator +(Complex ComplexObj1, Complex ComplexObj12)
        {
            Complex ComplexObjTemp = new Complex(ComplexObj1.constant, ComplexObj1.coefficient);
            ComplexObjTemp.Add(ComplexObj12);
            return ComplexObjTemp;
        }

        public static Complex operator -(Complex ComplexObj1, Complex ComplexObj12)
        {
            Complex ComplexObjTemp = new Complex(ComplexObj1.constant, ComplexObj1.coefficient);
            ComplexObjTemp.Substract(ComplexObj12);
            return ComplexObjTemp;
        }

        public static Complex operator *(Complex ComplexObj1, Complex ComplexObj12)
        {
            Complex ComplexObjTemp = new Complex(ComplexObj1.constant, ComplexObj1.coefficient);
            ComplexObjTemp.Multiply(ComplexObj12);
            return ComplexObjTemp;
        }

        public static Complex operator /(Complex ComplexObj1, Complex ComplexObj12)
        {
            Complex ComplexObjTemp = new Complex(ComplexObj1.constant, ComplexObj1.coefficient);
            ComplexObjTemp.Divide(ComplexObj12);
            return ComplexObjTemp;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Complex demo = new Complex(-2, -3);
            Complex demo2 = new Complex(3, 4);
            Console.WriteLine("(-2-3i)+(3+4i):");
            Complex demo3 = demo + demo2;
            Console.WriteLine(demo.Out());       //修改了输出 
            Console.WriteLine("(-2-3i)-(3+4i):");
            demo3 = demo - demo2;
            Console.WriteLine(demo3.Out());
            Console.WriteLine("(-2-3i)*(3+4i):");
            demo3 = demo * demo2;
            Console.WriteLine(demo3.Out());
            Console.WriteLine("(-2-3i)/(3+4i):");
            demo3 = demo / demo2;
            Console.WriteLine(demo3.Out());
            Console.WriteLine("(-2-3i)^2");
            demo.PowerOn(2);
            Console.WriteLine(demo.Out());
            Console.Read();
        }
    }

}