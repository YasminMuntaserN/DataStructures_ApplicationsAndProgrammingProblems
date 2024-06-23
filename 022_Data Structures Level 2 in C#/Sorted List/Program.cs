using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_List
{
    internal class Program
    {
        /// <summary>
        /// The SortedList is a collection that stores key-value pairs, sorted by the key. 
        /// </summary>
        private static void WorkingWithSortedList()
        {
            SortedList<string, int> sortedList = new SortedList<string, int>
        {
            { "apple", 3 },
            { "Orange", 3 },
            { "banana", 2 }
        };

            // Accessing elements
            Console.WriteLine("\nQuantity of apples: " + sortedList["apple"]);

            Console.WriteLine("\nIterating SortedList Elements:");
            // Iterating through elements
            foreach (var item in sortedList)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            // Removing an element
            sortedList.Remove("apple");

            Console.WriteLine("\nSortedList Elements removing apple:");

            foreach (var item in sortedList)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
        }

        private static void LinqWithSortedList()
        {
            SortedList<int, string> sortedList = new SortedList<int, string>()
        {
            { 1, "One" },
            { 3, "Three" },
            { 2, "Two" },
            { 4, "Four" } // Enhanced dataset for comprehensive output
        };

            // Retrieve keys in sorted order
            List<int> sortedKeys = new List<int>(sortedList.Keys);

            Console.WriteLine(sortedList[sortedKeys[0]]);
            Console.WriteLine(sortedList[sortedKeys[2]]);

            // Query using Query Expression Syntax
            var queryExpressionSyntax = from kvp in sortedList
                                        where kvp.Key > 1
                                        select kvp;

            foreach (var item in queryExpressionSyntax)
            {
                Console.WriteLine($"{item.Key}: {item.Value}"); // Expected: 2, 3, 4
            }

            // Query using Method Syntax
            var methodSyntax = sortedList.Where(kvp => kvp.Key > 1); // Filter keys greater than 1
            Console.WriteLine("\nMethod Syntax Results:");
            foreach (var item in methodSyntax)
            {
                Console.WriteLine($"{item.Key}: {item.Value}"); // Expected: 2, 3, 4
            }

            // Filter key-value pairs with keys greater than a specific value
            int specificValue = 2;
            var filteredByKey = sortedList.Where(kvp => kvp.Key > specificValue); // Filter keys greater than 2
            Console.WriteLine($"\nEntries with keys greater than {specificValue}:");
            foreach (var item in filteredByKey)
            {
                Console.WriteLine($"{item.Key}: {item.Value}"); // Expected: 3, 4
            }
        }

        private static void GroupingElementsWithSortedList()
        {
            // Initialize a SortedList of int keys and string values with fruit names
            SortedList<int, string> sortedList = new SortedList<int, string>()
        {
            { 1, "Apple" },
            { 2, "Banana" },
            { 3, "Cherry" },
            { 4, "Date" },
            { 5, "Grape" },
            { 6, "Fig" },
            { 7, "Elderberry" }
        };

            // Grouping fruits by the length of their names
            Console.WriteLine("Grouping fruits by the length of their names:");
            var groups = sortedList.GroupBy(kvp => kvp.Value.Length);
            foreach (var group in groups)
            {
                Console.WriteLine($"Name Length {group.Key}: {string.Join(", ", group.Select(kvp => kvp.Value))}");
            }


            // Initialize a SortedList of int keys and string values with fruit names
            SortedList<int, string> sortedList2 = new SortedList<int, string>()
        {
            { 1, "Apple" },
            { 2, "Banana" },
            { 3, "Apple" },
            { 4, "Banana" },
            { 5, "Grape" },
            { 6, "Apple" },
            { 7, "Elderberry" }
        };

            Console.WriteLine("\nGrouping fruits by their names:");
            var groups2 = sortedList2.GroupBy(kvp => kvp.Value);
            foreach (var group2 in groups2)
            {
                Console.WriteLine($"Fruit {group2.Key} : {string.Join(", ", group2.Select(kvp => kvp.Key))}");
            }

        }

        static void Main(string[] args)
        {
            //WorkingWithSortedList();
            //LinqWithSortedList();
            GroupingElementsWithSortedList();
            Console.ReadKey();  
        }
    }
}
