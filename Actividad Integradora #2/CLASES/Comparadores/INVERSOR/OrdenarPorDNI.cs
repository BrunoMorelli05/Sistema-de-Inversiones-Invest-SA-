using Actividad_Integradora__2.CLASES;

public class OrdenarPorDNI : IComparer<Inversor>
{
    public bool Ascendente { get; set; } = true;

    public int Compare(Inversor x, Inversor y)
    {
        int resultado = string.Compare(x.DNI, y.DNI);
        return Ascendente ? resultado : -resultado;
    }
}