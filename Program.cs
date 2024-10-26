using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise5_1
{
    internal class Program
    {
        static string ShowColor(string userName, int userAge)
        {
            Console.WriteLine(userName + ", " + userAge + "\n Введите свой любимый цвет: ");
            string color = Console.ReadLine().ToLower();
            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine($"Your color is {color}!");
                    break;
            }
            return color;
        }
        static void Main(string[] args)
        {
            var (name, age) = ("Алена", 18);
            Console.WriteLine("Моё имя: " + name + "\n" + "Мой возраст: " + age);

            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.WriteLine("Введите возраст: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваше имя: " + name + " \n" + "Ваш возраст: " + age);

            string[] favColors = new string[3];
            for (int i = 0; i < 3; i++)
            {
                favColors[i] = ShowColor(name, age);
                Console.WriteLine(favColors[i]);
            }

            Console.WriteLine("Три ваших любимых цвета: ");
            foreach (var i in favColors)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
