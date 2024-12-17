using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class NonGenericCollectionHashTable
    {
        public static void HashTableCollection()
        {
            Hashtable ht = new Hashtable();
            ht.Add("ab", "Java");
            ht.Add(2, ".net");
            ht.Add(3.2, 4573);

            foreach (DictionaryEntry items in ht)
            {
                Console.WriteLine(items.Key+" -> "+items.Value);
            }
        }
    }
}
