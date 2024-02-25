using System;

namespace SistemasPOO;

class Program
{
    public static void Main (string[] args)
    {
        Semaforo objSem = new Semaforo();
        objSem.ImpTitulo_1();

        Semaforo.Semaforos objSema = new Semaforo.Semaforos();

        Vibora objVib = new Vibora();
        objVib.ImpTitulo_2();

        Gato objGato = new Gato();
        objGato.ImpTitulo_3();

        Vehiculo objCoche = new Vehiculo();
        objCoche.ImpTitulo_4();

        int opcion = 0;

        do
        {
            Console.WriteLine("");
            Console.WriteLine("\n+--------Menu--------+");
            Console.WriteLine("| 1. Semaforo        |");
            Console.WriteLine("| 2. Vibora          |");
            Console.WriteLine("| 3. Juego Gato      |");
            Console.WriteLine("| 4. Coche Semaforo  |");
            Console.WriteLine("| 5. Salir           |");
            Console.WriteLine("+--------------------+\n");
            Console.Write("> Digite una opcion: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch(opcion)
            {
                case 1:
                Console.WriteLine("\nBienvenido al juego: " + objSem.tituloJuego);
                objSema.JuegoSemaforo();
                break;
                case 2:
                    Console.WriteLine("\nBienvenido al juego: " + objVib.tituloJuego);
                break;
                case 3:
                    Console.WriteLine("\nBienvenido al juego: " + objGato.tituloJuego);
                break;
                case 4:
                    Console.WriteLine("\nBienvenido al juego: " + objCoche.tituloJuego);
                    Vehiculos objVehiculos = new Vehiculos();
                    List<Vehiculo> vehiculos = objVehiculos.CrearVehiculo("1997", "Auto", "AXR-1326", "Honda");
                    vehiculos = objVehiculos.CrearVehiculo("2020", "Auto", "DNN-8755", "Audi");
                    Pintar objPintar = new Pintar();
                    objPintar.Auto(vehiculos);
                break;
            }
        }while(opcion != 5);
    }
}