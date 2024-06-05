using System.Linq;
using System.Security.Cryptography;

class pally
{ 
    static void Main()
    {
        Console.WriteLine("Give me a work and Ill check if its a palindrome");
        string word = Console.ReadLine();
        string lowercase = word.ToLower();
        if (isPalindrome(lowercase))
        {
            Console.WriteLine("its a palindrome");
        }
        
        else { Console.WriteLine("not a palindrome"); }
    }

    static bool isPalindrome(string Pally)
    {
        return Pally.SequenceEqual(Pally.Reverse());
    }
}
