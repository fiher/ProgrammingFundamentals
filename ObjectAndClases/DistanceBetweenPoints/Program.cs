using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenPoints
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string inputP1 = Console.ReadLine();
            string inputP2 = Console.ReadLine();
            int[] point1Coords = inputP1.Split(' ').Select(int.Parse).ToArray();
            int[] point2Coords = inputP2.Split(' ').Select(int.Parse).ToArray();
            
            Point p1 = new Point() { X = point1Coords[0], Y = point1Coords[1]};
            Point p2 = new Point() { X = point2Coords[0], Y = point2Coords[1]};
            var dist = CalcDistance(p1, p2);
            Console.WriteLine("{0:f3}",CalcDistance(p1,p2));
            
            
        }
        private static double CalcDistance(Point p1,Point p2)
        {
            int a = Math.Abs(p1.X - p2.X);
            int b = Math.Abs(p1.Y - p2.Y);
            double c;
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            return c;
        }
    }
}
