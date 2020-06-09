using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkLesson3
{
    class ComplexNums
    {
        double im, re;
        string exmessage = "Аргумент вне требуемых параметров (0,100)";

        public ComplexNums()
        {
            im = re = 0;
        }

        public ComplexNums(int im, int re)
        {
            IM = im;
            RE = re;
        }
        public string ComplexSum (ComplexNums nums1, ComplexNums nums2)
        {
            return (nums1.re + nums2.re) + "+" + (nums1.im + nums2.im) + "i";
        }
        public string ComplexSubstract (ComplexNums nums1, ComplexNums nums2)
        {
            if ((nums1.im - nums2.im) < 0)
            {
                return (nums1.re - nums2.re) + "" + (nums1.im - nums2.im) + "i";
            }
            else return (nums1.re - nums2.re) + "-" + (nums1.im - nums2.im) + "i";           
        }
        public string ComplexMultipication(ComplexNums nums1, ComplexNums nums2)
        {
            return (nums1.re * nums2.re - nums1.im * nums2.im) + "+" + (nums1.im * nums2.re + nums1.re * nums2.im) + "i";
        }
        public double IM
        {
            set
            {             
                    if (value > 100 || value < 0) throw new ArgumentOutOfRangeException(exmessage);
                    else
                    im = value;                             
            }
        }
        public double RE
        {
            set
            {
                    if (value > 100 || value < 0) throw new ArgumentOutOfRangeException(exmessage);
                    else
                    re = value;
            }
        }
    }

}
