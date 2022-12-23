using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
        
    {
        static bool perfect(int num)
        {
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                    sum = sum + i;
            }
            if (sum == num) return true;
            return false;

        }



        static void Main(string[] args)
        {
            Console.WriteLine("please enter the first number");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the second number");
            int n2 = int.Parse(Console.ReadLine());
            for (int n1 = i; n1 <= n2; n1++)
                if (perfect(n1)) Console.WriteLine(n1)  ;
            Console.ReadKey();

        }
    }
}
