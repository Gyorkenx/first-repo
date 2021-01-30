using System;

namespace ConsoleApp1
{
    class Program
    {
        static double timetoseconds(double h, double m, double s)
        {
            double time = h * 3600 + m * 60 + s;
            return time;
        }
        static double timetohours(double h, double m, double s)
        {
            // изчислява и връща времето в часове
            double timeh = h + m / 60 + s / 3600;
            return timeh;
        }
        static double meterstomiles(double meters)
        {
          double miles = meters / 1609;
          return miles;

        }
        static void Main(string[] args)
        {




            Console.WriteLine("Въведете часове:");
            double hour = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете минути:");
            double minutes = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете секунди:");
            double seconds = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете разстояние в  метри:");
            double meters = double.Parse(Console.ReadLine());
            Console.WriteLine(meters / timetoseconds(hour, minutes, seconds));
            Console.WriteLine("Скорост в мили/час:");
            Console.WriteLine(meterstomiles(meters)/timetohours(hour, minutes, seconds);
        }

        
    }
}
