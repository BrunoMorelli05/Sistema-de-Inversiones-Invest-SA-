using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_Integradora__2.CLASES.EXCEPCIONES
{
    public class NombreInvalidoException : Exception
    {
        public NombreInvalidoException(string? mensaje) : base(mensaje)
        {

        }
    }
}
