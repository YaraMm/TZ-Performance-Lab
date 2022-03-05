using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_4
{
    internal class Program
    {
        public static int ArithmeticMean(string m)
        {
            string v = m.Replace("  ", " ");
            string[] n = v.Split(' ');

            int[] numArr = new int[n.Length];
            for (int i = 0; i < n.Length; i++) numArr[i] = Int32.Parse(n[i]);

            double sum = 0.0;
            for (int i = 0; i < numArr.Length; i++) sum += Convert.ToDouble(numArr[i]);
            double arithmeticMean = sum / numArr.Length;
            arithmeticMean = Math.Round(arithmeticMean);
            double counter = 0;

            for (int i = 0; i < numArr.Length; i++)
            {
                if (numArr[i] <= arithmeticMean) counter += arithmeticMean - numArr[i];
                else counter += numArr[i] - arithmeticMean;
                Math.Round(counter);
            }
            return Convert.ToInt32(counter);
        }

        static void Main(string[] args)
        {
            string myStr = String.Join(" ", args);
            string a = File.ReadAllText(myStr);
            string b = a.Replace("\r\n", " ");
            Console.WriteLine(ArithmeticMean(b));
        }
    }
}
