using System;

namespace OOP_lab_1_3_1
{
    public class Program
    {
        public static double C(int a, int b)
        {
            return Math.Sqrt(a * a + b * b);
        }

        public static double P(int a, int b)
        {
            return a + b + C(a, b);
        }

        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("c = {0}", C(a, b));
            Console.WriteLine("P = {0}", P(a, b));
        }
    }
}
