public class Semaforo
{
    protected bool? _luzVerde;
    protected bool? _luzAmarilla;
    protected bool? _luzRoja;

    public bool? LuzVerde
    {
        get { return _luzVerde; }
        set { _luzVerde = value; }
    }
    public bool? LuzAmarilla
    {
        get { return _luzAmarilla; }
        set { _luzAmarilla = value; }
    }
    public bool? LuzRoja
    {
        get { return _luzRoja; }
        protected set { _luzRoja = value; }
    }
}
public class EstableceColor : Semaforo
{
    public void CambiaColor(string? color)
    {
        switch (color)
        {
            case "verde":
                focoVerde(true);
                focoAmarillo(false);
                focoRojo(false);
                break;
            case "amarilla":
                focoVerde(false);
                focoAmarillo(true);
                focoRojo(false);
            break;
            case "roja":
                focoVerde(false);
                focoAmarillo(false);
                focoRojo(true);
            break;
        }
    }
    private void focoVerde(bool Prende)
    {
        LuzVerde = Prende;
    }
    private void focoAmarillo(bool Prende)
    {
        LuzAmarilla = Prende;
    }
    private void focoRojo(bool Prende)
    {
        LuzRoja = Prende;
    }
}