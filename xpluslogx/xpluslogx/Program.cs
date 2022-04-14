using System;

namespace xpluslogx
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj dokładność");
            double epsilon = double.Parse(Console.ReadLine());
            double xZero = FindZeroPoint(0.0, 1.0, epsilon,0);
            Console.WriteLine($"Wynik: {xZero}");
            Console.ReadKey();

        }
        static double FindZeroPoint(double a,double b, double epsilon, int counter)
        {
            double cpoint = a+((b-a)/2);
            if ((cpoint + Math.Log10(cpoint)) > 0 && (cpoint + Math.Log10(cpoint)) < epsilon) return cpoint;
            if (counter % 2 != 0) b = cpoint;
            else a = cpoint;
            counter++;
            return FindZeroPoint(a, b, epsilon, counter);
        }
        static double FindLog(double x)
        {
            return x + Math.Log10(x);
        }
    }
}
