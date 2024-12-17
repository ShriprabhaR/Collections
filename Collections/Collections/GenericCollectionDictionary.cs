using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class GenericCollectionDictionary
    {
        public static void DictionaryCollection()
        {
            Dictionary<int, String> dict = new Dictionary<int, String>();
            dict.Add(1, "Abstraction");
            dict.Add(2, "Polymorphism");
            dict.Add(3, "Inheritance");
            dict.Add(4, "Enapsulation");

            foreach (KeyValuePair<int, String> kvp in dict)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }

        }

    }
}
