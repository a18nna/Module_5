using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string name, string[] dishes) User;
            Console.WriteLine("Введите имя пользователя: ");
            User.name = Console.ReadLine();
            User.dishes = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Введите любимое блюдо номер {i + 1}: ");
                User.dishes[i] = Console.ReadLine();
            }
        }
    }
}
