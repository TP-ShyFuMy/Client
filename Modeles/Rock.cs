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
        #region Constructors
        public Rock()
        {
            HandMove = "Pierre";
        }
        #endregion
    }
}
