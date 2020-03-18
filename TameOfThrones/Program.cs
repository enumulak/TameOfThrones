using System;

namespace TameOfThrones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            string path = @"c:\Input\input.txt";

            //All proceedings begin in Southeros...
            //Southeros.Instance.BeginShanConquest(path);
            Southeros.Instance.BeginShanConquest(args[0]);

            Console.ReadLine();
        }
    }
}
