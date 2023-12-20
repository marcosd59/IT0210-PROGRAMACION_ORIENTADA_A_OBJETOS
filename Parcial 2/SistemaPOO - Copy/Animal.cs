using System.Diagnostics;

public class Animal : Movimientos
{
    protected string? _especie;
    protected string? _sexo;
    protected string? _familia;
    protected string? _edad;

    public string? Especie
    {
        get { return _especie; }
        set { _especie = value; }
    }

    public string? Sexo
    {
        get { return _sexo; }
        set { _sexo = value; }
    }

    public string? Familia
    {
        get { return _familia; }
        set { _familia = value; }
    }

    public string? Edad
    {
        get { return _edad; }
        set { _edad = value; }
    }
}

public class Animales : Animal
{
    protected List<Animal>? _animales;

    public List<Animal>? animales
    {
        get { return _animales; }
        set { _animales = value; }
    }

    public List<Animal> CrearAnimal(string especie, string sexo, string familia, string edad, string direccion, int vel)
    {
        if (animales is null)
            animales = new List<Animal>();

        Animal animal = new Animal() { Especie = especie, Sexo = sexo, Familia = familia, Edad = edad, Direccion = direccion, Velocidad = vel };
        animales.Add(animal);

        return animales;
    }
}

public class Pintar1
{
    public void Gato(List<Animal> animales)
    {
        Console.Clear();

        int ladoDerecho = 18;
        int ladoIzquierdo = 90;

        while (ladoDerecho < ladoIzquierdo)
        {
            Console.Clear();

            for (int i = 0; i < animales.Count; i++)
            {
                string sentido = animales[i].Direccion!;
                int vel = Convert.ToInt32(animales[i].Velocidad);

                if (sentido == "izquierda")
                {
                    PintarAnimal(sentido, ladoIzquierdo, animales[i]);
                    ladoIzquierdo = ladoIzquierdo - vel;
                }
                else
                {
                    PintarAnimal(sentido, ladoDerecho - 18, animales[i]);
                    ladoDerecho = ladoDerecho + vel;
                }
            }

            var stopwatch = Stopwatch.StartNew();
            Thread.Sleep(10); //tiempo de pausa
            stopwatch.Stop();
        }

        Console.ReadLine();
    }

    private bool PintarAnimal(string Sentido, int cursorIni, Animal animal)
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
            d.Escribir("   | /__/,|   (`\"", cursorIni, 1);
            d.Escribir("   |o o  |__ _)", cursorIni, 2);
            d.Escribir(" _.( T   )  `  /", cursorIni, 3);
            d.Escribir("((_ `^--' /_<  \"", cursorIni, 4);
            d.Escribir("`` `-'(((/  (((/", cursorIni, 5);
            d.Escribir("Edad: " + animal.Edad, cursorIni, 6);
            d.Escribir("Especie: " + animal.Especie, cursorIni, 7);
            d.Escribir("sexo: " + animal.Sexo, cursorIni, 8);
            d.Escribir("Familia: " + animal.Familia, cursorIni, 9);
            d.Escribir("Dirección: " + animal.Direccion, cursorIni, 10);
            d.Escribir("Velocidad: " + animal.Velocidad, cursorIni, 11);
        }
        else if (Sentido.ToLower() == "derecha")
        {
            d.Escribir("            ;'-.             ", cursorIni, 1);
            d.Escribir("`;-._        )  '---.._      ", cursorIni, 2);
            d.Escribir("  >  `-.__.-'          `'.__ ", cursorIni, 3);
            d.Escribir(" /_.-'-._         _,   ^ ---)", cursorIni, 4);
            d.Escribir(" `       `'------/_.'----``` ", cursorIni, 5);
            d.Escribir("Edad: " + animal.Edad, cursorIni, 6);
            d.Escribir("Especie: " + animal.Especie, cursorIni, 7);
            d.Escribir("sexo: " + animal.Sexo, cursorIni, 8);
            d.Escribir("Familia: " + animal.Familia, cursorIni, 9);
            d.Escribir("Dirección: " + animal.Direccion, cursorIni, 10);
            d.Escribir("Velocidad: " + animal.Velocidad, cursorIni, 11);
        }
        return true;
    }
}