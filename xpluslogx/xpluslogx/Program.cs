using System;

namespace xpluslogx
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj dokładność");
            double epsilon = double.Parse(Console.ReadLine());
            double xZero = FindZeroPoint(0.0, 1.5, epsilon);
            Console.WriteLine($"Wynik: {xZero}");
            Console.ReadKey();

        }
        static double FindZeroPoint(double a,double b, double epsilon)
        {
            if ((a + ((b - a) / 2)) + Math.Log10(a + ((b - a) / 2)) < epsilon)
            {
                Console.WriteLine($"xxx {(a + ((b - a) / 2)) + Math.Log10(a + ((b - a) / 2)}");
                return (a + ((b - a) / 2));
            }
            if (((a + ((b - a) / 2)) + (Math.Log10(a + ((b - a) / 2))) / a+Math.Log10(a)) < 0)
            {
                Console.WriteLine("111");

                b = a + ((b - a) / 2);
                return FindZeroPoint(a, b, epsilon);
            }
            
            a = a + ((b - a) / 2.0);
            Console.WriteLine("222");
            return FindZeroPoint(a, b, epsilon);
        }
    }
}
