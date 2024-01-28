using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_KiemTraSoNguyenTo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Number: ");
            int N = int.Parse(Console.ReadLine());
            
            if (N < 2)
            {
                Console.WriteLine(N + " is not a prime");
            }
            
            else
            {
                int i = 2;
                bool check = true;
                
                while (i <= Math.Sqrt(N))
                {
                    if (N%i==0)
                    { 
                        check = false;
                        break;
                    }
                    i++;
                }
                if (check)
                {
                    Console.WriteLine(N + " is a prime");
                }
                else
                {
                    Console.WriteLine(N + " is not a prime");
                }
            }

            Console.ReadKey();

        }
    }
}
