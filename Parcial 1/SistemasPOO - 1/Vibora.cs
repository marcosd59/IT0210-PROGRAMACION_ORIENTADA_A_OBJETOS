using System;

namespace SistemasPOO;

public class Vibora
{
    private string? _titulo;
    public string? tituloJuego
    {
        get{ return _titulo; }

        set{ _titulo = value; }
    }
    public void ImpTitulo_2()
    {
        tituloJuego = "Vibora";
    }
}