using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_Integradora__2.CLASES.EXCEPCIONES
{
    public class InversionNoEncontradaException: Exception
    {
        public InversionNoEncontradaException(string mensaje) : base(mensaje)
        {
        }
    }
}
