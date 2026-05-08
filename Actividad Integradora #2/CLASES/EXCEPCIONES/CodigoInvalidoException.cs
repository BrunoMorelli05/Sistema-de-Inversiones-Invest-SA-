using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_Integradora__2.CLASES.EXCEPCIONES
{
    public class CodigoInvalidoException: Exception
    {
        public CodigoInvalidoException(string? mensaje) : base(mensaje)
        {

        }
    }
}
