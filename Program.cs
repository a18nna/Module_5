using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise5_1
{
    internal class Program
    {
       static void Echo(string saidworld, int deep)
        {
            var modif = saidworld;
            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
            }
            Console.BackgroundColor = (ConsoleColor)deep;
            Console.WriteLine($"...{modif}");
            if (deep > 1)
            {
                Echo(modif, deep - 1); 
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите что-нибудь: ");
            string saidworld = Console.ReadLine();
            Console.WriteLine("Введите глубину эхо: ");
            int deep = int.Parse(Console.ReadLine());
            Echo(saidworld, deep);

            Console.ReadKey();
        }
    }
}
