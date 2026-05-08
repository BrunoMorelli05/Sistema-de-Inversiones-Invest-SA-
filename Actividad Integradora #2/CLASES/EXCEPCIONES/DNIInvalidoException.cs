using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_Integradora__2.CLASES.EXCEPCIONES
{
    public class DNIInvalidoException : Exception
    {
        public DNIInvalidoException(string? mensaje) : base(mensaje)
        {

        }
    }
}
