using System;

namespace merge

{
    class merger
    {

        static string merge(string s1, string s2)
        {
            string result = "";
            for (int i = 0; i < s1.Length || i < s2.Length; i++)
            {
                if (i < s1.Length)
                    result += s1[i];

                if (i < s2.Length)
                    result += s2[i];

            }

            return result;

        }

        static void Main()
        {
            string s1 = "geeks";
            string s2 = "freaks";
            Console.WriteLine(merge(s1,s2));
        } 
    }
}