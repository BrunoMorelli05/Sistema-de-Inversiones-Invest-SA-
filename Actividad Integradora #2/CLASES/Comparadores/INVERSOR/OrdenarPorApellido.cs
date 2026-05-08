using Actividad_Integradora__2.CLASES;

public class OrdenarPorApellido : IComparer<Inversor>
{
    public bool Ascendente { get; set; } = true;

    public int Compare(Inversor x, Inversor y)
    {
        int resultado = string.Compare(x.Apellido, y.Apellido);
        return Ascendente ? resultado : -resultado;
    }
}