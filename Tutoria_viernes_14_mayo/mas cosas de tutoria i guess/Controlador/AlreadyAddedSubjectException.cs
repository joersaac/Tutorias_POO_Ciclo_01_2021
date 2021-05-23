using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas_cosas_de_tutoria_i_guess.Controlador
{
    class AlreadyAddedSubjectException : Exception
    {
        public AlreadyAddedSubjectException(string message) : base(message) {}
    }
}
