using System;

namespace xpluslogx
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj dokładność");
            double epsilon = double.Parse(Console.ReadLine());
            double xZero = FindZeroPoint(0, 1, epsilon);
            
            Console.WriteLine($"Wynik: {xZero}");
            //String.Format konwertuje wyświetlany wynik - w tym przypadku do 20 miejsc po przecinku
            //gdyż wyświetlenie wartości zmiennej typu double w postaci ułamka nieskończonego
            //daje nieczytelne wyniki i mogłoby uniemożliwić zweryfikowanie poprawności wykonania zadania
            Console.WriteLine($"Dokładność: {String.Format("{0:N20}",epsilon)}");
            Console.WriteLine($"Wynik działania x+logx: {String.Format("{0:N20}",FindLog(xZero))}");
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
