using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Strings!");

            // todo 1: create a string with a value of the long sentence
            string phrase = "I would not, could not, in a box. I would not, could not with a fox.\nI will not eat them in a house. I will not eat them with a mouse.";

            // todo 2: use split method to divide the string at each space and store the individual words in an array.
            //string[] words = phrase.Split(" ");

            //todo 3: print the array of words to verify that your code works
            //Console.WriteLine(string.Join(",", words));

            //todo 4: Repeat steps 2 and 3, but change the delimiter to split the string into separate sentences
            string[] sentences = phrase.Split(".");
            Console.WriteLine(string.Join("\n", sentences));
        }
    }
}
