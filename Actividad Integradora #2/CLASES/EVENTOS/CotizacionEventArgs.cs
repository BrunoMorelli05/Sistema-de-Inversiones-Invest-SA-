using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_Integradora__2.CLASES.EVENTOS
{
    public class CotizacionEventArgs : EventArgs
    {
        public decimal NuevaCotizacion { get; set; }
        public CotizacionEventArgs(decimal nuevacotizacion)
        {
            NuevaCotizacion = nuevacotizacion;
        }
    }
}
