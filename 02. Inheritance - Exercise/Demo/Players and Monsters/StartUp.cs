using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            SoulMaster s = new SoulMaster("Vanko", 15);
            Console.WriteLine(s);
        }
    }
}
