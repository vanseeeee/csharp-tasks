using System;

namespace Task01.TariffDuel
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите количество часов (0-100): ");
            int hours = int.Parse(Console.ReadLine());

            int free = hours * 80;
            int pass = hours == 0 ? 0 : 300 + Math.Max(0, hours - 5) * 50;

            Console.WriteLine("Свободный: " + free + " руб.");
            Console.WriteLine("Абонемент: " + pass + " руб.");

            int min = free < pass ? free : pass;
            Console.WriteLine("Минимальная стоимость: " + min + " руб.");

            if (free == pass)
            {
                Console.WriteLine("Цены равны");
            }
            else if (free < pass)
            {
                Console.WriteLine("Дешевле Свободный");
            }
            else
            {
                Console.WriteLine("Дешевле Абонемент");
            }

            Console.ReadLine();
        }
    }
}
