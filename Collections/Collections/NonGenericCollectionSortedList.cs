using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class NonGenericCollectionSortedList
    {
        public static void SortedListNonGenericCollection()
        {
            SortedList slt = new SortedList();
            slt.Add(3, 8963);
            slt.Add(2, "Mobile");
            slt.Add(1, 'y');

            foreach (DictionaryEntry entry in slt)
            {
                Console.WriteLine(entry.Key+" "+entry.Value);
            }
        }
    }
}
