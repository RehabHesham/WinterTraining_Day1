using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterTraining_Day1
{
    internal class InvalidPriceException : Exception
    {
        public InvalidPriceException() : base("Invaild value for the price"){ }
        public InvalidPriceException(string message) : base(message)
        {

        }
    }
}
