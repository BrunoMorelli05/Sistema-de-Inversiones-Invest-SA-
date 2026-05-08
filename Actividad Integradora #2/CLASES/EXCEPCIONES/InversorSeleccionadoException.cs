using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_Integradora__2.CLASES.EXCEPCIONES
{
    public class InversorSeleccionadoException: Exception
    {
        public InversorSeleccionadoException(string? mensaje) : base(mensaje)
        {
        }
    }
}
