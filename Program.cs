using System;
using TPShyFuMyClient.Modeles;
using TPShyFuMyLibrary;

namespace TPShyFuMyClient
{
    class Program
    {
        /// <summary>
        /// Permet de choisir le pseudo du joueur
        /// </summary>
        /// <param name="user">Class User Library</param>
        static void ChooseUsername(User user)
        {
            Console.WriteLine("Entrez votre pseudo :");
            string userName = Console.ReadLine();
            user.userName = userName;
            Console.Clear();
        }
        static void ChoiceHand(User user)
        {
            Console.WriteLine(user.userName+" choisissez mouvement :");
            Console.WriteLine(" Papier-> 1");
            Console.WriteLine(" Pierre-> 2");
            Console.WriteLine(" Ciseaux-> 3");
        }
        static void Main(string[] args)
        {
            User user = new User();
            ChooseUsername(user);
            ChoiceHand(user);
            Console.ReadLine();

        }
    }
}
