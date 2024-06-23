using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    /// <summary>
    /// HashSet<T> is a collection class in the System.Collections.Generic namespace designed to store unique elements.
    /// </summary>
    internal class Program
    {
        public static void WorkingWithHashSet()
        {
            // Creating a HashSet of strings
            HashSet<string> fruits = new HashSet<string>();




            // Adding elements to the HashSet
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Cherry");


            // Trying to add a duplicate element
            fruits.Add("Apple"); // This will not be added
            fruits.Add("Apple"); // This will not be added
            fruits.Add("Apple"); // This will not be added


            // Displaying the elements in the HashSet
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }

        public static void CheckingForExistenceInHashSet()
        {
            HashSet<string> fruits = new HashSet<string> { "Apple", "Banana", "Cherry" };


            // Checking if "Apple" is in the HashSet
            if (fruits.Contains("Apple"))
            {
                Console.WriteLine("Apple is in the HashSet");
            }
            else
            {
                Console.WriteLine("Apple is not in the HashSet");
            }

            if (fruits.Contains("apple")) // support case-sensitive
                Console.WriteLine("apple is found");
            else
                Console.WriteLine("apple is not found");


            fruits.Remove("Banana"); // support case-sensitive

            // Displaying the elements in the HashSet
            Console.WriteLine("Displaying the elements after deleting Banana: ");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            fruits.Clear();
        }

        static int[] RemovingDuplicateNumbersFromArray(int[] Numbers)
        {
            HashSet<int> UniqueNumbers = new HashSet<int>(Numbers);

            return UniqueNumbers.ToArray();
        }

        static void LinqWithHashSet()
        {
            HashSet<int> Numbers = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var EvenNumbers = Numbers.Where(Number => Number % 2 == 0);

            Console.WriteLine("Even Numbers: ");
            foreach (int EvenNumber in EvenNumbers)
            {
                Console.WriteLine(EvenNumber);
            }


            var NumbersGreaterThanFive = Numbers.Where(Number => Number > 5);

            Console.WriteLine("Numbers Greater than Five");
            foreach (int Number in NumbersGreaterThanFive)
            {
                Console.WriteLine(Number);
            }


            // Creating and populating a HashSet of strings
            HashSet<string> Names = new HashSet<string> { "Alice", "Bob", "Charlie", "Daisy", "Ethan", "Fiona", "Elina" };

            var NamesStartWith_E = Names.Where(Name => Name.StartsWith("E"));

            Console.WriteLine("Names Start With_E :");
            foreach (string Name in NamesStartWith_E)
            {
                Console.Write(Name + " ");
            }

            Console.WriteLine();

            var NamesLongerThenFourLength = Names.Where(Name => Name.Length > 4);
            Console.WriteLine("Names Longer Then Four Length :");
            foreach (string Name in NamesLongerThenFourLength)
            {
                Console.Write(Name + " ");
            }
        }

        static void SetUnionOperationInHashSet()
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };


            // Union of set1 and set2
            set1.UnionWith(set2);


            Console.WriteLine("Union of sets:");
            foreach (int item in set1)
            {
                Console.WriteLine(item);
            }

            HashSet<string> UnionSet3 = new HashSet<string> { "aa", "bb", "cc" };
            HashSet<string> UnionSet4 = new HashSet<string> { "AA", "dd", "ff" };

            UnionSet3.UnionWith(UnionSet4); // not supposed the case-sensitive
            Console.WriteLine("Union String of Sets");
            foreach (string Word in UnionSet3)
            {
                Console.WriteLine(Word);
            }
        }

        static void SetIntersectionOperationInHashSet()
        {

            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };


            // Intersection of set1 and set2
            set1.IntersectWith(set2);


            Console.WriteLine("Intersection of sets:");
            foreach (int item in set1)
            {
                Console.WriteLine(item);
            }
        }

        static void DifferenceOperationWithHashSet()
        {

            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };


            // Removing elements of set2 from set1
            set1.ExceptWith(set2);


            Console.WriteLine("Difference of sets (set1 - set2):");
            foreach (int item in set1)
            {
                Console.WriteLine(item);
            }
        }

        static void SymmetricDifferenceOperationWithHashSet()
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };


            // Symmetric Except With of set1 and set2
            set1.SymmetricExceptWith(set2);


            Console.WriteLine("Symmetric Except With of sets:");
            foreach (int item in set1)
            {
                Console.WriteLine(item);
            }
        }

        static void ComparingSetInHashSet()
        {
            // all of these methods do not matter about the order of elements

            #region SetEquals
            HashSet<int> EqualSet1 = new HashSet<int> { 1, 3, 2 };
            HashSet<int> EqualSet2 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> EqualSet3 = new HashSet<int> { 4, 2, 3 };

            Console.WriteLine("Is Set1 Equals Set2? {0}", EqualSet1.SetEquals(EqualSet2)); // True because the order does not matter
            Console.WriteLine("Is Set1 Equals Set3? {0}", EqualSet1.SetEquals(EqualSet3));

            HashSet<string> EqualSet4 = new HashSet<string> { "aa", "bb", "cc" };
            HashSet<string> EqualSet5 = new HashSet<string> { "aa", "bb", "cc" };
            HashSet<string> EqualSet6 = new HashSet<string> { "aa", "bb", "Cc" };

            Console.WriteLine("Is Set4 Equals Set5? {0}", EqualSet4.SetEquals(EqualSet5));
            Console.WriteLine("Is Set4 Equals Set6? {0}", EqualSet4.SetEquals(EqualSet6));
            #endregion


            #region IsSubset
            HashSet<int> SubsetSet1 = new HashSet<int> { 1, 3, 2 };
            HashSet<int> SubsetSet2 = new HashSet<int> { 1, 2, 3, 4 };

            Console.WriteLine("Is Set1 Subset of Set2? {0}", SubsetSet1.IsSubsetOf(SubsetSet2));
            Console.WriteLine("Is Set2 Subset of Set1? {0}", SubsetSet2.IsSubsetOf(SubsetSet1));

            HashSet<string> SubsetSet3 = new HashSet<string> { "aa", "cc", "bb" };
            HashSet<string> SubsetSet4 = new HashSet<string> { "aa", "bb", "cc", "ll" };

            Console.WriteLine("Is Set3 Subset of Set4? {0}", SubsetSet3.IsSubsetOf(SubsetSet4));
            Console.WriteLine("Is Set4 Subset of Set3? {0}", SubsetSet4.IsSubsetOf(SubsetSet3));
            #endregion

            #region IsSupersetOf
            HashSet<int> SuperSet1 = new HashSet<int> { 1, 3, 2 };
            HashSet<int> SuperSet2 = new HashSet<int> { 1, 2, 3, 4 };

            Console.WriteLine("Is Set1 Superset of Set2? {0}", SuperSet1.IsSupersetOf(SuperSet2));
            Console.WriteLine("Is Set2 Superset of Set1? {0}", SuperSet2.IsSupersetOf(SuperSet1));

            HashSet<string> SuperSet3 = new HashSet<string> { "aa", "cc", "bb" };
            HashSet<string> SuperSet4 = new HashSet<string> { "aa", "bb", "cc", "ll" };

            Console.WriteLine("Is Set3 Superset of Set4? {0}", SuperSet3.IsSupersetOf(SuperSet4));
            Console.WriteLine("Is Set4 Superset of Set3? {0}", SuperSet4.IsSupersetOf(SuperSet3));
            #endregion

            #region Overlaps
            HashSet<int> OverlapsSet1 = new HashSet<int> { 8, 9, 5 };
            HashSet<int> OverlapsSet2 = new HashSet<int> { 1, 2, 3, 4 };

            Console.WriteLine("Is Set1 Overlaps Set2? {0}", OverlapsSet1.Overlaps(OverlapsSet2));

            HashSet<string> OverlapsSet3 = new HashSet<string> { "aa", "xx", "vv" };
            HashSet<string> OverlapsSet4 = new HashSet<string> { "aa", "bb", "cc", "ll" };

            Console.WriteLine("Is Set3 Overlaps Set4? {0}", OverlapsSet3.Overlaps(OverlapsSet4));
            #endregion
        }
        static void Main(string[] args)
        {
            // WorkingWithHashSet();
            // CheckingForExistenceInHashSet();

            //int[] DuplicatedNumbers = { 1, 2, 3, 1, 2, 4 };

            //int[] UniqueNumbers = RemovingDuplicateNumbersFromArray(DuplicatedNumbers);

            //foreach (int Number in UniqueNumbers)
            //{
            //    Console.WriteLine(Number);
            //}

            // LinqWithHashSet();
            //SetUnionOperationInHashSet();
            //SetIntersectionOperationInHashSet();
            //DifferenceOperationWithHashSet();
            //SymmetricDifferenceOperationWithHashSet();
            ComparingSetInHashSet();
            Console.ReadKey();

        }
    }
}


