public class Movimientos
{
    protected string? _direccion;
    protected int? _velocidad;

    public string? Direccion
    {
        get { return _direccion; }
        set { _direccion = value; }
    }

    public int? Velocidad
    {
        get { return _velocidad; }
        set { _velocidad = value; }
    }
}