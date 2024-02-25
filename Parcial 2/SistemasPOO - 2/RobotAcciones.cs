public class Acciones
{
    protected string? _accion;
    protected string? _brazonIzquierdo;
    protected string? _brazonDerecho;
    protected string? _piernaIzquierda;
    protected string? _piernaDerecha;

    public string? Acsion
    {
        get { return _accion;}
        set { _accion = value;}
    }
    public string? BrazoIzquierdo
    {
        get { return _brazonIzquierdo;}
        set { _brazonIzquierdo = value;}
    }
    public string? BrazoDerecho
    {
        get { return _brazonDerecho;}
        set { _brazonDerecho = value;}
    }
    public string? PiernaIzquierda
    {
        get { return _piernaIzquierda;}
        set { _piernaIzquierda = value;}
    }
    public string? PiernaDerecha
    {
        get { return _piernaDerecha;}
        set { _piernaDerecha = value;}
    }
}