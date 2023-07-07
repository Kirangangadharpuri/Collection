using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    //List<T>- class represents the List of object which can accessed with index
    //It is Dynamic and we can resize the list
    public class ListDemo
    {
        //Creating a list of integers
        List<int> list = new List<int>();
        public void Adding()
        {
            list.Add(12);
            list.Add(13);
            list.Add(14);
            list.Add(15);
            list.Add(16);
            foreach(int elements in list)
            {
                Console.WriteLine(elements);
            }
            Console.WriteLine("Total elements in list are {0}",list.Count);
            Console.WriteLine("Total elements in list are {0}", list.Capacity);
            list.Add(17);
            list.Add(18);
            list.Add(19);
            list.Add(20);
            foreach (int elements in list)
            {
                Console.WriteLine(elements);
            }
            Console.WriteLine("Total elements in list are {0}", list.Count);
            Console.WriteLine("Total elements in list are {0}", list.Capacity);
            list.RemoveAt(5);
            Console.WriteLine("#####################");
            Console.WriteLine("Rmove the element of perticular position");
            foreach (int elements in list)
            {
                Console.WriteLine(elements);
            }
            Console.WriteLine("#####################");
            Console.WriteLine("Print the elements in reverse order");

            list.Reverse();
            foreach (int elements in list)
            {
                Console.WriteLine(elements);
            }
            Console.WriteLine("#####################");
            Console.WriteLine("Print the elements in sorted form");

            list.Sort();
            foreach (int elements in list)
            {
                Console.WriteLine(elements);
            }
            Console.WriteLine("#####################");
            list.Clear();
            foreach (int elements in list)
            {
                Console.WriteLine(elements);
            }
        }
    }
}
