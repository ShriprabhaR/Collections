using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class NonGenericCollectonStack
    {
        public static void StackNonGenericCollection()
        {
            Stack stk = new Stack();
            stk.Push(120);
            stk.Push(560.89);
            stk.Push("Mango");

            foreach (var item in stk)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------");
            Console.WriteLine("Removed Element:"+stk.Pop());
          Console.WriteLine("Top element:"+stk.Peek());

        }
    }
}
