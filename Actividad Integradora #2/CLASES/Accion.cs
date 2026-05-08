using Actividad_Integradora__2.CLASES.EVENTOS;
using Actividad_Integradora__2.CLASES.EXCEPCIONES;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Actividad_Integradora__2.CLASES
{
    public class Accion : ICloneable, IDisposable, IEnumerable<string>
    {
        // Campos
        private string codigo;
        private string denominacion;
        private decimal cotizacion;

        // Evento
        public delegate void CotizacionEventHandler(object sender, CotizacionEventArgs e);
        public event CotizacionEventHandler CotizacionCambiada;

        // Propiedades
        public string Codigo
        {
            get => codigo;
            set
            {
                string[] partes = value.Split('-');

                if (partes.Length != 3)
                    throw new CodigoInvalidoException("El codigo ingresado no cumple con el formato requerido. Reintente nuevamente");

                foreach (char c in partes[0])
                    if (!char.IsLetter(c) || !char.IsUpper(c))
                        throw new CodigoInvalidoException("La primer parte del codigo debe contener mayusculas. Reintente nuevamente");

                if (partes[1].Length != 4)
                    throw new CodigoInvalidoException("La segunda parte del codigo debe contener exactamente 4 digitos. Reintente nuevamente");

                foreach (char c in partes[1])
                    if (!char.IsDigit(c))
                        throw new CodigoInvalidoException("La segunda parte del codigo debe contener digitos. Reintente nuevamente");

                if (partes[2].Length != 4)
                    throw new CodigoInvalidoException("La tercer parte del codigo debe ser: letra-numero-letra-numero. Reintente nuevamente");

                if (!char.IsLetter(partes[2][0]) || !char.IsDigit(partes[2][1]) ||
                    !char.IsLetter(partes[2][2]) || !char.IsDigit(partes[2][3]))
                    throw new CodigoInvalidoException("La tercer parte del codigo debe ser: letra-numero-letra-numero. Reintente nuevamente");

                codigo = value;
            }
        }

        public string Denominacion
        {
            get => denominacion;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new DenominacionInvalidaException("La denominacion ingresada es nula o vacia. Reintente nuevamente");

                denominacion = value;
            }
        }

        public decimal Cotizacion
        {
            get => cotizacion;
            set
            {
                if (value <= 0)
                    throw new CotizacionInvalidaException("La cotizacion ingresada es invalida. Reintente nuevamente");

                cotizacion = value;
                CotizacionCambiada?.Invoke(this, new CotizacionEventArgs(value));
            }
        }

        public int Cantidad_Emitida { get; set; }
        public int Cantidad_Disponible { get; private set; }

        // Constructor
        public Accion(string codigo, string denominacion, decimal cotizacion, int cantidad_emitida)
        {
            Codigo = codigo;
            Denominacion = denominacion;
            Cantidad_Emitida = cantidad_emitida;
            Cantidad_Disponible = cantidad_emitida;
            Cotizacion = cotizacion;
        }

        // Métodos
        public void Comprar(int cantidad)
        {
            if (cantidad <= 0)
                throw new CantidadInvalidaException("La cantidad ingresada debe ser mayor a 0");

            if (cantidad > Cantidad_Disponible)
                throw new StockInsuficienteException("El stock es insuficiente");

            Cantidad_Disponible -= cantidad;
        }

        public void Vender(int cantidad)
        {
            if (cantidad <= 0)
                throw new CantidadInvalidaException("La cantidad ingresada debe ser mayor a 0");

            Cantidad_Disponible += cantidad;
        }
        public IEnumerator<string> GetEnumerator()
        {
            string[] partes = codigo.Split('-');
            yield return partes[0];
            yield return partes[1];
            yield return partes[2];
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public virtual object Clone() => this.MemberwiseClone();

        public void Dispose() => GC.SuppressFinalize(this);
        ~Accion()
        {
            Dispose();
        }
    }
}