using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork13March.Exceptions
{
    class SameBookalreadyAddedExpection : Exception
    {
        public SameBookalreadyAddedExpection(string message) : base(message)
        {

        }
    }
}
