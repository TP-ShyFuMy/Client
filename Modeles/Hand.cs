using System;
using System.Collections.Generic;
using System.Text;

namespace TPShyFuMyClient
{
    /// <summary>
    /// Mouvements de la main
    /// </summary>
    public abstract class Hand
    {
        /// <summary>
        /// Geste de la main
        /// </summary>
        #region Attributes
        private string _HandMove;
        #endregion
        #region Properties
        /// <summary>
        /// Obtient ou défini le nom du geste de la main
        /// </summary>
        public string HandMove
        {
            get { return _HandMove; }
            set { _HandMove = value; }
        }

        #endregion
    }
}
