using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class CustomCollection<T> : IEnumerable<T>
    {
        private List<T> _Items = new List<T>();

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T Item in _Items)
            {
                yield return Item;
            }
        }

 
        public void Add(T Item)
        {
            _Items.Add(Item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        
        }
}
    internal class Program
    {
        static void Main(string[] args)
    {

        CustomCollection<int> Numbers = new CustomCollection<int>();

        Numbers.Add(1);
        Numbers.Add(2);
        Numbers.Add(3);

        foreach (int i in Numbers)
        {
            Console.WriteLine(i);
        }

        Console.ReadKey();

    }
    }
    
