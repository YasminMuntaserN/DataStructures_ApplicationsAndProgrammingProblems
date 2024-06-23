using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace List
{
    /// <summary>
    /// List<T> is a generic collection class in the .NET framework.
    /// It's used to store a collection of objects of the same type (T stands for the type parameter).
    /// Unlike arrays, List<T> is dynamic, meaning it can automatically resize as needed.
    /// </summary>
    internal class Program
    {
        public static void InsertingElementsIntoList()
        {

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            list.Add(11);
            Console.WriteLine("After Adding 11 :" + string.Join(" , ", list));

            list.Insert(0, 0);
            Console.WriteLine("After Inserting 0 at the beginning:" + string.Join(" , ", list));

            list.InsertRange(5, new List<int> { 55, 56 });
            Console.WriteLine("After Inserting 55 and 56 at index 5:" + string.Join(" , ", list));

        }

        public static void RemoveItemsFromList()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            list.Remove(5);
            Console.WriteLine("After removing 5 :" + string.Join(" , ", list));

            list.RemoveAt(0);
            Console.WriteLine("After removing first element :" + string.Join(" , ", list));

            // هيك كأنو بنلف بلوب ع كل العناصر الموجودة وبنشوف مين زوجي فيهم
            list.RemoveAll(n => n % 2 == 0);
            Console.WriteLine("After removing all even numbers :" + string.Join(" , ", list));

            list.RemoveRange(1, 2);
            Console.WriteLine("After Removing multiple elements : {0}", string.Join(", ", list));

            list.Clear();
            Console.WriteLine("After clearing the list , count :" + list.Count);

        }

        public static void LoopingThroughList()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Number of items in the list :" + list.Count);


            // Looping through the list using a for loop
            Console.WriteLine("\nDisplaying list elements using a for loop:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]); // Accessing each element by its index
            }


            // Looping through the list using a foreach loop
            Console.WriteLine("\nDisplaying list elements using a foreach loop:");
            foreach (int number in list)
            {
                Console.WriteLine(number); // Accessing each element directly
            }

            // Looping through the list using the List.ForEach method
            Console.WriteLine("\nDisplaying list elements using List.ForEach:");
            list.ForEach(Console.WriteLine); // Using a lambda expression

            // Looping through the list using the List.ForEach method another format
            Console.WriteLine("\nDisplaying list elements using List.ForEach:");
            list.ForEach(number => Console.WriteLine(number)); // Using a lambda expression

            // Looping through the list using the List.ForEach method
            Console.WriteLine("another example Using ForEach");
            list.ForEach(n =>
            {
                Console.WriteLine();

                if (n % 2 == 0)
                    Console.WriteLine(n + " is Even");
                else
                    Console.WriteLine(n + " is Odd");
            });

        }

        public static void AggregatingDataUsingLINQWithList()
        {
            // List initialization
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            // Aggregation operations
            Console.WriteLine("Sum: " + numbers.Sum());
            Console.WriteLine("Average: " + numbers.Average());
            Console.WriteLine("Minimum: " + numbers.Min());
            Console.WriteLine("Maximum: " + numbers.Max());
            Console.WriteLine("Count: " + numbers.Count());

        }

        public static void FilteringDataWithLINQ()
        {

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Even Numbers : " + string.Join(" , ", list.Where(n => n % 2 == 0)));
            Console.WriteLine("Odd Numbers : " + string.Join(" , ", list.Where(n => n % 2 != 0)));
            Console.WriteLine("Numbers Greater Than 5 : " + string.Join(" , ", list.Where(n => n > 5)));
            Console.WriteLine("Every Second Number : " + string.Join(" , ", list.Where((n, index) => index % 2 != 0)));
            Console.WriteLine("Numbers Between 3 and 8 : " + string.Join(" , ", list.Where(n => n > 3 && n < 8)));

        }

        public static void SortingList()
        {
            // List initialization
            List<int> numbers = new List<int> { 44, 22, 55, 666, 9, -6, 345, 11, 3, 3 };


            // Default Sorting (Ascending)
            numbers.Sort();
            Console.WriteLine("Sorted in Ascending Order: " + string.Join(", ", numbers));


            // Sorting in Descending Order
            numbers.Reverse();
            Console.WriteLine("Sorted in Descending Order: " + string.Join(", ", numbers));


            // Sorting with LINQ
            Console.WriteLine("Sorted Ascending with LINQ: " + string.Join(", ", numbers.OrderBy(n => n)));
            Console.WriteLine("Sorted Descending with LINQ: " + string.Join(", ", numbers.OrderByDescending(n => n)));


        }

        static void Exploring_Contains_Exists_Find_FindAll_Any_WithInt()
        {
            // List initialization
            List<int> numbers = new List<int> { 44, 22, 55, 666, 9, -6, 345, 11, 3, 3 };


            // Using Contains
            Console.WriteLine("List contains 9: " + numbers.Contains(9));


            // Using Exists
            Console.WriteLine("List contains negative numbers: " + numbers.Exists(n => n < 0));


            // Using Find
            Console.WriteLine("First negative number: " + numbers.Find(n => n < 0));


            // Using FindAll
            Console.WriteLine("All negative numbers: " + string.Join(", ", numbers.FindAll(n => n < 0)));


            // Using Any
            Console.WriteLine("Any numbers greater than 100: " + numbers.Any(n => n > 100));
        }

        static void Exploring_Contains_Exists_Find_FindAll_Any_WithString()
        {
            // List initialization
            List<string> words = new List<string> { "apple", "banana", "cherry", "date", "elderberry", "fig", "grape", "honeydew" };

            // sorted by the length of each item
            var result = words.OrderBy(word => word.Length);
            foreach (string word in result)
            {
                Console.WriteLine(word); // Accessing each element directly
            }
            // Using Contains
            Console.WriteLine("List contains 'apple': " + words.Contains("apple"));


            // Using Exists
            Console.WriteLine("List contains a word of length 5: " + words.Exists(word => word.Length == 5));


            // Using Find
            Console.WriteLine("First word longer than 5 characters: " + words.Find(word => word.Length > 5));


            // Using FindAll
            Console.WriteLine("Words longer than 5 characters: " + string.Join(", ", words.FindAll(word => word.Length > 5)));


            // Using Any
            Console.WriteLine("Any words starting with 'a': " + words.Any(word => word.StartsWith("a")));


            // Waiting for a key press
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            // InsertingElementsIntoList();
            // RemoveItemsFromList();
            //  LoopingThroughList();
            //AggregatingDataUsingLINQWithList();
            // FilteringDataWithLINQ();
            // SortingList();
            // Exploring_Contains_Exists_Find_FindAll_Any_WithInt();
            Exploring_Contains_Exists_Find_FindAll_Any_WithString();

            // Waiting for a key press
            Console.ReadKey();
        }
    }
}
