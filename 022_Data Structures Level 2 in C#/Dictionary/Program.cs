using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    /// <summary>
    /// Dictionary is a collection of key-value pairs that provides fast retrieval based on the key.
    /// It is part of the System.Collections.Generic namespace and is widely used in situations where quick lookups are necessary.
    /// </summary>
    internal class Program
    {
        public static void WorkingWithDictionary()
        {
            // Creating the dictionary
            Dictionary<string, int> fruitBasket = new Dictionary<string, int>();


            // Adding elements
            fruitBasket.Add("Apple", 5);
            fruitBasket.Add("Banana", 2);
            //the following commented line will casue an error because they key is repeated.
            //fruitBasket.Add("Banana", 5);
            fruitBasket.Add("Orange", 12);


            // Accessing and updating elements
            fruitBasket["Apple"] = 10;


            Console.WriteLine("\nDictionary Content:");
            // Iterating through the dictionary
            foreach (KeyValuePair<string, int> item in fruitBasket)
            {
                Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
            }


            // Removing an element
            fruitBasket.Remove("Banana");

            Console.WriteLine("\nDictionary Content after removing Banana:");
            // Iterating through the dictionary after removing Banana
            foreach (KeyValuePair<string, int> item in fruitBasket)
            {
                Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
            }
        }

        public static void TryGetValueMethod()
        {
            // Creating and initializing the dictionary
            Dictionary<string, int> fruitBasket = new Dictionary<string, int>
        {
            { "Apple", 5 },
            { "Banana", 2 }
        };


            // Using TryGetValue
            if (fruitBasket.TryGetValue("Apple", out int appleQuantity))
            {
                Console.WriteLine($"Apple quantity: {appleQuantity}");
            }
            else
            {
                Console.WriteLine("Apple not found in the basket.");
            }


            //the following line will make exception error because orange is not there.
            // Console.WriteLine($"Orange quantity: {fruitBasket["Orange"]}");


            // Using TryGetValue
            if (fruitBasket.TryGetValue("Orange", out int OrangeQuantity))
            {
                Console.WriteLine($"Orange quantity: {OrangeQuantity}");
            }
            else
            {
                Console.WriteLine("Orange not found in the basket.");
            }

        }

        static void LinqWithDictionary()
        {
            // Creating and initializing the dictionary
            Dictionary<string, int> fruitBasket = new Dictionary<string, int>
        {
            { "Apple", 5 },
            { "Banana", 2 },
            { "Orange", 7 }
        };


            // Using LINQ to transform items
            var fruitInfo = fruitBasket.Select(kpv => new { kpv.Key, kpv.Value });


            // Displaying the results
            Console.WriteLine("\nTransformed Items:");
            foreach (var item in fruitInfo)
            {
                Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
            }

            // Selecting keys
            var keys = fruitBasket.Select(pair => pair.Key);
            // keys will be: { "Apple", "Banana", "Orange" }

            Console.WriteLine("\nFruit Names:");
            foreach (var item in keys)
            {
                Console.WriteLine($"Fruit: {item}");
            }

            // Selecting values
            var values = fruitBasket.Select(pair => pair.Value);
            // values will be: { 5, 2, 7 }
            Console.WriteLine("\nFruit Values:");
            foreach (var item in values)
            {
                Console.WriteLine($"Fruit: {item}");
            }

            // Combining key and value into a single object
            var combinedData = fruitBasket.Select(pair => $"{pair.Key}: {pair.Value}");
            // combinedData will be a collection of strings representing key-value pairs
            Console.WriteLine("\ncombined Data:");
            foreach (var item in combinedData)
            {
                Console.WriteLine($"Fruit: {item}");
            }

            // Calculating derived data (e.g., doubling the value)
            var doubledValues = fruitBasket.Select(pair => new KeyValuePair<string, int>(pair.Key, pair.Value * 2));
            // doubledValues will be a new dictionary with the same keys but doubled values
            Console.WriteLine("\ndoubled Values:");
            foreach (var item in doubledValues)
            {
                Console.WriteLine($"Fruit: {item.Key} : {item.Value}");
            }


            // Using LINQ to filter items
            var filteredFruit = fruitBasket.Where(kpv => kpv.Value > 3);


            Console.WriteLine("\nFiltered Items >3:");
            foreach (var item in filteredFruit)
            {
                Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
            }

            // Using LINQ to sort by value
            var sortedByQuantity = fruitBasket.OrderBy(kpv => kpv.Value);


            Console.WriteLine("\nSorted Items:");
            foreach (var item in sortedByQuantity)
            {
                Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
            }


            // Using LINQ to sort by value
            var sortedByQuantityDesc = fruitBasket.OrderByDescending(kpv => kpv.Value);


            Console.WriteLine("\nSorted Items Desc:");
            foreach (var item in sortedByQuantityDesc)
            {
                Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
            }

            // Using LINQ to sort items by quantity according the length of the key (fruit name)
            var sortedByQuantity2 = fruitBasket.OrderBy(kvp => kvp.Key.Length);

            Console.WriteLine("\nSorted Items (Ascending Order according the length of the key (fruit name)):");
            foreach (var item in sortedByQuantity2)
            {
                Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
            }

            // Using LINQ to aggregate data
            int totalQuantity = fruitBasket.Sum(kpv => kpv.Value);

            Console.WriteLine($"\nTotal Quantity: {totalQuantity}");
        }

        static void AdvancedLinqWithDictionary()
        {
            // Dictionary for grouping
            Dictionary<string, string> fruitsCategory = new Dictionary<string, string>
        {
            { "Apple", "Tree" },
            { "Banana", "Herb" },
            { "Cherry", "Tree" },
            { "Strawberry", "Bush" },
            { "Raspberry", "Bush" }
        };


            // Grouping fruits by category
            var groupedFruits = fruitsCategory.GroupBy(kpv => kpv.Value);
            foreach (var group in groupedFruits)
            {
                Console.WriteLine($"Category: {group.Key}");
                foreach (var fruit in group)
                {
                    Console.WriteLine($" - {fruit.Key}");
                }
            }


            // Another Dictionary for combined queries
            Dictionary<string, int> fruitBasket = new Dictionary<string, int>
        {
            { "Apple", 5 },
            { "Banana", 2 },
            { "Orange", 7 }
        };


            // Combined LINQ queries
            var sortedFilteredFruits = fruitBasket
                .Where(kpv => kpv.Value > 3)
                .OrderBy(kpv => kpv.Key)
                .Select(kpv => new { kpv.Key, kpv.Value });

            Console.WriteLine("\nSorted and Filtered Fruits:");
            foreach (var fruit in sortedFilteredFruits)
            {
                Console.WriteLine($"Fruit: {fruit.Key}, Quantity: {fruit.Value}");
            }

        }

        static void Main(string[] args)
        {
            // WorkingWithDictionary();
            //   TryGetValueMethod();
            // LinqWithDictionary();
            AdvancedLinqWithDictionary();

            Console.ReadKey();
        }
    }
}
