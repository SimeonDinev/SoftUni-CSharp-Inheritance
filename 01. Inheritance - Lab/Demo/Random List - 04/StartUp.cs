using System;

namespace CustomRandomList
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            RandomList rdList = new RandomList();

            rdList.Add("a");
            rdList.Add("b");
            rdList.Add("c");
            rdList.Add("d");
            rdList.Add("e");

            Console.WriteLine(rdList.RandomString());
        }
    }
}
