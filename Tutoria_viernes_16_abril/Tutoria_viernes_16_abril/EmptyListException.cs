using System;
using System.Collections.Generic;
using System.Text;

namespace Tutoria_viernes_16_abril
{
    class EmptyListException: Exception
    {
        public EmptyListException(String message) : base(message) { }
    }
}
