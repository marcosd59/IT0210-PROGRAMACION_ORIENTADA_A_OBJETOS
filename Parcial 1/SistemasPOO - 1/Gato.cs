using System;

namespace SistemasPOO;

public class Gato
{
    private string? _titulo;
    public string? tituloJuego
    {
        get{ return _titulo; }

        set{ _titulo = value; }
    }
    public void ImpTitulo_3()
    {
        tituloJuego = "Gato";
    }
}