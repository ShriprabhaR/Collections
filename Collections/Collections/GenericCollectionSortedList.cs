using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class GenericCollectionSortedList
    {
        public static void SortedListGenericCollection()
        {
            SortedList<char, String> slst = new SortedList<char, String>();
            slst.Add('A', "Oracle");
            slst.Add('B', "IBM");
            slst.Add('D', "Wipro");
            slst.Add('C', "Accenture");

            foreach(KeyValuePair<char, String> item in slst)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }
        }
    }
}
