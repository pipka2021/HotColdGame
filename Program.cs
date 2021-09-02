using System;
using System.Threading;

namespace ефеф
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;

            do // загадка числа
            {
                Console.Write("Input:");
                if (!Int32.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Опс.. Что-то пошло не так. Загадайте число ещё раз");
                }
                else
                {
                    if (a > 100)
                    {
                        Console.WriteLine($"Нельзя загадывать число больше 100");
                    }
                    else
                    {
                        Console.WriteLine($"Вы загадали число: {a}\nЭкран очистится через 2 секунду");
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    }
                }

            } while (true);
            Console.WriteLine($"!Загаданное число не больше 100!");

            do //игра
            {
                //
                // Такой стиль из-за того, что я пишу на c++ около 3-х лет
                //
                int b;
                Console.Write("Player: ");
                if (!Int32.TryParse(Console.ReadLine(), out b)) { Console.WriteLine("Game: Вы ввели не число."); }
                else
                {
                    string out_s = (b > a) ? "Бери меньше" : "Бери больше";

                    if (b == a)
                    {
                        Console.WriteLine("Вы выйграли!");
                        break;
                    }
                    else if ((b - 5 <= a && b > a) || (b + 5 >= a && b < a))
                    {
                        Console.WriteLine($"Game: Очень горячо.\t{out_s}");
                        
                    }
                    else if ((b - 10 <= a && b > a) || (b + 10 >= a && b < a))
                    { 
                        Console.WriteLine($"Game: Горячо.\t\t{out_s}"); 
                    }
                    else
                    { 
                        Console.WriteLine($"Game: Холодно.\t\t{out_s}"); 
                    }
                }

            } while (true);

            
        }

    }
}
