using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_Integradora__2.CLASES.EXCEPCIONES
{
    public class DenominacionInvalidaException: Exception
    {
        public DenominacionInvalidaException(string? mensaje) : base(mensaje)
        {
        }

    }
}
