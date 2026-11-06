using System;

namespace Task02.ElectronicLock
{
    class Program
    {
        static void Main()
        {
            const int PIN = 4271;
            bool open = false;

            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Введите PIN: ");
                int pin = int.Parse(Console.ReadLine());

                if (pin == 0)
                {
                    Console.WriteLine("Вход отменён");
                    Console.ReadLine();
                    return;
                }

                if (pin == PIN)
                {
                    Console.WriteLine("Замок открыт");
                    open = true;
                    break;
                }

                Console.WriteLine("Неверный PIN. Осталось попыток: " + (3 - i));
            }

            if (!open)
            {
                Console.WriteLine("Замок заблокирован");
            }

            Console.ReadLine();
        }
    }
}
