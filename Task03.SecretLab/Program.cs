using System;

namespace Task03.SecretLab
{
    class Program
    {
        static void Main()
        {
            Console.Write("Возраст: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Есть пропуск (true/false): ");
            bool pass = bool.Parse(Console.ReadLine());

            Console.Write("Есть сопровождение (true/false): ");
            bool escort = bool.Parse(Console.ReadLine());

            if ((age >= 18 && pass) || (age >= 14 && age <= 17 && pass && escort))
            {
                Console.WriteLine("Доступ разрешён");
            }
            else if (age < 14)
            {
                Console.WriteLine("Доступ запрещён. Причина: недостаточный возраст");
            }
            else if (!pass)
            {
                Console.WriteLine("Доступ запрещён. Причина: отсутствие пропуска");
            }
            else
            {
                Console.WriteLine("Доступ запрещён. Причина: отсутствие сопровождения");
            }

            Console.ReadLine();
        }
    }
}
