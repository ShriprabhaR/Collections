using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class GenericCollectionStack
    {
        public static void StackGenericCollection()
        {
            Stack<String> stk = new Stack<String>();
            stk.Push("Developer");
            stk.Push("process Associate");
            stk.Push("Manager");
            stk.Push("HR");

            foreach (String items in stk)
            {
                Console.WriteLine(items);
            }
            Console.WriteLine("------");
            Console.WriteLine("Removed Element:" + stk.Pop());
            Console.WriteLine("Top element:" + stk.Peek());
        }
    }
}
