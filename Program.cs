using System;
using TPShyFuMyClient.Modeles;

namespace TPShyFuMyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Client!");
            Scissors Scissors = new Scissors();
            Console.WriteLine(Scissors.HandMove.ToString());
        }
    }
}
