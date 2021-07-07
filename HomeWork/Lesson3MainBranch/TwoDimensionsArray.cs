using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4MainBranch
{
    class TwoDimensionsArray
    {
        int[,] a;
        static StreamWriter sw;
        static StreamReader sr;
        public int[,] Arr { get; set; }

        static Random rnd = new Random();
        public TwoDimensionsArray(int n, int min, int max)
        {
            a = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    a[i, j] = rnd.Next(min, max);
            Arr = a;
        }
        public TwoDimensionsArray(string path)
        {         
                try
                {
                    sr = new StreamReader(path);
                    int n = 4;
                    a = new int[n, n];
                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < n; j++)
                            a[i, j] = Convert.ToInt32(sr.ReadLine());
                    Arr = a;
                    sr.Close();
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Некорректный путь");
                }
                catch(ArgumentException)
                {
                    Console.WriteLine("Некорректный путь");
                }
          
        }
        public void WriteToFile(string path)
        {
                sr.Close();         
                sw = new StreamWriter(path);
                if(File.Exists(path) != true)
                {
                    throw new Exception("Невозможно создать файл");
                }
                else
                {
                    foreach (int c in Arr)
                    {
                        sw.WriteLine(c);
                    }
                    sw.Close();
                    Console.WriteLine("Файл записан");
                }               
                  
        }

        public int Min
        {
            get
            {
                int min = a[0, 0];
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                        if (a[i, j] < min) min = a[i, j];
                return min;
            }
        }
        public int Max
        {
            get
            {
                int max = a[0, 0];
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                        if (a[i, j] > max) max = a[i, j];
                return max;
            }
        }

        public void MaxElementIdx(out int idx1, out int idx2)
        {
            idx1 = 0;
            idx2 = 0;
            int max = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    if (a[i, j] > max)
                    {
                        idx1 = i;
                        idx2 = j;
                        max = a[i, j];
                    }
        }
        public int ElementsSum()
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                {                    
                    sum += a[i, j];
                }
            return sum;
        }
        public int ElementsSumAboveZero()
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum += a[i, j] > 0 ? a[i, j]:0 ;
                }
            return sum;
        }
    }
}