using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
            string names=Console.ReadLine();
            Regex maching = new Regex(pattern);
            MatchCollection maches = maching.Matches(names);
            foreach (Match name in maches)
            {
                Console.Write($"{name.Value} ");
            }

        }
    }
}
