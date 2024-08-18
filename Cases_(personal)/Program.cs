using System;
using System.Threading.Channels;
using Microsoft.VisualBasic;

namespace Cases_personal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                main_game();
            }
        }
        static void main_game()
        {
            //Определение редкости
            string common = "Обычный";
            string rare = "Редкий";
            string epic = "Эпический";
            string legendary = "Легендарный";

            //Добовление словаря;
            var rarity = new Dictionary<int,string>
            {
                {1, common},
                {2, rare},
                {3, epic},
                {4, legendary}
            };
            //Этап выбора:
            Console.WriteLine("\t Выберите тип кейса:");
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine($"{i}) {rarity[i]}");
            }
            Console.Write("\nВыш выбор: ");
            int choice = int.Parse(Console.ReadLine());

            //Генерация случайных значений шанса:
            Random random = new Random();
            int chance = random.Next(0,101);

            Console.WriteLine("Chanse: "+ chance);
            switch (choice)
            {
                // Шансы в обычном кейсе:
                case 1:
                    if  (chance < 100 && chance > 40)
                    {
                        Console.WriteLine($"Вы получили {rarity[1]} предмет");
                    }

                    if  (chance < 40 && chance > 20)
                    {
                        Console.WriteLine($"Вы получили {rarity[2]} предмет");
                    }

                    if  (chance< 20 && chance> 5)
                    {
                        Console.WriteLine($"Вы получили {rarity[3]} предмет");
                    }

                    if  (chance < 5 && chance > 0)
                    {
                        Console.WriteLine($"Вы получили {rarity[4]} предмет");
                    }
                break;

                // Шансы в редком кейсе:
                case 2:
                    if  (chance < 50 && chance > 30)
                    {
                        Console.WriteLine($"Вы получили {rarity[1]} предмет");
                    }

                    if  (chance <100 && chance > 50)
                    {
                        Console.WriteLine($"Вы получили {rarity[2]} предмет");
                    }

                    if  (chance< 30 && chance> 10)
                    {
                        Console.WriteLine($"Вы получили {rarity[3]} предмет");
                    }

                    if  (chance < 10 && chance > 0)
                    {
                        Console.WriteLine($"Вы получили {rarity[4]} предмет");
                    }
                    break;

                // Шансы в эпическом кейсе
                case 3:
                    if  (chance < 20 && chance > 30)
                    {
                        Console.WriteLine($"Вы получили {rarity[1]} предмет");
                    }

                    if  (chance < 50 && chance > 20)
                    {
                        Console.WriteLine($"Вы получили {rarity[2]} предмет");
                    }

                    if  (chance< 100 && chance> 50)
                    {
                        Console.WriteLine($"Вы получили {rarity[3]} предмет");
                    }

                    if  (chance < 20 && chance > 1)
                    {
                        Console.WriteLine($"Вы получили {rarity[4]} предмет");
                    }
                break;

                // Шанс в легендарном кейсе
                case 4:
                    if  (chance < 10 && chance > 0)
                    {
                        Console.WriteLine($"Вы получили {rarity[2]} предмет");
                    }

                    if  (chance< 30 && chance> 10)
                    {
                        Console.WriteLine($"Вы получили {rarity[3]} предмет");
                    }

                    if  (chance < 100 && chance > 30)
                    {
                        Console.WriteLine($"Вы получили {rarity[4]} предмет");
                    }
                break;

                //По умолчанию
                default:
                    Console.WriteLine("Указан неизвестный тип кейса.");
                    Console.WriteLine("Пожалуста выберите верный тип занаво");
                break;
            }                  
        } 
    }
}