using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemasPOO;
public  class Semaforo
{
    public class Foco
    {
        public int opcion = 0;
        protected string? _luz = "Apagado";
        protected string? Luz
        {
            get{ return _luz; }
            set { _luz = value; }
        }
        protected bool encendido()
        {
            Luz = "Encendido";
            return true;
        }
        protected bool apagado()
        {
            Luz = "Apagado";
            return false;
        }
    }
    public class Semaforos:Foco
    {
        public void JuegoSemaforo()
        {
            var verde = new Semaforos();
            var rojo = new Semaforos();
            var amarillo = new Semaforos();

            while(opcion != 4)
            {
                Console.WriteLine("\nVerde: " + verde.Luz);
                Console.WriteLine("Amarillo: " + amarillo.Luz);
                Console.WriteLine("Rojo: " + rojo.Luz);
                Console.WriteLine("\n======Opciones======");
                Console.WriteLine("1. Encender Verde");
                Console.WriteLine("2. Encender Amarillo");
                Console.WriteLine("3. Encender Rojo");
                Console.WriteLine("4. Salir");
                Console.WriteLine("====================");
                Console.Write("> Introducir opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

                switch(opcion)
                {
                    case 1:
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("");
                        Console.WriteLine("[*] " + verde.encendido());
                        Console.WriteLine("[-] " + amarillo.apagado());
                        Console.WriteLine("[-] " + rojo.apagado());
                        break;
                    case 2:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("");
                        Console.WriteLine("[-] " + verde.apagado());
                        Console.WriteLine("[*] " + amarillo.encendido());
                        Console.WriteLine("[-] " + rojo.apagado());
                        break;
                    case 3:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("");
                        Console.WriteLine("[-] " + verde.apagado());
                        Console.WriteLine("[-] " + amarillo.apagado());
                        Console.WriteLine("[*] " + rojo.encendido());
                        break;
                    default:
                    break;
                }
            }
        }
    }
    private string? _titulo;
    public string? tituloJuego
    {
        get{ return _titulo; }
        set{ _titulo = value; }
    }
    public void ImpTitulo_1()
    {
        tituloJuego = "Semaforo";
    }
}