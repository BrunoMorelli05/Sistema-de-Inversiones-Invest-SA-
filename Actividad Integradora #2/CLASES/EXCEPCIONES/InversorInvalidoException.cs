using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_Integradora__2.CLASES.EXCEPCIONES
{
    public class InversorInvalidoException : Exception
    {
        public InversorInvalidoException(string? mensaje) : base(mensaje)
        {
        }
    }
}
