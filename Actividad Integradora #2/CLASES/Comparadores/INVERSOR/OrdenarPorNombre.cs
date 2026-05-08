using Actividad_Integradora__2.CLASES;

public class OrdenarPorNombre : IComparer<Inversor>
{
    public bool Ascendente { get; set; } = true;

    public int Compare(Inversor x, Inversor y)
    {
        int resultado = string.Compare(x.Nombre, y.Nombre);
        return Ascendente ? resultado : -resultado;
    }
}