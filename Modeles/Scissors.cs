using System;
using System.Collections.Generic;
using System.Text;

namespace TPShyFuMyClient.Modeles
{
    /// <summary>
    /// Classe des ciseaux
    /// </summary>
    public class Scissors : Hand
    {

        /// <summary>
        /// Constructeur de ciseaux
        /// </summary>
        /// <param name="moveName">Nom du mouvement effectue par la main</param>
        #region Constructors
        public Scissors(string moveName)
        {
            HandMove = moveName;
        }
        #endregion
    }
}
