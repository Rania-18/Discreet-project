using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {static bool prime(int num)
        {for (int i = 2; i < num; i++)
                if (num % i == 0) return false;
            return true;
   }
        
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the first number");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the sesond numer");
            int n2 = int.Parse(Console.ReadLine());
            for (int n1 = y; n1 < n2; ++n1)
            { if(prime(n1))       
                    Console.WriteLine(n1);

            }
            Console.ReadKey();
        
           
            
        }
    }
}
