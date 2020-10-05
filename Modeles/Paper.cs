using System;
using System.Collections.Generic;
using System.Text;

namespace TPShyFuMyClient.Modeles
{
    /// <summary>
    /// Classe du papier
    /// </summary>
    public class Paper : Hand
    {
        /// <summary>
        /// Constructeur de papier
        /// </summary>
        /// <param name="moveName">Nom du mouvement effectue par la main</param>
        #region Constructors
        public Paper(string moveName)
        {
            HandMove = moveName;
        }
        #endregion
    }
}
