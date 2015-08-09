using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingEnumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;

           // SuperHero myValue = SuperHero.Batman;
            //Console.WriteLine("Hello World!");

            Console.WriteLine("type in a super hero's name to see his nickname:");
            string userValue = Console.ReadLine();

            SuperHero myValue;

            if (Enum.TryParse<SuperHero>(userValue, true, out myValue))
            {

            switch (myValue)
            {
                case SuperHero.Batman:
                    Console.WriteLine("Caped crusader");
                    break;
                case SuperHero.Superman:
                    Console.WriteLine("Man of steel");
                    break;
                case SuperHero.GreenLatern:
                    Console.WriteLine("Emerald Knight");
                    break;
                default:
                    Console.WriteLine("Does not compute");
                    break;
            }

            }
            else
            {
                Console.WriteLine("Does not compute");
            }
            Console.ReadLine();
        }
    }

    enum SuperHero
    {
        Batman,
        Superman,
        GreenLatern
    }
}
