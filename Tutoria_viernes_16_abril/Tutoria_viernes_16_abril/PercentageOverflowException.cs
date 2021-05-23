using System;
using System.Collections.Generic;
using System.Text;

namespace Tutoria_viernes_16_abril
{
    class PercentageOverflowException: Exception
    {
        public PercentageOverflowException(string message) : base(message) { }
    }
}
