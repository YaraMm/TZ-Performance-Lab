using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_2
{
    internal class Program
    {
        public static string PointsCondition(string circle, string points) // must change input types!
        {
            string[] stringCircle = circle.Split();//string array of circles coordinates
            string[] stringPoints = points.Split();//string array of points coordinates

            double[] doubleCircle = new double[stringCircle.Length];
            double[] doublePoints = new double[stringPoints.Length];

            for (int i = 0; i < stringCircle.Length; i++) doubleCircle[i] = double.Parse(stringCircle[i]); //int array of circles coordinates
            for (int i = 0; i < stringPoints.Length; i++) doublePoints[i] = double.Parse(stringPoints[i]);//int array of points coordinates

            double circleX = doubleCircle[0];
            double circleY = doubleCircle[1];
            double radiusCircle = doubleCircle[2];

            int x = (doublePoints.Length / 2);

            int chet = 0;
            double[] myPointsArrX = new double[x];
            for (int i = 0; i < x; i++)
            {
                myPointsArrX[i] = doublePoints[chet]; //even poins coordinates array
                chet += 2;
            }

            int nechet = 1;
            double[] myPointsArrY = new double[x]; //odd poins coordinates array
            for (int i = 0; i < x; i++)
            {
                myPointsArrY[i] = doublePoints[nechet];
                nechet += 2;
            }

            string result = "";
            string res = "";
            double d;
            for (int i = 0; i < x; i++)
            {
                d = Math.Sqrt(Math.Pow((myPointsArrX[i] - circleX), 2) + (Math.Pow((myPointsArrY[i] - circleY), 2)));
                if (d < radiusCircle) res = "1"; //in the circle
                else if (d > radiusCircle) res = "2"; //outside the circle 
                else res = "0"; //on the circle
                result += res + "\n";
            }
            return result;
        }
        static void Main(string[] args)
        {
            string v = string.Join(" ", args);
            string[] ab = v.Split();

            string a = File.ReadAllText(ab[0]);
            string b = File.ReadAllText(ab[1]);

            a = a.Replace("\r\n", " ");
            b = b.Replace("\r\n", " ");

            Console.WriteLine(PointsCondition(a, b));
        }
    }
}
