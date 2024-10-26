using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise5_1
{
    internal class Program
    {
        static void GetName(ref string name)
        {
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();
        }

        static int ShangeAge(int age)
        {
            age = age + 10;
            return age;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            ShangeAge(age);

            Console.WriteLine(age);

            string name = Console.ReadLine();
            GetName(ref name);
            Console.WriteLine(name);

            Console.ReadKey();
        }
    }
}
