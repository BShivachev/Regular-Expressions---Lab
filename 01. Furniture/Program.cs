using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[>]{2}(?<name>[A-Za-z]+)[<]{2}(?<price>\d+(\.\d+)?)!(?<quantity>\d+)";
            Regex regex = new Regex(pattern);
            string command =Console.ReadLine();
            List<string> namesOfBougthFurniture=new List<string>();
            decimal totalPrice=0;
            while (!command.Equals("Purchase"))
            {
                Match furnitureInfo=regex.Match(command);
                if (furnitureInfo.Success)
                {
                    string furnName=furnitureInfo.Groups["name"].Value;
                    decimal price = decimal.Parse( furnitureInfo.Groups["price"].Value);
                    int quantity = int.Parse(furnitureInfo.Groups["quantity"].Value);
                    namesOfBougthFurniture.Add(furnName);
                    totalPrice += price * quantity;
                }
               
                command = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");
            foreach (var item in namesOfBougthFurniture)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine(string.Join("\n",namesOfBougthFurniture));
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
