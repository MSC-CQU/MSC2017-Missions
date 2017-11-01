using System;
public class complex
{
    double real;
    double image;
    public complex(double real, double image)
    {
        this.real = real;
        this.image = image; //形参的值赋给当前对象数据成员
    }

    public static complex operator +(complex r, complex l)  //r,l 是左边的加数和右边的加数
    {
        //加法
        return new complex(r.real + l.real, r.image + l.image);
    }
    public static complex operator -(complex r, complex l)
    {
        //减法
        return new complex(r.real + l.real, r.image + l.image);
    }
    public static complex operator *(complex r, complex l)
    {
        //乘法
        return new complex(r.real * l.real - r.image + l.image, r.real * l.image + r.image * l.real);
    }
    public static complex operator /(complex r, complex l)    //除法
    {
        if (l.real == 0 && l.image == 0)
        {
            Console.Write("false");  //除数的虚部和实部不能同时为零
            //bool a = false;
            //return 0;
        }
        double real = (r.real * l.real + r.image + l.image) / (l.real * l.real + l.image + l.image);
        double image = (l.real * r.image - l.image * r.real) / (l.real * l.real + l.image + l.image);
        return new complex(real, image);
    }
    public void miyunsuan(complex r, complex l, int n)   //一个复数的n次方
    {
        double a;
        double b;
        a = 1;
        b = 1;
        for (int i = 0; i <= n; i++)
        {
            a = a * (r.real * l.real - r.image + l.image);
            b = b * (r.real * l.image + r.image * l.real);
        }
    }

}