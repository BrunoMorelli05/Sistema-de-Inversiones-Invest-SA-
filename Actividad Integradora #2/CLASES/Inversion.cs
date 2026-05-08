using System;
using System.Collections.Generic;
using System.Text;
using Actividad_Integradora__2.CLASES.EXCEPCIONES;
namespace Actividad_Integradora__2.CLASES
{
    public class Inversion: IDisposable
    {
        public Accion Accion { get; set; }
        public int Cantidad { get; set; }
        public decimal ValorTotal => Accion.Cotizacion * Cantidad;

        public Inversion(Accion _accion, int cantidad)
        {
            Accion = _accion;
            Cantidad = cantidad;
        }
        public void AgregarCantidad(int cantidad)
        {
            if (cantidad <= 0)
            {
                throw new CantidadInvalidaException("La cantidad ingresada debe ser mayor a 0");
            }
            Cantidad += cantidad;
        }
        public void RestarCantidad(int cantidad)
        {
            if (cantidad <= 0)
            {
                throw new CantidadInvalidaException("La cantidad ingresada debe ser mayor a 0");
            }
            Cantidad -= cantidad;
        }
        public void Dispose() => GC.SuppressFinalize(this);

        ~Inversion()
        {
            Dispose();
        }
    }
}
