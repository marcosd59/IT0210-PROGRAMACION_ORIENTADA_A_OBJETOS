using System.Diagnostics;

public class Robot : Acciones
{
    protected string? _nombre;
    protected string? _material;
    protected string? _propietario;
    protected int? _id;

    public string? Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    public string? Material
    {
        get { return _material; }
        set { _material = value; }
    }

    public string? Propietario
    {
        get { return _propietario; }
        set { _propietario = value; }
    }

    public int? ID
    {
        get { return _id; }
        set { _id = value; }
    }
}

public class Robots : Robot
{
    protected List<Robot>? _robots;
    public List<Robot>? robots
    {
        get { return _robots; }
        set { _robots = value; }
    }

    public List<Robot> CrearRobot(string nombre, string material, string propietario, int id, string action)
    {
        if (robots is null)
            robots = new List<Robot>();

        Robot robot = new Robot() { Nombre = nombre, Material = material, Propietario = propietario, ID = id, Acsion = action};
        robots.Add(robot);

        return robots;
    }
}

public class Orden
{
    public void Mostrar(List<Robot> robots)
    {
        Console.WriteLine("");
        Console.WriteLine("ROBOTS DISPONIBLES");
        for (int i = 0; i < robots.Count; i++)
        {
            Console.WriteLine("");
            Console.WriteLine("Nombre: " + robots[i].Nombre);
            Console.WriteLine("Material: " + robots[i].Material);
            Console.WriteLine("Propietario: " + robots[i].Propietario);
            Console.WriteLine("Estado: " + robots[i].Acsion);
            Console.WriteLine("ID: " + robots[i].ID);
        }
        Seleccionar(robots);
    }

    public void Seleccionar(List<Robot> robots)
    {
        int tamanio = 0;
        for (int i = 0; i < robots.Count; i++) // Para saber el total de robots
        {
            tamanio++;
        }

        Console.Write("\n¿Quieres darle una instrucion a un robot? Y/N: ");
        string respuesta = Console.ReadLine()!;
        while (respuesta == "y" || respuesta == "Y")
        {
            Console.Write("\nIngrese el ID del robot a seleccionar: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            while (opcion > tamanio || opcion < 1)
            {
                Console.Write("No se encontro al robot, ingrese otra ID: ");
                opcion = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < 1; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("ROBOT SELECIONADO");
                Console.WriteLine("");
                Console.WriteLine("Nombre: " + robots[opcion-1].Nombre);
                Console.WriteLine("Material: " + robots[opcion-1].Material);
                Console.WriteLine("Propietario: " + robots[opcion-1].Propietario);
                Console.WriteLine("Estado: " + robots[opcion-1].Acsion);
                Console.WriteLine("ID: " + robots[opcion-1].ID);
            }

            Console.Write("\nIngrese el estado del robot: ");
            string estado = Console.ReadLine()!;

            for(int i = 0; i < 1; i++)
            {
                robots[opcion-1].Acsion = estado;
                Console.WriteLine("");
                Console.WriteLine("ACTUALIZADO");
                Console.WriteLine("");
                Console.WriteLine("Nombre: " + robots[opcion-1].Nombre);
                Console.WriteLine("Material: " + robots[opcion-1].Material);
                Console.WriteLine("Propietario: " + robots[opcion-1].Propietario);
                Console.WriteLine("Estado: " + robots[opcion-1].Acsion);
                Console.WriteLine("ID: " + robots[opcion-1].ID);
            }
            Console.Write("\n¿Quieres darle otra instrucion a un robot? Y/N: ");
            respuesta = Console.ReadLine()!;
        }

        Console.WriteLine("");
        Console.WriteLine("IMPRIMIENDO ROBOTS");
        for (int i = 0; i < robots.Count; i++)
        {
            Console.WriteLine("");
            Console.WriteLine("Nombre: " + robots[i].Nombre);
            Console.WriteLine("Material: " + robots[i].Material);
            Console.WriteLine("Propietario: " + robots[i].Propietario);
            Console.WriteLine("Estado: " + robots[i].Acsion);
            Console.WriteLine("ID: " + robots[i].ID);
        }
    }
}