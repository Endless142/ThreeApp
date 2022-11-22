using System;
using System.Diagnostics;
using System.Runtime.ExceptionServices;

namespace ThreeApp
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Выберите из списка команду\n" +
                "1.Угадай число\n" +
                "2.Таблица умножения(10х10)\n" +
                "3.Вывод делителей числа\n" +
                "4.Выход из программы");
            string chislo = Console.ReadLine();
            do
            {
                if (chislo == "1")
                {
                    ygadayChislo();
                    Console.WriteLine("Выберите из списка команду");
                    chislo = Console.ReadLine();

                }
                if (chislo == "2")
                {
                    tablitza();
                    Console.WriteLine("Выберите из списка команду");
                    chislo = Console.ReadLine();


                }
                if (chislo == "3")
                {
                    deliteli();
                    Console.WriteLine("Выберите из списка команду");
                    chislo = Console.ReadLine();

                }


            } while (chislo != "4");
            Console.WriteLine("Вы вышли из программы");






            static void ygadayChislo()
            {
                Console.WriteLine("Игра - угадай число.");

                Random random = new Random();
                int chislooo = random.Next(0, 100);
                int randomchik = Convert.ToInt32(chislooo);
                string ygadivayou;
                do
                {
                    ygadivayou = Console.ReadLine();
                    if (int.Parse(ygadivayou) > chislooo)
                    {
                        Console.WriteLine("Бери меньше");
                    }
                    if (int.Parse(ygadivayou) < chislooo)
                    {
                        Console.WriteLine("Бери больше");
                    }
                } while (chislooo != int.Parse(ygadivayou));
                Console.WriteLine("Угадал");



            }
            static void deliteli()
            {
                Console.WriteLine("Введите число, для которого хотите найти все делители: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int i = 1;
                while (i <= n)
                {
                    if (n % i == 0)
                    {
                        Console.Write(i + "  ");
                    }
                    i++;
                }
            }
            static void tablitza()
            {
                int[,] tablitzaYmnogenia = new int[11, 11];
                for (int ryad = 1; ryad <= 10; ryad++)
                {
                    for (int stolb = 1; stolb <= 10; stolb++)
                    {
                        tablitzaYmnogenia[ryad, stolb] = (ryad) * (stolb);
                        if (stolb < 11)
                        {
                            Console.Write("\t");
                        }
                        Console.Write(tablitzaYmnogenia[ryad, stolb]);

                    }
                    Console.WriteLine();

                }
            }



        }
    }
}