using System;
using System.Collections.Generic;
using System.Text;

namespace BrainTeasersTraining.CompareValues
{

    //Write a C# Sharp program to compute the sum of the two given integer values.
    //If the two values are the same, then return triple their sum
    class CompareRun
    {

        public void CompareNumber()
        {
    
            int number1 = 0;
            int number2 = 0;
            string num = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Give me first proper number.");
                num = Console.ReadLine();

            } while (!Int32.TryParse(num, out number1));

            do
            {
                Console.Clear();
                Console.WriteLine("Give me second proper number.");
                num = Console.ReadLine();

            } while (!Int32.TryParse(num, out number2));

            Console.Write("The output is:");
            Console.WriteLine(number1 == number2 ? (number1 + number2) * 3 : (number1 + number2));
            Console.ReadKey();
       }
        
        
    }
}
