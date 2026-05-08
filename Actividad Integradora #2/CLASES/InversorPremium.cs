using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_Integradora__2.CLASES
{
    public class InversorPremium : Inversor
    {
        public decimal ComisionHasta20000 { get; private set; }
        public decimal ComisionSobre20000 { get; private set; }
        public InversorPremium(string nombre, string apellido, string dni) : base(nombre, apellido, dni)
        {
        }

        public override string Tipo => "Premium";
        public override decimal CalcularComision(decimal monto)
        {
            if (monto <= 20000)
                return ComisionTramo1(monto);

            return ComisionTramo1(20000) + ComisionTramo2(monto - 20000);
        }

        private decimal ComisionTramo1(decimal monto)
        {
            decimal comision = monto * 0.01m;
            ComisionHasta20000 += comision;
            return comision;
        }

        private decimal ComisionTramo2(decimal excedente)
        {
            decimal comision = excedente * 0.005m;
            ComisionSobre20000 += comision;
            return comision;
        }
        public override object Clone() => MemberwiseClone();
    }
}
