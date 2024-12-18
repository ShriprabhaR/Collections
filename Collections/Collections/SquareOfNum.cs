using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Collections
{
    internal class SquareOfNum
    {
        public static void Square()
        {
            List<int> list = new List<int>() { 2, 5, 9, 3, 8 };
            foreach (int items in list)
            {
                Console.Write(items+" ");
            }
            Console.WriteLine("\n--------");

            //Select is a Linq method
            var SquareOfNumber = list.Select(x => x * x);
            Console.Write("Squares:");
            foreach(int item in SquareOfNumber)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine("\n-------");
        }

        public static void DivideBy3()
        {
            List<int> list = new List<int> { 2, 5, 9, 6 };
            foreach (int items in list)
            {
                Console.Write(items + " ");
            }

            var DevideOf = list.FindAll(x => x % 3 == 0);
            Console.Write("\nNumbers Divisible by 3:  ");
            foreach (int item in DevideOf)
            {
                Console.Write(item+" ");
            }
        }
    }
}
