using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_Integradora__2.CLASES.EXCEPCIONES
{
    public class ApellidoInvalidoException : Exception
    {
        public ApellidoInvalidoException(string? mensaje) : base(mensaje)
        {

        }
    }
}
