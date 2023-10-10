using System;

namespace Inlämningsuppgift3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet?");
            Console.WriteLine("j = Ja, n = Nej")
            string svar = Console.ReadLine().ToLower();
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());
        }
    }
}