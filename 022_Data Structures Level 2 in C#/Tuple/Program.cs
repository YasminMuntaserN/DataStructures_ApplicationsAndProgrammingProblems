using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    internal class Program
    {
        //Method Returning a Tuple:
        static (int, string) GetValues()
        {
            return (20, "Twenty");
        }

        public static void createTuple()
        {

            // Declare a tuple
            (int, string, double) person = (1, "Alice", 5.5);


            // Access tuple elements
            Console.WriteLine("ID: " + person.Item1);
            Console.WriteLine("Name: " + person.Item2);
            Console.WriteLine("Height: " + person.Item3 + " feet");


            // Using a method that returns a tuple
            var values = GetValues();
            Console.WriteLine("Number: " + values.Item1);
            Console.WriteLine("Text: " + values.Item2);
            Console.ReadKey();
        }

        public static void LINQTuples()
        {
            // List of tuples representing ID, Name, and Age
            List<(int Id, string Name, int Age)> people = new List<(int, string, int)>
        {
            (1, "Alice", 30),
            (2, "Bob", 25),
            (3, "Charlie", 35),
            (4, "Diana", 28)
        };


            // Filter people with age above 30
            var filteredPeople = people.Where(p => p.Age > 30);


            foreach (var person in filteredPeople)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }


            // Find average age
            double averageAge = people.Average(p => p.Age);
            Console.WriteLine("Average Age: " + averageAge);
        }

        static void Main(string[] args)
        {
            //createTuple();

            LINQTuples();

            Console.ReadKey();
        }
    }
}
