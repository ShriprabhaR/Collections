using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class NonGenericCollectionArrayList
    {
        public static void ArraListCollection()
        {


            ArrayList lst = new ArrayList();
            lst.Add(10);
            lst.Add("Cat");
            lst.Add(4.9);

            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
        }
    }
}
