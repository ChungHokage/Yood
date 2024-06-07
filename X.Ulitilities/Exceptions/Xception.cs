using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X.Ulitilities.Exceptions
{
    public class Xception : Exception
    {
        public Xception()
        { }

        public Xception(string message) : base(message)
        {
        }

        public Xception(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}