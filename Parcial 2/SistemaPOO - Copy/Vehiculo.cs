using System.Diagnostics;

public class Vehiculo : Movimientos
{
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
}

public class Vehiculos : Vehiculo
{
    protected List<Vehiculo>? _vehiculos;
    public List<Vehiculo>? vehiculos
    {
        get { return _vehiculos; }
        set { _vehiculos = value; }
    }

    public List<Vehiculo> CrearVehiculo(string modelo, string tipo, string placa, string dueno, string direccion, int vel)
    {
        if (vehiculos is null)
            vehiculos = new List<Vehiculo>();

        Vehiculo vehiculo = new Vehiculo() { Modelo = modelo, Tipo = tipo, Placa = placa, Dueno = dueno, Direccion = direccion, Velocidad = vel };
        vehiculos.Add(vehiculo);

        return vehiculos;
    }
}

public class Pintar
{
    public void Auto(List<Vehiculo> vehiculos)
    {
        Console.Clear();

        int ladoDerecho = 18;
        int ladoIzquierdo = 90;

        while (ladoDerecho < ladoIzquierdo)
        {
            Console.Clear();

            for (int i = 0; i < vehiculos.Count; i++)
            {
                string sentido = vehiculos[i].Direccion!;
                int vel = Convert.ToInt32(vehiculos[i].Velocidad);

                if (sentido == "izquierda")
                {
                    PintarMoto(sentido, ladoIzquierdo, vehiculos[i]);
                    ladoIzquierdo = ladoIzquierdo - vel;
                }
                else
                {
                    PintarMoto(sentido!, ladoDerecho - 18, vehiculos[i]);
                    ladoDerecho = ladoDerecho + vel;
                }
            }

            var stopwatch = Stopwatch.StartNew();
            Thread.Sleep(10); //tiempo de pausa
            stopwatch.Stop();
        }

        Console.ReadLine();
    }

    private bool PintarAuto(string Sentido, int cursorIni, Vehiculo vehiculo)
    {
        if (Sentido.ToLower() != "izquierda" && Sentido.ToLower() != "derecha")
        {
            return false;
        }

        Dibujar d = new Dibujar();
        d.origRow = Console.CursorTop;
        d.origCol = Console.CursorLeft;

        if (Sentido.ToLower() == "izquierda")
        {
            d.Escribir("       ________     ", cursorIni, 2);
            d.Escribir("  ____| (_)    |___ ", cursorIni, 3);
            d.Escribir("<|                 |", cursorIni, 4);
            d.Escribir(" +--(.)------(.)---+", cursorIni, 5);
            d.Escribir("Dueño: " + vehiculo.Dueno, cursorIni, 6);
            d.Escribir("Modelo: " + vehiculo.Modelo, cursorIni, 7);
            d.Escribir("Tipo: " + vehiculo.Tipo, cursorIni, 8);
            d.Escribir("Placa: " + vehiculo.Placa, cursorIni, 9);
            d.Escribir("Dirección: " + vehiculo.Direccion, cursorIni, 10);
            d.Escribir("Velocidad: " + vehiculo.Velocidad, cursorIni, 11);
        }
        else if (Sentido.ToLower() == "derecha")
        {
            d.Escribir("     ________       ", cursorIni, 2);
            d.Escribir(" ___|    (_) |____  ", cursorIni, 3);
            d.Escribir("|                 |>", cursorIni, 4);
            d.Escribir("+---(.)------(.)--+ ", cursorIni, 5);
            d.Escribir("Dueño: " + vehiculo.Dueno, cursorIni, 6);
            d.Escribir("Modelo: " + vehiculo.Modelo, cursorIni, 7);
            d.Escribir("Tipo: " + vehiculo.Tipo, cursorIni, 8);
            d.Escribir("Placa: " + vehiculo.Placa, cursorIni, 9);
            d.Escribir("Dirección: " + vehiculo.Direccion, cursorIni, 10);
            d.Escribir("Velocidad: " + vehiculo.Velocidad, cursorIni, 11);
        }

        //01234567890123456789
        //     ________             0
        // ___|    (_) |____        1
        //|                 |>      2
        //+---(.)------(.)--+       3

        return true;
    }

    private bool PintarMoto(string Sentido, int cursorIni, Vehiculo vehiculo)
    {
        if (Sentido.ToLower() != "izquierda" && Sentido.ToLower() != "derecha")
        {
            return false;
        }

        Dibujar d = new Dibujar();
        d.origRow = Console.CursorTop;
        d.origCol = Console.CursorLeft;

        if (Sentido.ToLower() == "izquierda")
        {
            d.Escribir("      /_)\\      ", cursorIni, 0);
            d.Escribir("      / \\      ", cursorIni, 1);
            d.Escribir("   _,=/\\ \\ ==", cursorIni, 2);
            d.Escribir(" o//  //==--;", cursorIni, 3);
            d.Escribir("  \\___\\__\\_/", cursorIni, 4);
            d.Escribir("   (0)     (0) =@ ", cursorIni, 5);
            d.Escribir("Dueño: " + vehiculo.Dueno, cursorIni, 6);
            d.Escribir("Modelo: " + vehiculo.Modelo, cursorIni, 7);
            d.Escribir("Tipo: " + vehiculo.Tipo, cursorIni, 8);
            d.Escribir("Placa: " + vehiculo.Placa, cursorIni, 9);
            d.Escribir("Dirección: " + vehiculo.Direccion, cursorIni, 10);
            d.Escribir("Velocidad: " + vehiculo.Velocidad, cursorIni, 11);
        }
        else if (Sentido.ToLower() == "derecha")
        {
            d.Escribir("       (_\\       ", cursorIni, 0);
            d.Escribir("       / \\       ", cursorIni, 1);
            d.Escribir("   == / /\\=,_    ", cursorIni, 2);
            d.Escribir("  ;--==\\\\  \\\\o", cursorIni, 3);
            d.Escribir("  /____//__/__\\ ", cursorIni, 4);
            d.Escribir("@= (0)     (0)    ", cursorIni, 5);
            d.Escribir("Dueño: " + vehiculo.Dueno, cursorIni, 6);
            d.Escribir("Modelo: " + vehiculo.Modelo, cursorIni, 7);
            d.Escribir("Tipo: " + vehiculo.Tipo, cursorIni, 8);
            d.Escribir("Placa: " + vehiculo.Placa, cursorIni, 9);
            d.Escribir("Dirección: " + vehiculo.Direccion, cursorIni, 10);
            d.Escribir("Velocidad: " + vehiculo.Velocidad, cursorIni, 11);
        }

//        (_\
//        / \
//   `== / /\=,_
//    ;--==\\  \\o
//    /____//__/__\
//  @=`(0)     (0)

        return true;
    }
}