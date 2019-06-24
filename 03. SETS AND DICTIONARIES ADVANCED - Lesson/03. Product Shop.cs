using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Revision")
                {
                    break;
                }

                List<string> inputInfo = input.Split(", ").ToList();

                string shop = inputInfo[0];

                string product = inputInfo[1];

                double price = double.Parse(inputInfo[2]);

                if (shops.ContainsKey(shop))
                {
                    if (shops[shop].ContainsKey(product))
                    {
                        shops[shop][product] = price;
                    }
                    else
                    {
                        shops[shop].Add(product, price);
                    }
                }
                else
                {
                    Dictionary<string, double> currentShop = new Dictionary<string, double>();

                    currentShop.Add(product,price);

                    shops.Add(shop, currentShop);
                }
            }

            var sortedShops = shops.OrderBy(x => x.Key);

            foreach(var shop in sortedShops)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach(var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {(product.Value)}");
                }
            }
        }
    }
}
