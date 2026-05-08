using Actividad_Integradora__2.CLASES;

public class OrdenarPorCotizacion : IComparer<Accion>
{
    public bool Ascendente { get; set; } = true;

    public int Compare(Accion? x, Accion? y)
    {
        int resultado = x.Cotizacion.CompareTo(y.Cotizacion);
        return Ascendente ? resultado : -resultado;
    }
}