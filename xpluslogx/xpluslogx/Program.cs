using System;

namespace xpluslogx
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double xZero = 0.0;
            Console.WriteLine("Wybierz sposób");
            Console.WriteLine("1 - rekurencyjny");
            Console.WriteLine("2 - iteracyjny");
            int choose = int.Parse(Console.ReadLine());
            while(choose!=1&&choose!=2)
            {
                Console.Clear();
                Console.WriteLine("Wybierz sposób");
                Console.WriteLine("1 - rekurencyjny");
                Console.WriteLine("2 - iteracyjny");
                choose = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Podaj dokładność");
            double epsilon = double.Parse(Console.ReadLine());
            switch(choose)
            {
                case 1:
                    Console.WriteLine("Wybrałeś rozwiązanie rekurencyjne");
                    xZero = FindZeroPoint(0, 1, epsilon);
                    break;
                case 2:
                    Console.WriteLine("Wybrałeś rozwiązanie iteracyjne");
                    xZero = FindZeroPointIter(0, 1, epsilon);
                    break;
            }
            Console.WriteLine($"Funkcja x+logx ma miejsce zerowe w punkcie: {xZero}");
            //String.Format konwertuje wyświetlany wynik - w tym przypadku do 20 miejsc po przecinku
            //gdyż wyświetlenie wartości zmiennej typu double w postaci ułamka nieskończonego
            //daje nieczytelne wyniki i mogłoby uniemożliwić zweryfikowanie poprawności wykonania zadania
            Console.WriteLine($"Przy dokładności: {String.Format("{0:N20}",epsilon)}");
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
        static double FindZeroPointIter(double a, double b, double epsilon)
        {
            double cpoint = a + ((b - a) / 2);
            while(Math.Abs(FindLog(cpoint)) > epsilon)
            {
                cpoint = a + ((b - a) / 2);
                if (FindLog(cpoint) > 0) b = cpoint;
                if (FindLog(cpoint) < 0) a = cpoint;
            }
            return cpoint;
        }
        static double FindLog(double x)
        {
            
            return (x + Math.Log10(x));
        }
    }
}
