using Actividad_Integradora__2.CLASES.EXCEPCIONES;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Actividad_Integradora__2.CLASES
{
    public abstract class Inversor : ICloneable, IDisposable
    {
        // Campos
        private static int contador;
        private string nombre;
        private string apellido;
        private string dni;

        // Propiedades
        public int Legajo { get; private set; }

        public List<Inversion> Inversiones { get; set; } = new List<Inversion>();

        public decimal TotalInvertido => Inversiones.Sum(x => x.Cantidad * x.Accion.Cotizacion);
        
        public abstract string Tipo { get; }

        public decimal ComisionCobrada { get; protected set; }

        public string Nombre
        {
            get => nombre;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new NombreInvalidoException("El nombre ingresado es nulo o vacio. Reintente nuevamente");

                foreach (char c in value)
                    if (!char.IsLetter(c))
                        throw new NombreInvalidoException("El nombre ingresado no contiene letras. Reintente nuevamente");

                nombre = value;
            }
        }

        public string Apellido
        {
            get => apellido;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ApellidoInvalidoException("El apellido ingresado es nulo o vacio. Reintente nuevamente");

                foreach (char c in value)
                    if (!char.IsLetter(c))
                        throw new ApellidoInvalidoException("El apellido ingresado no contiene letras. Reintente nuevamente");

                apellido = value;
            }
        }

        public string DNI
        {
            get => dni;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new DNIInvalidoException("El DNI ingresado es nulo o vacio. Reintente nuevamente");

                if (value.Length < 7 || value.Length > 8)
                    throw new DNIInvalidoException("El DNI ingresado es invalido. Reintente nuevamente");

                foreach (char c in value)
                    if (!char.IsDigit(c))
                        throw new DNIInvalidoException("El DNI ingresado no contiene numeros. Reintente nuevamente");

                dni = value;
            }
        }

        // Constructor
        public Inversor(string nombre, string apellido, string dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            contador++;
            Legajo = contador;
        }


        public void Comprar(Accion accion, int cantidad)
        {
            accion.Comprar(cantidad);

            var inversionExistente = Inversiones.Find(i => i.Accion == accion);
            if (inversionExistente != null)
                inversionExistente.AgregarCantidad(cantidad);
            else
            {
                Inversiones.Add(new Inversion(accion, cantidad));
                accion.CotizacionCambiada += Accion_CotizacionCambiada;
            }

            ComisionCobrada += CalcularComision(accion.Cotizacion * cantidad);
        }

        public void Vender(Accion accion, int cantidad)
        {
            var inversion = Inversiones.Find(i => i.Accion == accion);

            if (inversion == null)
                throw new InversionNoEncontradaException("El inversor no posee esa acción.");

            if (cantidad > inversion.Cantidad)
                throw new CantidadInvalidaException("No puede vender más acciones de las que posee.");

            accion.Vender(cantidad);

            if (inversion.Cantidad - cantidad == 0)
            {
                Inversiones.Remove(inversion);
                accion.CotizacionCambiada -= Accion_CotizacionCambiada;
            }
            else
                inversion.RestarCantidad(cantidad);

            ComisionCobrada += CalcularComision(accion.Cotizacion * cantidad);
        }

        private void Accion_CotizacionCambiada(object sender, EVENTOS.CotizacionEventArgs e) 
        {
        }

        public abstract decimal CalcularComision(decimal monto);

        public virtual object Clone() => this.MemberwiseClone();
        public void Dispose() => GC.SuppressFinalize(this);

        ~Inversor()
        {
            Dispose();
        }
    }
}