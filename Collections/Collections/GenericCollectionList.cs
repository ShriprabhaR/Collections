using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class GenericCollectionList
    {
        public static void ListCollection()
        {
            List<int> lst = new List<int>();
            lst.Add(1);
            lst.Add(2);
            lst.Add(3);

            foreach (int item in lst)
            {
                Console.WriteLine(item);
            }
        }
    }
}
