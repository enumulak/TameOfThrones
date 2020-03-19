using System;

namespace TameOfThrones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            
            //All proceedings begin in Southeros...
            Southeros.Instance.BeginShanConquest(args[0]);

            Console.ReadLine();
        }
    }
}
