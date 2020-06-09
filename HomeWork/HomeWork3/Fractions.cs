using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MethodsLib;

namespace HomeWork3
{
   public class Fractions
    {
        int numerator, denominator;
        static int exchange;
        static string exmessage = "Знаменатель не может быть равен 0";
        static int resnum;
        static double tf;
        static string sform;

        public Fractions()
        {
            numerator = denominator = 1;
        }
        public Fractions(int num, int denom)
        {
            Num = num;
            Denom = denom;
        }

        public int Num
        {
            set
            {
                numerator = value;
            }
            get
            {
                return numerator;
            }
        }
        public int Denom
        {
            set
            {
                if (value == 0) throw new ArgumentOutOfRangeException(exmessage);
                else denominator = value;
            }
            get
            {
                return denominator;
            }
        }

        public static double TenthFraction
        {
            get
            {
                return tf;
            }
        }
        public static string Sform
        {
            get
            {
                return sform;
            }
        }
        public static string FractionsSum (Fractions fr1, Fractions fr2)
        {
            if (fr1.Denom != fr2.Denom )
            { 
                exchange = fr1.Denom;
                fr2.Num = fr2.Num * fr1.Denom;
                fr1.Denom = fr1.Denom * fr2.Denom; 
                fr1.Num = fr1.Num * fr2.Denom;
                fr2.Denom = fr2.Denom * exchange;

                if ((fr1.Num + fr2.Num) > fr2.Denom )
                {
                    resnum = (fr1.Num + fr2.Num) / fr2.Denom;                   
                }
                tf = Convert.ToDouble(fr1.Num + fr2.Num) / fr2.Denom;
                sform = resnum + " целая(ых)" + " " + (-fr2.Denom*resnum + fr1.Num + fr2.Num) + "/" + fr2.Denom;
                return (fr1.Num + fr2.Num) + "/" + fr2.Denom;
            }
            else
            {
                tf = Convert.ToDouble(fr1.Num + fr2.Num) / fr2.Denom;
                sform = resnum + " целая(ых)" + " " + (-fr2.Denom + fr1.Num + fr2.Num) + "/" + fr2.Denom;
                return (fr1.Num + fr2.Num) + "/" + fr2.Denom;
            }    
        }
        public static string FractionsSubstract(Fractions fr1, Fractions fr2)
        {
            if (fr1.Denom != fr2.Denom)
            {
                exchange = fr1.Denom;
                fr2.Num = fr2.Num * fr1.Denom;
                fr1.Denom = fr1.Denom * fr2.Denom;
                fr1.Num = fr1.Num * fr2.Denom;
                fr2.Denom = fr2.Denom * exchange;

                if ((fr1.Num + fr2.Num) > fr2.Denom)
                {
                    resnum = (fr1.Num - fr2.Num) / fr2.Denom;
                }
                tf = Convert.ToDouble(fr1.Num - fr2.Num) / fr2.Denom;
                sform = resnum + " целая(ых)" + " " + (-fr2.Denom*resnum + fr1.Num - fr2.Num) + "/" + fr2.Denom;
                return (fr1.Num - fr2.Num) + "/" + fr2.Denom;
            }
            else
            {
                resnum = (fr1.Num - fr2.Num) / fr2.Denom;
                tf = Convert.ToDouble(fr1.Num - fr2.Num) / fr2.Denom;
                sform = resnum + " целая(ых)" + " " + (-fr2.Denom*resnum + fr1.Num - fr2.Num) + "/" + fr2.Denom;
                return (fr1.Num - fr2.Num) + "/" + fr2.Denom;
            }
        }
        public static string FractionsMultiplication(Fractions fr1, Fractions fr2)
        {
            if ((fr1.Num * fr2.Num) > (fr2.Denom * fr1.Denom))
            {
                resnum = (fr1.Num * fr2.Num) / (fr2.Denom * fr1.Denom);
                tf = Convert.ToDouble(fr1.Num * fr2.Num) / (fr1.Denom * fr2.Denom);
                sform = resnum + " целая(ых)" + " " + (-fr1.Denom * fr2.Denom*resnum + fr1.Num * fr2.Num) + "/" + (fr1.Denom * fr2.Denom);
            }
            else
            {
                resnum = (fr1.Num * fr2.Num) / (fr2.Denom * fr1.Denom);
                tf = Convert.ToDouble(fr1.Num * fr2.Num) / (fr1.Denom * fr2.Denom);
                sform = resnum + " целая(ых)" + " " + (fr1.Num * fr2.Num) + "/" + (fr1.Denom * fr2.Denom);
            }            
            return fr1.Num * fr2.Num + "/" + fr1.Denom * fr2.Denom;
            
        }
    }
}