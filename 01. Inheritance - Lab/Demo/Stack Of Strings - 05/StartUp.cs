using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>()
            { "a", "b", "c" };
            StackOfStrings stack = new StackOfStrings();
            stack.AddRange(list);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            Console.WriteLine(stack.IsEmpty());
        }
    }
}
