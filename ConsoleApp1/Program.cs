


namespace oddchecker
{
    class oddcheck
    {
        static void Main()
        {
            Console.WriteLine("Gimme a numba");
            string integer = Console.ReadLine();
            int number;
            if (int.TryParse(integer, out number))
            {
                if (isEven(number))
                {
                    Console.WriteLine("Huzzah Even");
                }
                else if (isodd(number))
                {
                    Console.WriteLine("Strange Odd number");
                }
              
            }
                
        }

        static bool isEven(int x)
        {
            return (x % 2 == 0);
        }

        static bool isodd(int y)
        {
            return y % 2 == 1;
        }
    }
}
