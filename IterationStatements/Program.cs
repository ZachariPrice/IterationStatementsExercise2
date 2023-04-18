using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            //-----START HERE------------------------------------------
            //Create a variable of type int and name it num
            //initialize the variable with a value of 0
            var myNumber = 0;


            // Create a do-while loop and use the template below:
            do
            {
                myNumber++;

                numbers.Add(myNumber);
            } while (myNumber < 100);// <---- While your variable is less than 100

            while (myNumber < 200)
            {
                myNumber++;
                numbers.Add(myNumber);
            }

            Console.WriteLine("Increase:");

            foreach (var item in numbers)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("");
            Console.WriteLine("Decrease");

            for (int i = 199; i <= numbers.Count && i >= 0; i--)

            {
                Console.WriteLine($"{numbers[i]}");
            }





        }
    }
}
