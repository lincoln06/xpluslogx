using System;

namespace xpluslogx
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj dokładność");
            double epsilon = double.Parse(Console.ReadLine());
            double xZero = FindZeroPoint(1, 1, epsilon);
            
            Console.WriteLine($"Wynik: {xZero}");
            Console.ReadKey();

        }
        static double FindZeroPoint(double a,double b, double epsilon)
        {
            double cpoint = a+((b-a)/2);
            if(Math.Abs(FindLog(cpoint))<=epsilon) return cpoint;
            if (FindLog(cpoint) > 0) b = cpoint;
            if (FindLog(cpoint) < 0) a = cpoint;
            return FindZeroPoint(a, b, epsilon);
        }
        static double FindLog(double x)
        {
            
            return (x + Math.Log10(x));
        }
    }
}
