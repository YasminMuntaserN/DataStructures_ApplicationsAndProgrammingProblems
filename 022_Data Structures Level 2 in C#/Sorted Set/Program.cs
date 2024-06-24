using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_Set
{
    /// <summary>
    /// SortedSet is a collection class in C# that represents a sorted set of elements.
    /// It stores unique elements in sorted order, allowing for efficient search, insertion, and removal operations.
    /// </summary>
    internal class Program
    {
        static void WorkingWithSortedSet()
        {
            // Create a SortedSet of integers
            SortedSet<int> sortedSet = new SortedSet<int>();


            // Add elements to the SortedSet
            sortedSet.Add(5);
            sortedSet.Add(2);
            sortedSet.Add(8);
            sortedSet.Add(3);


            // Display the elements of the SortedSet
            Console.WriteLine("SortedSet elements:");
            foreach (int element in sortedSet)
            {
                Console.WriteLine(element);
            }


            // Check if an element exists in the SortedSet
            int target = 3;
            if (sortedSet.Contains(target))
            {
                Console.WriteLine($"Element {target} exists in the SortedSet.");
            }


            // Remove an element from the SortedSet
            sortedSet.Remove(2);


            // Display the elements of the SortedSet after removal
            Console.WriteLine("SortedSet elements after removal:");
            foreach (int element in sortedSet)
            {
                Console.WriteLine(element);
            }
        }

        static void LinqWithSortedSet_Example1()
        {
            SortedSet<int> sortedSet = new SortedSet<int>() { 1, 2, 3, 4, 5 };


            // Filtering elements greater than 2
            var filteredSet = sortedSet.Where(x => x > 2);
            Console.WriteLine("Filtered Set:");
            foreach (var item in filteredSet)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            // Sum of all elements
            var sum = sortedSet.Sum();
            Console.WriteLine("Sum of all elements: " + sum);


            // Maximum and minimum elements
            var maxElement = sortedSet.Max();
            var minElement = sortedSet.Min();
            Console.WriteLine("Maximum element: " + maxElement);
            Console.WriteLine("Minimum element: " + minElement);


            // Sorting the set in descending order
            var descendingSet = sortedSet.OrderByDescending(x => x);
            Console.WriteLine("Descending Sorted Set:");
            foreach (var item in descendingSet)
            {
                Console.Write(item + " ");
            }
        }

        private static void LinqWithSortedSet_Example2()
        {
            SortedSet<int> numbers = new SortedSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Find even numbers and project them to their square
            var evenNumbersSquared = numbers.Where(x => x % 2 == 0).Select(x => Math.Pow(x, 2));
            Console.WriteLine("Squares of even numbers:");
            foreach (int item in evenNumbersSquared)
            {
                Console.Write(item + " ");
            }
        }

        private static void Union_Intersection_Difference_Subset_Superset_OperationsUsingSortedSet()
        {
            SortedSet<int> set1 = new SortedSet<int>() { 1, 2, 3, 4, 5 };
            SortedSet<int> set2 = new SortedSet<int>() { 3, 4, 5, 6, 7 };


            // Union
            SortedSet<int> unionSet = new SortedSet<int>(set1);
            unionSet.UnionWith(set2);
            Console.WriteLine("\nUnion:");
            foreach (int item in unionSet)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            // Intersection
            SortedSet<int> intersectSet = new SortedSet<int>(set1);
            intersectSet.IntersectWith(set2);
            Console.WriteLine("\nIntersection:");
            foreach (int item in intersectSet)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            // Difference
            SortedSet<int> differenceSet = new SortedSet<int>(set1);
            differenceSet.ExceptWith(set2);
            Console.WriteLine("\nDifference (set1 - set2):");
            foreach (int item in differenceSet)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // Symmetric
            SortedSet<int> SymmetricSet = new SortedSet<int>(set1);
            SymmetricSet.SymmetricExceptWith(set2);
            Console.WriteLine("\nSymmetric (set1 - set2):");
            foreach (int item in SymmetricSet)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            // Subset and Superset
            Console.WriteLine("\nSubset:");
            if (set1.IsSubsetOf(set2))
                Console.WriteLine("Set1 is a subset of Set2");
            else
                Console.WriteLine("Set1 is not a subset of Set2");


            Console.WriteLine("\nSuperset:");
            if (set1.IsSupersetOf(set2))
                Console.WriteLine("Set1 is a superset of Set2");
            else
                Console.WriteLine("Set1 is not a superset of Set2");
        }

        private static void ComparingSortedSets()
        {
            SortedSet<int> set1 = new SortedSet<int>() { 1, 2, 3, 4, 5 };
            SortedSet<int> set2 = new SortedSet<int>() { 3, 1, 2, 5, 4 };


            // Check if set1 is equal to set2
            bool areEqual = set1.SetEquals(set2);
            Console.WriteLine("\nAre set1 and set2 equal? " + areEqual);


            // Check if set1 is a subset of set2
            bool isSubset = set1.IsSubsetOf(set2);
            Console.WriteLine("\nIs set1 a subset of set2? " + isSubset);


            // Check if set1 is a superset of set2
            bool isSuperset = set1.IsSupersetOf(set2);
            Console.WriteLine("\nIs set1 a superset of set2? " + isSuperset);
        }
        static void Main(string[] args)
        {
            // WorkingWithSortedSet();
            //LinqWithSortedSet_Example1();
            // LinqWithSortedSet_Example2();
            //Union_Intersection_Difference_Subset_Superset_OperationsUsingSortedSet();
            ComparingSortedSets();
            Console.ReadKey();
        }
    }
}
