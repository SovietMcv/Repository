using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4MainBranch
{
   class MyArray
    {
        int[] arr;
        static Random random = new Random();
        int Min { get; set; }
        int Max { get; set; }
        public int[] Arr { get { return arr; } set { arr = value; } }
        int ArrSum { get; set; }
        int ElementsMaxCount { get; set; }
        int DivNumsCount { get; set; }
        static int[] MergedArr { get; set; }
        public int Length { get
            {
                int arrL = 0;
                foreach (int c in Arr)
                {
                    arrL++;
                }
                return arrL;
            }
        }
        public ref int this[int i]
        {
            get { return ref Arr[i]; }
        }

        public MyArray(int min, int max)
        {
            int[] arr = new int[20];
            Min = min;
            Max = max;
            for(int c = 0; c < arr.Length; c++)
            {
                arr[c] =  random.Next(Min, Max);
            }
            Arr = arr;
        }
        public MyArray(string FilePath)
        {
            StreamReader sr = new StreamReader(FilePath);
            List<int> arr = new List<int>();
            
            for (int c = 0; c < arr.Count; c++)
            {
                arr.Add(Convert.ToInt32(sr.ReadLine()));
            }
            Arr = arr.ToArray();
        }
        public void WriteArrayToFile(string path)
        {
            StreamWriter sw = new StreamWriter(path);
            StreamReader sr = null;
            if (!File.Exists(path)) return;
            for (int c = 0; c < Arr.Length; c++)
            {
                sw.WriteLine(Arr[c]);
            }
            sw.Close();
        }

        public int[] ArrayCopy()
        {
            int[] NewArr = Arr;
            return NewArr;
        }   
        public void ArrayResize(int Length)
        {
            int[] OldArr = Arr;
            int[] NewArr = new int[Length];
            for (int i = 0; i < NewArr.Length;i++)
            {
                NewArr[i] = i < OldArr.Length ? OldArr[i] : 0;
            }
            Arr = NewArr;
        }
        public static int[] ArrayMerge(MyArray arr1, MyArray arr2)
        {          
            MergedArr = new int[arr1.Length + arr2.Length];

            for (int i = 0; i < MergedArr.Length;i++)
            {
                MergedArr[i] = i < arr1.Length ? arr1.Arr[i] : arr2.Arr[i - arr2.Length];
            }
            return MergedArr ;
        }
        public int ArrayDivNumsCount()
        {
            int numcount = 0;
            int[] helparr = new int[2];
            foreach (int c in Arr)
            {
                helparr[numcount] = c;
                if (numcount >=1)
                {
                    foreach (int i in helparr)
                    {
                        if (i % 3 == 0)
                        {
                            DivNumsCount++;
                            break;
                        }
                    }
                }
                numcount = numcount >= 1 ? numcount = 0 : numcount+1;
                //Инкремент почему-то не сработал, поэтому +1
            }
            return DivNumsCount;
        }
        public int ArrayElementsSum()
        {
            ArrSum = 0;
            foreach (int c in Arr)
            {
                ArrSum += c;
            }
            return ArrSum;
        }
        public int[] ArrayElementsInverse()
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = Arr[i] * (-1);
            }
            return Arr;
        }

        public int[] ArrayElementsMultByNum(int num)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = Arr[i] * num;
            }
            return Arr;
        }
        public void ShowArrayElements()
        {
            foreach(int c in Arr)
            {
                Console.Write(c+" ");
            }
            Console.WriteLine();
        }
        public static void ShowArrayElements(int[] arr)
        {
            foreach (int c in arr)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
        }
        public int ArrayElementsMaxCount()
        {
            int maxnum = Arr[0];
            foreach (int c in Arr)
            {
                maxnum = maxnum < c ? c : maxnum;
            }
            foreach (int c in Arr)
            {
               ElementsMaxCount = maxnum == c ? ElementsMaxCount+1 : ElementsMaxCount;
                //тут почему-то не сработал инкремент, поэтому +1
            }
            return ElementsMaxCount;
        }
    }
}