using System;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NonGenericCollectionArrayList.ArraListCollection();
            Console.WriteLine("------------------");

            GenericCollectionList.ListCollection();
            Console.WriteLine("------------------");

            NonGenericCollectionHashTable.HashTableCollection();
            Console.WriteLine("------------------");

            GenericCollectionDictionary.DictionaryCollection();
            Console.WriteLine("------------------");

            NonGenericCollectionSortedList.SortedListNonGenericCollection();
            Console.WriteLine("------------------");

            GenericCollectionSortedList.SortedListGenericCollection();
            Console.WriteLine("------------------");

            NonGenericCollectonStack.StackNonGenericCollection();
            Console.WriteLine("------------------");

            GenericCollectionStack.StackGenericCollection();
            Console.WriteLine("------------------");

            NonGenericCollectionQueue.QueueNonGenericCollection();
            Console.WriteLine("------------------");

            GenericCollectionQueue.QueueGenericCollection();
            Console.WriteLine("------------------");

          }
      }
  }
