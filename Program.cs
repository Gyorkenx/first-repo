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

        }
    }
}
