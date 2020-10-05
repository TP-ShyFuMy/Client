using System;
using System.Collections.Generic;
using System.Text;

namespace TPShyFuMyClient.Modeles
{
    /// <summary>
    /// Classe de la pierre
    /// </summary>
    public class Rock : Hand
    {
        /// <summary>
        /// Constructeur de pierre
        /// </summary>
        /// <param name="moveName">Nom du mouvement effectue par la main</param>
        #region Constructors
        public Rock(string moveName)
        {
            HandMove = moveName;
        }
        #endregion
    }
}
