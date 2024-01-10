using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.If_Statements_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integer to compare");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The max number between "+num1 + " and " + num2 +" Is  " + GetMax(num1, num2));
            Console.Read();

        }

        static int GetMax(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            } else
            {
                return num2;
            }
        }
    }
}
