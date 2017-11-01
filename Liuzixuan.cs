using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
//
//让你们见识下
//薛定谔命名法！
//
//
//
namespace BgNr6ELz {
    public class I8BaJWce {


        public float ykQCKKhF;
        public float lIjrvdRR;
        public I8BaJWce(float FnNoV1pP, float rScOmP) {
            ykQCKKhF = FnNoV1pP;
            lIjrvdRR = rScOmP;
        }

        public void nmsZ6D5f(I8BaJWce stkymb0T) {
            ykQCKKhF += stkymb0T.ykQCKKhF;
            lIjrvdRR += stkymb0T.lIjrvdRR;
        }

        public void IG57gqL2(I8BaJWce stkymb0T) {
            ykQCKKhF -= stkymb0T.ykQCKKhF;
            lIjrvdRR -= stkymb0T.lIjrvdRR;
        }
        public void JvNdqRs(I8BaJWce stkymb0T) {
            float JIy3rc7H, rFSeJ0rg;
            JIy3rc7H = ykQCKKhF * stkymb0T.ykQCKKhF - lIjrvdRR * stkymb0T.lIjrvdRR;
            rFSeJ0rg = ykQCKKhF * stkymb0T.lIjrvdRR + lIjrvdRR * stkymb0T.ykQCKKhF;
            ykQCKKhF = JIy3rc7H;
            lIjrvdRR = rFSeJ0rg;
        }
        public void aTFvqji5(I8BaJWce stkymb0T) {
            float JIy3rc7H, rFSeJ0rg;
            JIy3rc7H = (ykQCKKhF * stkymb0T.ykQCKKhF + lIjrvdRR * stkymb0T.lIjrvdRR) / (stkymb0T.ykQCKKhF * stkymb0T.ykQCKKhF + stkymb0T.lIjrvdRR * stkymb0T.lIjrvdRR);
            rFSeJ0rg = (lIjrvdRR * stkymb0T.ykQCKKhF - ykQCKKhF * stkymb0T.lIjrvdRR) / (stkymb0T.ykQCKKhF * stkymb0T.ykQCKKhF + stkymb0T.lIjrvdRR * stkymb0T.lIjrvdRR);
            ykQCKKhF = JIy3rc7H;
            lIjrvdRR = rFSeJ0rg;
        }
        public void Ae3n0GHZ(int AsN5iToH) {
            I8BaJWce l2A0BZNN = new I8BaJWce(this.ykQCKKhF, this.lIjrvdRR);
            for (int i = 1; i < AsN5iToH; i++) {
                this.JvNdqRs(l2A0BZNN);
            }
        }
        public string HxZ0AgSj() {
            string l2A0BZNN;
            if (lIjrvdRR >= 0) {
                l2A0BZNN = "+" + lIjrvdRR.ToString();
            }
            else {
                l2A0BZNN = lIjrvdRR.ToString();
            }
            return ykQCKKhF.ToString() + l2A0BZNN + "i";
        }
        public static I8BaJWce operator +(I8BaJWce Pjlzrtf1, I8BaJWce JFP4dRHk) {
            I8BaJWce bw3Glcdc = new I8BaJWce(Pjlzrtf1.ykQCKKhF, Pjlzrtf1.lIjrvdRR);
            bw3Glcdc.nmsZ6D5f(JFP4dRHk);
            return bw3Glcdc;
        }
        public static I8BaJWce operator -(I8BaJWce Pjlzrtf1, I8BaJWce JFP4dRHk) {
            I8BaJWce bw3Glcdc = new I8BaJWce(Pjlzrtf1.ykQCKKhF, Pjlzrtf1.lIjrvdRR);
            bw3Glcdc.IG57gqL2(JFP4dRHk);
            return bw3Glcdc;
        }
        public static I8BaJWce operator *(I8BaJWce Pjlzrtf1, I8BaJWce JFP4dRHk) {
            I8BaJWce bw3Glcdc = new I8BaJWce(Pjlzrtf1.ykQCKKhF, Pjlzrtf1.lIjrvdRR);
            bw3Glcdc.JvNdqRs(JFP4dRHk);
            return bw3Glcdc;
        }
        public static I8BaJWce operator /(I8BaJWce Pjlzrtf1, I8BaJWce JFP4dRHk) {
            I8BaJWce bw3Glcdc = new I8BaJWce(Pjlzrtf1.ykQCKKhF, Pjlzrtf1.lIjrvdRR);
            bw3Glcdc.aTFvqji5(JFP4dRHk);
            return bw3Glcdc;
        }
    }
    class Program {
        static void Main(string[] args) {
            I8BaJWce demo = new I8BaJWce(-2, -3);
            I8BaJWce demo2 = new I8BaJWce(3, 4);
            Console.WriteLine("(-2-3i)+(3+4i):");
            I8BaJWce demo3 = demo + demo2;
            Console.WriteLine(demo3.HxZ0AgSj());
            Console.WriteLine("(-2-3i)-(3+4i):");
            demo3 = demo - demo2;
            Console.WriteLine(demo3.HxZ0AgSj());
            Console.WriteLine("(-2-3i)*(3+4i):");
            demo3 = demo * demo2;
            Console.WriteLine(demo3.HxZ0AgSj());
            Console.WriteLine("(-2-3i)/(3+4i):");
            demo3 = demo / demo2;
            Console.WriteLine(demo3.HxZ0AgSj());
            Console.WriteLine("(-2-3i)^2");
            demo.Ae3n0GHZ(2);
            Console.WriteLine(demo.HxZ0AgSj());
            Console.Read();
        }
    }
}
