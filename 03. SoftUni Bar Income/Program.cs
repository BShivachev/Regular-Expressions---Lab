using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\%(?<name>[A-Z]{1}[a-z]+)\%[^$%|.]*?\<(?<product>\w+)\>[^$%|.]*?\|(?<count>\d+)\|[^$%|.]*?(?<price>\d+(\.\d+)?)\$";
            Regex regex = new Regex(pattern);
            string input =Console.ReadLine();
            decimal totalMoney = 0;
            while (!input.Equals("end of shift"))
            {
                Match order = regex.Match(input);
                if (order.Success)
                {
                    string name = order.Groups["name"].Value;
                    string product = order.Groups["product"].Value;
                    int count=int.Parse(order.Groups["count"].Value);
                    decimal price = decimal.Parse(order.Groups["price"].Value);
                    decimal totalPrice = price * count;
                    Console.WriteLine($"{name}: {product} - {totalPrice:f2}");
                    totalMoney += totalPrice;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalMoney:f2}");
        }
    }
}
