using System;
using System.Collections.Generic;

namespace Actividad_Integradora__2.CLASES.Comparadores.ACCION
{
    public class OrdenarPorCantidadEmitida : IComparer<Accion>
    {
        public bool Ascendente { get; set; } = true;

        public int Compare(Accion? x, Accion? y)
        {
            if (x == null || y == null) return 0;
            int resultado = x.Cantidad_Emitida.CompareTo(y.Cantidad_Emitida);
            return Ascendente ? resultado : -resultado;
        }
    }
}