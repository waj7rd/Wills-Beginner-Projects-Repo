﻿FizzBuzz(1000);

void FizzBuzz(int number)
{
    for (int i = 1; i <= number; i++)
    {
        if (i % 3 == 0 && i % 5 == 0)
        {
            Console.WriteLine("FizzBuzz");

        }

        else if (i % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }

        else if (i % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(i);
        }
    }
}