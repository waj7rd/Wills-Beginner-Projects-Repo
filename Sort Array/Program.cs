using System;
using System.Linq;

namespace sortarray
{
    class sort
    {

        static void Main()
        {
            Random rand = new Random();
            int[] randomarray = Enumerable.Range(0,100).Select(_ => rand.Next(1,101)).ToArray();

            foreach (int i in randomarray)
            {
                Console.WriteLine(i);
            }
        }

    }

}