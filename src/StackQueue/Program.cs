using System;
using System.Collections.Generic;

namespace StackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Stack

            Stack<string> fruits = new Stack<string>();
            fruits.Push("Mango");
            fruits.Push("Banana");

            var takeOne = fruits.Pop();
            Console.WriteLine(takeOne);

            fruits.Push("Apple");
            fruits.Push("Jackfruit");

            var seeOne = fruits.Peek();
            Console.WriteLine(seeOne);

            while(fruits.Count > 0)
                Console.WriteLine(fruits.Pop());

            Console.WriteLine("----------------------");

            #endregion

            #region Queue

            Queue<string> colors = new Queue<string>();
            colors.Enqueue("Red");
            colors.Enqueue("Green");

            var takeOneColor = colors.Dequeue();
            Console.WriteLine(takeOneColor);

            colors.Enqueue("Blue");
            colors.Enqueue("Yellow");

            var seeOneColor = colors.Peek();
            Console.WriteLine(seeOneColor);

            while (colors.Count > 0)
                Console.WriteLine(colors.Dequeue());

            #endregion
        }
    }
}
