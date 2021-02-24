using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Assignment2._2
{
    class Program
    {
        public static Dictionary<string, PrimeMinister> pm=new Dictionary<string, PrimeMinister>();

        static void Main(string[] args)
        {
            initializeDictionary();

            Console.WriteLine("\nList of Prime Ministers");
            var pmRead = new ReadOnlyDictionary<String, PrimeMinister>(pm);
            foreach (var v in pmRead.Values)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("\nPrimeMinister of 2004");
            foreach (var v in pm.Values)
            {
                if(v.year.Equals("2004"))
                {
                    Console.WriteLine(v);
                    break;
                }
            }

            Console.WriteLine("\nAfter Adding current PrimeMinister in Dictionary:");
            pm["fourth"]=new PrimeMinister("Narendra Modi","2021");
            foreach (var v in pm.Values)
            {
                Console.WriteLine(v);
            }
            
            Console.WriteLine("\nSorted Dictionary by Year:");
            pm = pm.OrderBy(x => x.Value.year).ToDictionary(y => y.Key, y => y.Value);
            foreach (var v in pm.Values)
            {
                Console.WriteLine(v);
            }
        }

        private static void initializeDictionary()
        {
            pm.Add("one", new PrimeMinister("Atal Bihari Vajpayee","1998"));
            pm.Add("two", new PrimeMinister("Narendra Modi","2014"));
            pm.Add("three", new PrimeMinister("Manmohan Singh","2004"));
        }
    }
}
