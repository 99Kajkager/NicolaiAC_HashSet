using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CS_Using_HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Section 1&2
            // Array of strings named names
            string[] names =
            {
                "sigma",
                "nicolai",
                "petergriffin",
                "michael",
                "john",
                "shrek",
                "sigma"
            };
            
            // Length of array and printing array
            Console.WriteLine("Array length: " + names.Length);
            Console.WriteLine();
            Console.WriteLine("The data in the array: ");

            // Prints each array index
            foreach (var n in names)
            {
                Console.WriteLine(n);
            }
            
            Console.WriteLine();
            
            HashSet<string> hashSet = new HashSet<string>(names);
            
            Console.WriteLine("Amount of data in the hash set: " + hashSet.Count);
            Console.WriteLine();
            
            // Printing Data
            Console.WriteLine("The data in the hashset: ");
            foreach (var n in hashSet)
            {
                Console.WriteLine(n);
            }

            // Console.ReadLine();
            // Section 3

            string[] names1 =
            {
                "mickey",
                "goofy",
                "donald",
                "aladdin",
                "genie",
                "simba",
                "mufasa"
            };

            string[] names2 =
            {
                "nidoking", 
                "mewtwo", 
                "kyurem", 
                "reshiram", 
                "zekrom", 
                "magikarp"
            };
            
            HashSet<string> hashSet1 = new HashSet<string>(names1);
            
            Console.WriteLine("Data in hash set 1: ");
            foreach (var n in hashSet1)
            {
                Console.WriteLine(n);
            }
            
            HashSet<string> hashSet2 = new HashSet<string>(names2);
            
            Console.WriteLine("Data in hash set 2: ");
            foreach (var n in hashSet2)
            {
                Console.WriteLine(n);
            }
            
            Console.WriteLine("Data after Union: ");
            hashSet1.UnionWith(hashSet2);
            foreach (var n in hashSet1)
            {
                Console.WriteLine(n);
            }
            
            // Section 4
            Console.WriteLine("Data before using ExceptWith: ");
            HashSet<string> hashSet3 = new HashSet<string>(names1);
            foreach (var n in hashSet3)
            {
                Console.WriteLine(n);
            }
            
            Console.WriteLine("Data after using ExceptWith: ");
            // doesn't actually remove anything because no matching names
            hashSet1.ExceptWith(hashSet2);
            foreach (var n in hashSet3)
            {
                Console.WriteLine(n);
            }
            
            // Section 5
            HashSet< string > hashSet4 = new HashSet<string>(names1);
            
            Console.WriteLine("Elements before using SymmetricExceptWith: ");
            foreach (var n in hashSet4)
            {
                Console.WriteLine(n);
            }

            foreach (var n in hashSet2)
            {
                Console.WriteLine(n);
            }
            
            Console.WriteLine("Data after using SymmetricExceptWith: ");
            
            hashSet4.SymmetricExceptWith(hashSet2);
            foreach (var n in hashSet4)
            {
                Console.WriteLine(n);
            }
            
            // Section 6
            string[] lotsOfNames =
                {
                "Bulbasaur", "Ivysaur", "Venusaur", "Charmander", "Charmeleon", "Charizard",
                "Squirtle", "Wartortle", "Blastoise", "Caterpie", "Metapod", "Butterfree",
                "Weedle", "Kakuna", "Beedrill", "Pidgey", "Pidgeotto", "Pidgeot",
                "Rattata", "Raticate", "Spearow", "Fearow", "Ekans", "Arbok",
                "Pikachu", "Raichu", "Sandshrew", "Sandslash", "Nidoran♀", "Nidorina",
                "Nidoqueen", "Nidoran♂", "Nidorino", "Nidoking", "Clefairy", "Clefable",
                "Vulpix", "Ninetales", "Jigglypuff", "Wigglytuff", "Zubat", "Golbat",
                "Oddish", "Gloom", "Vileplume", "Paras", "Parasect", "Venonat",
                "Venomoth", "Diglett", "Dugtrio"
            };
            
            Console.WriteLine("List performance while adding item: ");
            List<string> list = new List<string>();
            var s2 = Stopwatch.StartNew();
            foreach (string s in lotsOfNames)
            {
                list.Add(s);
            }

            s2.Stop();
            Console.WriteLine(s2.Elapsed.TotalMilliseconds.ToString("0.000ms s2"));
            
            HashSet<string> hStringNames = new HashSet<string>(StringComparer.Ordinal);
            var s1 = Stopwatch.StartNew();
            foreach (string s in lotsOfNames)
            {
                hStringNames.Add(s);
            }
            s1.Stop();
            
            Console.WriteLine(s1.Elapsed.TotalMilliseconds.ToString("0.000ms s1"));
        }
        
        // s2 is significantly faster than s1.
        // A list needs to iterate through every element, while a hashset does not
        // foreach is slower on hashset because there is no specific order within the hashset
        // - this has to be assigned
    }
}