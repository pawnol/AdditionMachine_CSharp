/*
 * Addition Machine
 * Pawelski
 * 1/11/2022
 * Read the code and run the program a few times to see what it does. 
 * Once you are familiar with the program, answer the questions found 
 * on the activity sheet.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string response = "Y";
            while (response == "Y")
            {
                double num1, num2, result;
                Console.Write("Enter a number >> ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter another number >> ");
                num2 = Convert.ToDouble(Console.ReadLine());
                result = num1 + num2;
                Console.WriteLine(result);

                Console.Write("Do you want to add two more numbers? (Y/N) >> ");
                response = Console.ReadLine();
            }
        }
    }
}
