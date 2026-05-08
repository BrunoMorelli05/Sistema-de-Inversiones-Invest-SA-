namespace Actividad_Integradora__2.CLASES.Comparadores.INVERSOR
{
    public class OrdenarPorLegajo : IComparer<Inversor>
    {
        public bool Ascendente { get; set; } = true;

        public int Compare(Inversor? x, Inversor? y)
        {
            int resultado = x.Legajo.CompareTo(y.Legajo);
            return Ascendente ? resultado : -resultado;
        }
    }
}