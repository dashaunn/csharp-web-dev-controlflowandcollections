using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Lists!");
            
        }
            static int sumEven(List<int> arg)
            {
            int total = 0;
            List<int> numbers = new List<int> {9, 13, 46, 1, 24, 8, 5, 28, 11, 15};
     
                foreach (int integer in numbers) {

                    if (integer % 2 == 0)
                    {
                        total += integer;
                    }
                       Console.WriteLine("Sum = " + total);

            } return total;

        }
    }
}
