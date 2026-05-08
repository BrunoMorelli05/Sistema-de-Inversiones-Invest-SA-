using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_Integradora__2.CLASES.EXCEPCIONES
{
    public class AccionInvalidaException: Exception
    {
        public AccionInvalidaException(string mensaje) : base(mensaje)
        {
        }
    }
}
