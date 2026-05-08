using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_Integradora__2.CLASES
{
    public class InversorComun : Inversor
    {
        public InversorComun(string nombre, string apellido, string dni) : base(nombre, apellido, dni)
        {
        }

        public override string Tipo => "Comun";
        public override decimal CalcularComision(decimal monto) => monto * 0.01m;

        public override object Clone() => MemberwiseClone();
    }
}
