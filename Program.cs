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
        /// <summary>
        /// Menu de choix de l'action
        /// </summary>
        /// <param name="user"></param>
        static void MenuChoiceHand(User user)
        {
            Console.WriteLine(user.userName+", choisissez votre mouvement :");
            Console.WriteLine(" Papier -> 1");
            Console.WriteLine(" Pierre -> 2");
            Console.WriteLine(" Ciseaux -> 3");
        }
        /// <summary>
        /// Choix du joueur
        /// </summary>
        /// <returns>string choice</returns>
        static string Choice()
        {
            string choice = "";
            switch (Console.ReadLine())
            {
                case "1":
                    Paper paper = new Paper();
                    choice = paper.HandMove;
                    break;
                case "2":
                    Rock rock = new Rock();
                    choice = rock.HandMove;
                    break;
                case "3":
                    Scissors scissors = new Scissors();
                    choice = scissors.HandMove;
                    break;
            }
            return choice;
        }
        static void Main(string[] args)
        {
            User user = new User();
            ChooseUsername(user);
            MenuChoiceHand(user);
            Console.WriteLine(Choice());
            Console.ReadLine();
        }
    }
}
