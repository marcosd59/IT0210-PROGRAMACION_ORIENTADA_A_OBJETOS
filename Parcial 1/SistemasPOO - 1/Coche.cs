using System;

namespace SistemasPOO;

public class Vehiculo
{
    private string? _titulo;
    protected string? _modelo;
    protected string? _tipo;
    protected string? _placa;
    protected string? _dueno;

    public string? Modelo
    {
        get { return _modelo; }
        set { _modelo = value; }
    }
    public string? Tipo
    {
        get { return _tipo; }
        set { _tipo = value; }
    }
    public string? Placa
    {
        get { return _placa; }
        set { _placa = value; }
    }
    public string? Dueno
    {
        get { return _dueno; }
        set { _dueno = value; }
    }
    public string? tituloJuego
    {
        get{ return _titulo; }
        set{ _titulo = value; }
    }
    public void ImpTitulo_4()
    {
        tituloJuego = "Coche Semáforo";
    }
}

public class Vehiculos : Vehiculo
{
    protected List<Vehiculo>? _vehiculos;
    public List<Vehiculo>? vehiculos
    {
        get { return _vehiculos; }
        set { _vehiculos = value; }
    }
    public List<Vehiculo> CrearVehiculo(string modelo, string tipo, string placa, string dueno)
    {
        if (vehiculos is null)
        {
            Console.WriteLine("entra");
            vehiculos = new List<Vehiculo>();
        }
        Vehiculo vehiculo = new Vehiculo() { Modelo = modelo, Tipo = tipo, Placa = placa, Dueno = dueno };
        vehiculos.Add(vehiculo);
        return vehiculos;
    }
}

public class Pintar : Vehiculos
{
    protected int cursorIni;
    public void Auto(List<Vehiculo> vehiculos)
    {
        Console.Clear();

        // Console.WriteLine("La información del Menú recibida es: " + vehiculos[0].Dueno);
        // Console.WriteLine("vehiculos: ", vehiculos.Count);
        // if (vehiculos != null)
        // {
        //     int x = 1;

        //     // foreach (Vehiculo vehiculo in vehiculos)
        //     // {
        //     //     Console.WriteLine("entra: ", x);
        //     //     if (vehiculo.Tipo.ToLower() == "auto")
        //     //         PintarAuto("izquierda");
        //     // }
        // }

        PintarAuto("izquierda");
        Console.ReadLine();
    }
    private bool PintarAuto(string Sentido)
    {
        if (Sentido.ToLower() != "izquierda" && Sentido.ToLower() == "derecha")
        {
            return false;
        }

        Dibujar d = new Dibujar();
        d.origRow = Console.CursorTop;
        d.origCol = Console.CursorLeft;

        if (Sentido.ToLower() == "izquierda")
        {
            // Fila 0
            // for (int i = cursorIni - 5; i >= cursorIni - 13; i--)
            //     d.Escribir("", i, 0);
            cursorIni = 90;
            d.Escribir("       ________     ", cursorIni, 0);
            d.Escribir("  ____| (_)    |___ ", cursorIni, 1);
            d.Escribir("<|                 |", cursorIni, 2);
            d.Escribir(" +--(.)------(.)---+", cursorIni, 3);
        }
        else if (Sentido.ToLower() == "derecha")
        {
            cursorIni = 0;
            d.Escribir("     ________       ", cursorIni, 0);
            d.Escribir(" ___|    (_) |____  ", cursorIni, 1);
            d.Escribir("|                 |>", cursorIni, 2);
            d.Escribir("+---(.)------(.)--+ ", cursorIni, 3);
        }

        //01234567890123456789
        //     ________             0
        // ___|    (_) |____        1
        //|                 |>      2
        //+---(.)------(.)--+       3

        return true;
    }
}