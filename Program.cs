using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise5_1
{
    internal class Program
    {
        static int[] GetArrayFromConsole(int num = 5)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }

        static int[] SortArray(int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        static void ShowArray(int[] array, bool IsSort = false)
        {
            var temp = array;
            if (IsSort)
            {
                temp = SortArray(temp);
            }
            foreach (var sort in array)
            {
                Console.WriteLine(sort);
            }
        }

        static void ShowColors(string userName, params string[] favColors)
        {
            Console.WriteLine($"{userName}, ваши любимые цвета: ");
            foreach (var color in favColors)
            {
                Console.WriteLine(color);
            }
        }

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
            int[] array = GetArrayFromConsole(10);
            ShowArray(array, true);

            /*var (name, age) = ("Алена", 18);
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

            ShowColors(name);*/

            Console.ReadKey();
        }
    }
}
