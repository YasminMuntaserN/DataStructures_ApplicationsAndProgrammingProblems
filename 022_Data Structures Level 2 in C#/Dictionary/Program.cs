using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    /* static void Main()
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



       }*/

    /*static void Main()
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

            Console.ReadKey();
        }*/

    //Utilizing LINQ with Dictionaries

    /*  static void Main()
     {
         Dictionary<string , int> fruitBasket =new Dictionary<string, int> {
             {"Apple",5 },
             {"Banana",2 },
             {"Orange",7 },
         };   

         var filteredInfo = fruitBasket.Select(x => new {x.Key ,x.Value });

         Console.WriteLine("\n Transformed Items : ");
         foreach (var item in filteredInfo)
         {
             Console.WriteLine($"Fruit : {item.Key} , Quantity : {item.Value}");
         }


         var filterdFruit = fruitBasket.Where(x => x.Value > 3);

         Console.WriteLine("\n Fruited Items : ");
         foreach (var item in filteredInfo)
         {
             Console.WriteLine($"Fruit : {item.Key} , Quantity : {item.Value}");
         }


         var sortedByQuantity = fruitBasket.OrderBy(x => x.Value);

         Console.WriteLine("\nSorted Items : ");
         foreach (var item in sortedByQuantity)
         {
             Console.WriteLine($"Fruit : {item.Key} , Quantity : {item.Value}");
         }*/
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
