using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    internal class Program
    {
        public static int GCD(int a, int b)
        {
            if (a == 0)
            {
                return b;
            }
            else
            {
                var min = Math.Min(a, b);
                var max = Math.Max(a, b);
                return GCD(max % min, min);
            }
        }
        public static int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }

        public static string CircularArray(int n, int m)
        {
            int nod = GCD(n, m - 1);
            int nok = LCM(n, m - 1);

            int[] myArr = new int[n];
            for (int i = 0; i < n; i++) myArr[i] = i + 1;

            List<int> myList = new List<int>();

            for (int i = 0; i < nok; i += m - 1)
            {
                int counter = i % n;
                myList.Add(myArr[counter]);
            }

            string res = "";
            for (int i = 0; i < myList.Count; i++)
            {
                res += myList[i].ToString();
            }
            return res;
        }
        public static void Main(string[] args)
        {
            string start = string.Join(" ", args);
            string[] myArray = start.Split();
            int num1 = int.Parse(myArray[0]);
            int num2 = int.Parse(myArray[1]);
            Console.WriteLine(CircularArray(num1, num2));

        }
    }
}

