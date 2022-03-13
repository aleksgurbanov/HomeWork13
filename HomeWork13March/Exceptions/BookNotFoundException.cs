using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork13March.Exceptions
{
    class BookNotFoundException : Exception
    {
        public BookNotFoundException(string message) : base(message)
        {

        }
    }
}
