using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_Integradora__2.CLASES.Comparadores.ACCION
{
    public class OrdenarPorCodigo : IComparer<Accion>
    {
        public bool Ascendente { get; set; } = true;
        public int Compare(Accion? x, Accion? y)
        {
            int resultado = string.Compare(x.Codigo, y.Codigo);
            return Ascendente ? resultado : -resultado;

        }
    }
}
