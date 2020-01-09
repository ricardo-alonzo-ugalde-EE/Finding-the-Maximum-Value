using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Vide_69_Finding_Maximum_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(); // creates a new list named numbers
            BuildList(numbers); // populates our list with random numbers
            Display(numbers); // displays the populated list
            Console.WriteLine(); // space
            Console.WriteLine("The maximum value is " + numbers[Maximum(numbers)]); // used max function to display max value
        }
        static void Display(List<int> lyst) // Displays the random number generators and adds a space every 5th line
        {
            for (int i = 0; i < lyst.Count; ++i)
            {
                if (i % 25 == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(lyst[i] + " ");
                }
            }
        }
        static void BuildList(List<int> lyst) // This method populates our list with random numbers using .Next method
        {
            Random rand = new Random();
            for (int i = 0; i < 100; ++i)
            {
                lyst.Add(rand.Next(1, 101));
            }
        }
        static int Maximum(List<int> lyst) // looks for larges number in lyst and assigns it to variable max
        {
            int max = 0;
            for (int i = 1; i < lyst.Count; ++i)
            {
                if (lyst[i] > lyst[max])
                {
                    max = i;
                }
            }
            return max;

        }

    }
}
