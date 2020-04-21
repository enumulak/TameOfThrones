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

            //string path = @"C:\Input\input3.txt";
            //Southeros.Instance.BeginShanConquest(path);

            Console.ReadLine();
        }
    }
}
