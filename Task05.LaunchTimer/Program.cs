using System;

namespace Task05.LaunchTimer
{
    class Program
    {
        static void Main()
        {
            Console.Write("Секунды до старта: ");
            int s = int.Parse(Console.ReadLine());

            int days = s / 86400;
            int hours = s % 86400 / 3600;
            int minutes = s % 3600 / 60;
            int seconds = s % 60;

            Console.WriteLine(days + " д. " + hours + " ч. " + minutes + " мин. " + seconds + " с.");
            Console.ReadLine();
        }
    }
}
