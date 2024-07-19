using System;
using System.Linq;

namespace sortarray
{
    class sort
    {
        static void Main()
        {
            int[] randomnumbers = GenerateRandomNumbers(50, 1, 100);
            int[] sorrtedarray = sortarray(randomnumbers);
            Console.WriteLine("Random Numbers:");
            foreach (int number in randomnumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nSorted Numbers:");
            foreach(int number in sorrtedarray)
            {
                Console.WriteLine(number);
            }
        }

        static int[] GenerateRandomNumbers(int count, int min, int max)
        {
            Random rand = new Random();
            return Enumerable.Range(0,count).Select(_ => rand.Next(min, max + 1)).ToArray();

        }

        static int[] sortarray(int[] array)
        {
            return array.OrderBy(x => x).ToArray();
        }

    }

}