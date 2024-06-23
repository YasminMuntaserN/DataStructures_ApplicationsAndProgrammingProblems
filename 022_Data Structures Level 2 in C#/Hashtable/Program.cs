using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    /// <summary>
    /// A hash table is a data structure that you can use to store data in key-value format with direct access to its items in constant time.
    /// </summary>
    internal class Program
    {
        static void WorkingWithHashTable()
        {
            Hashtable MyHashTable = new Hashtable();
            MyHashTable.Add("Key1", "Value1");
            MyHashTable.Add("Key2", "Value2");
            MyHashTable.Add("Key3", "Value3");

            Console.WriteLine($"Accessing Key1 :{MyHashTable["Key1"]}");
            MyHashTable["Key1"] = "newValue1";

            MyHashTable.Remove("Key2");

            foreach (DictionaryEntry entry in MyHashTable)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }
        }

        static void Main(string[] args)
        {
            WorkingWithHashTable();
            Console.ReadKey();
        }
    }
}
