using Actividad_Integradora__2.CLASES;

namespace Actividad_Integradora__2.CLASES.Comparadores.ACCION
{
    public class OrdenarPorDenominacion : IComparer<Accion>
    {
        public bool Ascendente { get; set; } = true;

        public int Compare(Accion? x, Accion? y)
        {
            int resultado = string.Compare(x.Denominacion, y.Denominacion);
            return Ascendente ? resultado : -resultado;
        }
    }
}