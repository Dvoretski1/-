using System;

namespace ОАИП
{
    class Program
    {
        static void Main(string[] args)
        {
            Random a = new Random();
            int x = a.Next(100, 1000);

            int b = 0;

            while (b != x)
            {
                Console.WriteLine("Введите переменную b");
                int.TryParse(Console.ReadLine(), out b);

                if (b > x)
                {
                    Console.WriteLine("Много");
                }

                else if (b < x)
                {
                    Console.WriteLine("Мало");
                }

                else
                {
                    Console.WriteLine("Угадал");
                }
            }
        }
    }
}
