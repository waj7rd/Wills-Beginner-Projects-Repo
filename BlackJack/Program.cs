using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

class BlackJack
{

    public static int ScoreGetter(char[] cards)
    {
        int[] valarray = { };
        int value = 0;


        foreach (char c in cards)
        {
            if (c == 'A')
            {
                value = 11;
                Array.Resize(ref valarray, valarray.Length + 1);
                valarray[valarray.Length - 1] = value;
            }
            else if (c == 'T')
            {
                value = 10;
                Array.Resize(ref valarray, valarray.Length + 1);
                valarray[valarray.Length - 1] = value;
            }
            else if (c == 'J')
            {
                value = 10;
                Array.Resize(ref valarray, valarray.Length + 1);
                valarray[valarray.Length - 1] = value;
            }
            else if (c == 'Q')
            {
                value = 10;
                Array.Resize(ref valarray, valarray.Length + 1);
                valarray[valarray.Length - 1] = value;
            }
            else if (c == 'K')
            {
                value = 10;
                Array.Resize(ref valarray, valarray.Length + 1);
                valarray[valarray.Length - 1] = value;
            }
            else
            {
                value = c - '0';
                Array.Resize(ref valarray, valarray.Length + 1);
                valarray[valarray.Length - 1] = value;
            }
        }
        int sum = valarray.Sum();
        return sum;
    }   
    
    public static void Main()
    {
        char[] deck = { 'A', '2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K',
                        'A', '2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K',
                        'A', '2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K',
                        'A', '2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K'};

        int dealerscore = 0;
        Random cardrand = new Random();
        int card1 = cardrand.Next(1, deck.Length);
        int card2 = cardrand.Next(1, deck.Length);
        int card3 = cardrand.Next(1, deck.Length);

        char[] dealercards = { deck[card3] };
        char[] playercards = { deck[card1], deck[card2] };
        Console.WriteLine("Dealer Cards");
        Console.WriteLine(dealercards[0] + " [] ");
        Console.WriteLine("Player Cards");
        Console.WriteLine($"{playercards[0]}   {playercards[1]}");
        Console.WriteLine("What do you want to do? 1. HIT 2. STAND ");
        int select= int.Parse( Console.ReadLine() );
        while( select != 2)
        {
            Console.Clear();
            Console.WriteLine("What do you want to do? 1. HIT 2. STAND");
            Console.WriteLine("Dealer Cards");
            Console.WriteLine(dealercards[0] + " [] ");
            int cardadd = cardrand.Next(1, deck.Length);
            Array.Resize(ref playercards, playercards.Length + 1);
            playercards[playercards.Length - 1] = deck[cardadd];
            Console.WriteLine("Player Cards");
            foreach(char cards in playercards)
            {
                Console.Write(cards +  "   ");
            }
            int playerscore = BlackJack.ScoreGetter(playercards);
            Console.WriteLine($"Player Score:   {playerscore}");
            if (playerscore > 21 && playercards.Contains('A'))
            {
                playerscore = playerscore - 10;
                if (playerscore > 21)
                {
                    Console.WriteLine("BUST YOU LOST");
                }
            }  
            if (playerscore > 21) 
            {
                Console.WriteLine("BUST YOU LOST");
                Environment.Exit(0);
            }
            if(playerscore == 21 && playercards.Length == 2)
            {
                Console.WriteLine("BlackJack");
                Environment.Exit(0);
            }
        select = int.Parse(Console.ReadLine());

        }
        while (select == 2 || dealerscore >= 17)
        {
            {
                Console.Clear();
                int card4 = cardrand.Next(1, deck.Length);
                Array.Resize(ref dealercards, dealercards.Length + 1);
                dealercards[dealercards.Length - 1] = deck[card4];
                Console.WriteLine("Dealer Cards");
                foreach (char c in dealercards)
                {
                    Console.Write(c + "   ");
                }
                dealerscore = BlackJack.ScoreGetter(dealercards);
                Console.WriteLine($"\t\tDealerScore:   {dealerscore}");
                Console.WriteLine("Player Cards");
                foreach (char cards in playercards)
                {
                    Console.Write(cards + "   ");
                }
                int playerscore = BlackJack.ScoreGetter(playercards);
                Console.WriteLine($"\t\tPlayer Score:   {playerscore}");

                if (dealerscore >= 17)
                {
                    if (dealerscore >= 22 && dealercards.Contains('A'))
                    {
                        dealerscore = dealerscore - 10;

                        if (dealerscore == playerscore)
                        {
                            Console.WriteLine("DRAW");
                            Environment.Exit(0);
                        }
                        if (dealerscore > playerscore && dealerscore < 22)
                        {
                            Console.WriteLine("DEALER WIN");
                            Environment.Exit(0);
                        }
                        if (dealerscore > 21 || playerscore > dealerscore && playerscore < 22)
                        {
                            Console.WriteLine("YOU WON");
                            Environment.Exit(0);
                        }
                    }


                    if (dealerscore == playerscore)
                    {
                        Console.WriteLine("DRAW");
                        Environment.Exit(0);
                    }
                    if (dealerscore > playerscore && dealerscore < 22)
                    {
                        Console.WriteLine("DEALER WIN");
                        Environment.Exit(0);
                    }
                    if (dealerscore > 21 || playerscore > dealerscore && playerscore < 22)
                    {
                        Console.WriteLine("YOU WIN");
                        Environment.Exit(0);
                    }
                break;

                }
                Thread.Sleep(1000);
            }
        }
    }
}