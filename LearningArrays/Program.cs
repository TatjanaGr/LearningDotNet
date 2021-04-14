using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an array of string size 5. 
            string[] words;
            //Fill array items with values.
            words = new string[] { "apple", "banana", "plum", "ananas", "orange" };

            // Print all words using loop.
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
            //Console.ReadKey();
            //Create an int array size 20.Fill values from 0 till 20.
            int[] numbers;
            numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            //Print numbers backwards.
            Array.Reverse(numbers);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
