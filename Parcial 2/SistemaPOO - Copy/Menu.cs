public class MenuItem
{
    protected string? _nomMenu;
    protected int? _id;

    public string? NomMenu
    {
        get { return _nomMenu; }
        set { _nomMenu = value; }
    }

    public int? ID
    {
        get { return _id; }
        set { _id = value; }
    }
}

public class Menu : MenuItem
{
    protected static int longMax;
    protected List<MenuItem>? _items;
    protected List<MenuItem>? Items
    {
        get { return _items; }
        set { _items = value; }
    }

    protected void EstablecerMenu()
    {
        Items = new List<MenuItem>();

        MenuItem Item = new MenuItem() { NomMenu = "Juego del semáforo", ID = 1 };
        Items.Add (Item);
        Item = new MenuItem() { NomMenu = "Choque de 2 vehiculos", ID = 2 };
        Items.Add (Item);
        Item = new MenuItem() { NomMenu = "Choque de 2 animales", ID = 3 };
        Items.Add (Item);
        Item = new MenuItem() { NomMenu = "Controlar Robots", ID = 4 };
        Items.Add (Item);
    }

    public string IniciarMenu()
    {
        bool respOk = false;
        string resp = "";

        while (!respOk)
        {
            resp = MostrarMenu();
            int totalItems = Items!.Count;
            for (int i = 1; i <= totalItems; i++)
            {
                if (resp == i.ToString())
                {
                    respOk = true;
                    break;
                }
            }

            if (!respOk)
            {
                Console.WriteLine("selección incorrecta... (presione cualquier tecla para continuar)");
                Console.ReadLine();
            }
        }

        return resp;
    }

    public string MostrarMenu()
    {
        Dibujar d = new Dibujar();

        // Borrar pantalla para iniciar limpio y establecer los valores del menú
        Console.Clear();
        d.origRow = Console.CursorTop;
        d.origCol = Console.CursorLeft;
        EstablecerMenu();

        // Buscar la longitud del menú más largo
        longMax = 0;
        foreach (MenuItem item in Items!)
        {
            string nomCompleto = item.ID.ToString() + ".- " + item.NomMenu;
            if (nomCompleto.Length > longMax) longMax = nomCompleto.Length;
        }

        longMax = longMax + 4;

        // Dibujar parte superior

        for (int i = 1; i <= longMax; i++) d.Escribir("-", i, 0);

        // Dibujar lado izquierdo y nombre del menú
        d.Escribir("+", 0, 0);
        int j = 1;
        foreach (MenuItem item in Items)
        {
            string nomCompleto = item.ID.ToString() + ".- " + item.NomMenu;
            d.Escribir("| " + nomCompleto, 0, j);
            j++;
        }
        d.Escribir("+", 0, j);

        // Dibujar lado izquierdo
        for (int i = j; i > 0; i--) d.Escribir("|", longMax, i);
        d.Escribir("+", longMax, 0);

        // Dibujar la base
        for (int i = 1; i <= longMax; i++) d.Escribir("-", i, j);
        d.Escribir("+", longMax, j);

        d.Escribir("Elije una opción del menú: ", 0, j + 2);
        return Console.ReadLine()!;
    }
}