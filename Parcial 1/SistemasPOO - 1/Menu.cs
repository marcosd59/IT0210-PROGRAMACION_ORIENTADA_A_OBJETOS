using System;

namespace SistemasPOO;

public class ItemMenu
{
    protected string? _nomMenu;
    protected int? _id;
    public string[] _Arreglo = new string[3];
    public string? NomMenu
    {
        get
        {
            return _nomMenu;
        }

        protected set
        {
            _nomMenu = value;
        }
    }
    public int? ID
    {
        get
        {
            return _id;
        }

         set
        {
            _id = value;
        }
    }
    public void ObtenerMenu()
    {
        NomMenu = "Mi menu 1";
        ID = 1;
    }
    public void ObtenerInfo()
    {
        for (int i = 0; i < 3; i++)
        {
            // _Arreglo[i] = Console.ReadLine();
        }
    }
    public void MostrarInfo()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Menu: {0}", _Arreglo[i]);
        }
    }
}