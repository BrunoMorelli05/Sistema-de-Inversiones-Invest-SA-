using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_Integradora__2.CLASES.EXCEPCIONES
{
    public class StockInsuficienteException: Exception
    {
        public StockInsuficienteException(string? mensaje) : base(mensaje)
        {
        }
    }
}
