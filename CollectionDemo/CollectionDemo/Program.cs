using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class Program
    {
        //Collection is a class that means you can create aor declare an object
        //can be create or declare instance of a class, so we can add a data in collections
        //collection types- are designed to stare, manage similar data
        //We can used to adding, removing fine and sorting data in collection
        //two types of collection- Generic and Non-generic
        //Non-Generic-ArrayList, HashTable, SortedList, Stanck and Queue
        //Generic one is List dictionary,SortedtList, Stack and Queue
        static void Main(string[] args)
        {
            ListDemo listDemo = new ListDemo();
            listDemo.Adding();
            Console.ReadLine();
        }
    }
}
