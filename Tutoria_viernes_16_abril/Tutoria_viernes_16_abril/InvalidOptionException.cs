using System;
using System.Collections.Generic;
using System.Text;

namespace Tutoria_viernes_16_abril
{
    class InvalidOptionException: Exception
    {
        public InvalidOptionException(String message) : base(message) { }
    }
}
