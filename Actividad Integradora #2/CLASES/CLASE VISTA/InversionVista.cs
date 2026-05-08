using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_Integradora__2.CLASES.CLASE_VISTA
{
    public class InversionVista
    {
        public string Codigo { get; set; }
        public string Denominacion { get; set; }
        public decimal Cotizacion { get; set; }
        public int Cantidad_Emitida { get; set; }
        public int Cantidad_Disponible { get; set; }
        public int Cantidad { get; set; }
        public decimal Valor_Total => Cantidad * Cotizacion;

        public InversionVista(Inversion inversion)
        {
            Codigo = inversion.Accion.Codigo;
            Denominacion = inversion.Accion.Denominacion;
            Cotizacion = inversion.Accion.Cotizacion;
            Cantidad_Emitida = inversion.Accion.Cantidad_Emitida;
            Cantidad_Disponible = inversion.Accion.Cantidad_Disponible;
            Cantidad = inversion.Cantidad;
        }
    }
}
