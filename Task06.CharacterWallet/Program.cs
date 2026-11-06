using System;

namespace Task06.CharacterWallet
{
    class Program
    {
        static void Main()
        {
            Console.Write("Золотые монеты: ");
            int gold = int.Parse(Console.ReadLine());

            Console.Write("Серебряные монеты: ");
            int silver = int.Parse(Console.ReadLine());

            Console.Write("Медные монеты: ");
            int copper = int.Parse(Console.ReadLine());

            Console.Write("Стоимость покупки в медных: ");
            int price = int.Parse(Console.ReadLine());

            int total = (gold * 100 + silver) * 100 + copper;
            int rest = total - price;

            int restGold = rest / 10000;
            int restSilver = rest % 10000 / 100;
            int restCopper = rest % 100;

            Console.WriteLine("Остаток: " + restGold + " золотых, " + restSilver + " серебряных, " + restCopper + " медных");
            Console.ReadLine();
        }
    }
}
