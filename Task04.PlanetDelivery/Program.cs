using System;

namespace Task04.PlanetDelivery
{
    class Program
    {
        static void Main()
        {
            Console.Write("Масса груза (1-100 кг): ");
            int weight = int.Parse(Console.ReadLine());

            Console.Write("Срочная доставка (true/false): ");
            bool urgent = bool.Parse(Console.ReadLine());

            int cost;
            if (weight <= 5)
            {
                cost = 300;
            }
            else if (weight <= 20)
            {
                cost = 300 + (weight - 5) * 40;
            }
            else
            {
                cost = 900 + (weight - 20) * 60;
            }

            if (urgent)
            {
                cost = cost * 3 / 2;
            }

            Console.WriteLine("Итоговая цена: " + cost + " кредитов");
            Console.ReadLine();
        }
    }
}
