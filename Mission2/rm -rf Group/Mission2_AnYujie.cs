using System;
public class complex {
    double real;
    double image;
    public complex(double real, double image) {
        this.real = real;
        this.image = image; //形参的值赋给当前对象数据成员
    }

    public static complex operator +(complex r, complex l)  //r,l 是左边的加数和右边的加数
    {
        //加法
        return new complex(r.real + l.real, r.image + l.image);
    }
    public static complex operator -(complex r, complex l) {
        //减法
        return new complex(r.real + l.real, r.image + l.image);
    }
    public static complex operator *(complex r, complex l) {
        //乘法
        return new complex(r.real * l.real - r.image + l.image, r.real * l.image + r.image * l.real);
    }
    public static complex operator /(complex r, complex l)    //除法
    {
        if (l.real == 0 && l.image == 0) {
            Console.Write("false");  //除数的虚部和实部不能同时为零
            //bool a = false;
            //return 0;
        }
        double real = (r.real * l.real + r.image + l.image) / (l.real * l.real + l.image + l.image);
        double image = (l.real * r.image - l.image * r.real) / (l.real * l.real + l.image + l.image);
        return new complex(real, image);
    }
    //一个复数的乘方为什么要用两个复数，所以删掉了一个,最后加了一个return
    //楼上的，return加错了，把返回类型改成了complex
    public complex miyunsuan(complex r, int n)   //一个复数的n次方
    {
        double a;
        double b;
        a = 1;
        b = 1;
        for (int i = 0; i <= n; i++) {
            a = a * (r.real * r.real - r.image * r.image);//我把+改成了*
            b = b * (r.real * r.image + r.image * r.real);
        }
        return new complex(a, b);
    }

}
class Program {

    static void Main(string[] args) {

    }
}