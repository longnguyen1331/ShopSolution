using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.Utilities.Extentions
{
    public class ShopSolutionException : Exception
    {
        public ShopSolutionException()
        {
        }

        public ShopSolutionException(string message)
            : base(message)
        {
        }

        public ShopSolutionException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
