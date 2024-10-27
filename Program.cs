using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise5_1
{
    internal class Program
    {
        private static int PowerUp(int N, byte pow)
        {
            if (pow == 0)
            {
                return 1;
            }
            else if(pow == 1)
            {
                return N;
            }
            else
            {
                return N * PowerUp(N, --pow);
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine(PowerUp(5, 3));

            Console.ReadKey();
        }
    }
}
