using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_Integradora__2.CLASES.EXCEPCIONES
{
    public class CantidadInvalidaException: Exception
    {
        public CantidadInvalidaException(string? mensaje) : base(mensaje)
        {
        }
    }
}
