using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_Integradora__2.CLASES.EXCEPCIONES
{
    public class CotizacionInvalidaException: Exception
    {
        public CotizacionInvalidaException(string? mensaje) : base(mensaje)
        {
        }
    }
}
