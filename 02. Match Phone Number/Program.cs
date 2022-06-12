using System;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359( |-)2\1[0-9]{3}\1[0-9]{4}\b";
            string numbers = Console.ReadLine();
            Regex regex=new Regex(pattern);
            MatchCollection matchPhones=regex.Matches(numbers);
            Console.WriteLine(string.Join(", ",matchPhones));
        }
    }
}
