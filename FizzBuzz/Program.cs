using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Please enter a number: ");

            while (true)
            {
                string girdi = Console.ReadLine();
                if (int.TryParse(girdi, out number))
                {
                    Console.WriteLine("Conversion is succesfull");
                    break;
                }
                else
                {
                    Console.WriteLine("Conversion is fail");
                }
            }

            for (int i = 1; i <= number; i++)
            {
                if (i % 15 == 0)
                {
                    Console.Write("FizzBuzz ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz ");
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}