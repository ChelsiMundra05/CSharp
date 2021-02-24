using System;
using System.Collections.Generic;

namespace Assignment2._1
{
    class Program
    {
        private static List<Product> productList =new List<Product>();

        static void Main(string[] args)
        {
            ProductList();
            Console.WriteLine("\nTotal Number of Products: "+productList.Count);
            
            Console.WriteLine("\nAfter Adding a new product 'Potato' ");
            productList.Add(new Product("Potato",10,50,"Root"));
            Console.WriteLine("List of all Products:");
            printProducts(productList);
            Console.WriteLine("Total Number of Products: "+productList.Count);

            List<Product> product=productList.FindAll(printProducts => printProducts.Type.ToLower() == "leafygreen");
            Console.WriteLine("\nProducts having type 'Leafy Green': ");
            printProducts(product);

            productList.RemoveAll(p => p.Name == "garlic");
            Console.WriteLine("\nTotal Products after removing garlic:"+productList.Count);
            
            Console.WriteLine("\nAfter Adding 50 'Cabbages' ");
            Product cabbage=productList.Find(p => p.Name.ToLower()=="cabbage");
            Console.WriteLine("Total cabbages:"+(cabbage.Quantity+50));

            Console.WriteLine("\nUser Purchases 1Kg Lettuce, 2Kg zucchini, 1Kg broccoli.");
            double amount = calculateAmount();
            Console.WriteLine("Total Amount user needs to pay:"+Math.Round(amount)+"RS");
        }

        private static void ProductList()
        {
            productList.Add(new Product("lettuce",10.5,50,"Leafy green"));
            productList.Add(new Product("cabbage",20,100,"Cruciferous"));
            productList.Add(new Product("pumpkin",30,30,"Marrow"));
            productList.Add(new Product("cauliflower",10,25,"Cruciferous"));
            productList.Add(new Product("zucchini",20.5,50,"Marrow"));
            productList.Add(new Product("yam",30,50,"Root"));
            productList.Add(new Product("spinach",10,100,"Leafy green"));
            productList.Add(new Product("broccoli",20.2,75,"Cruciferous"));
            productList.Add(new Product("garlic",30,20,"Leafy green"));
            productList.Add(new Product("silverbeet",10,50,"Marrow"));
        }
        private static void printProducts(List<Product> productList)
        {
            Console.WriteLine("");
            foreach (var product in productList)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine("");
        }

        private static double calculateAmount()
        {
            double amt=0;
            
            Product lettuce=productList.Find(p =>p.Name.ToLower()=="lettuce");
            Product zucchini=productList.Find(p =>p.Name.ToLower()=="zucchini");
            Product broccoli=productList.Find(p =>p.Name.ToLower()=="broccoli");

            amt=lettuce.Price+(2*zucchini.Price)+broccoli.Price;

            return amt;
            
        }
    }
}
