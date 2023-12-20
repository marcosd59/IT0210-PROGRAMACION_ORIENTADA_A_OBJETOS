Menu objMenu = new Menu();
string r = objMenu.IniciarMenu();

switch (r)
{
    case "1":
        Semaforo objSemaforo = new Semaforo();
        EstableceColor objColor = new EstableceColor();
        objColor.CambiaColor("verde");
    break;

    case "2":
        Vehiculos objVehiculos = new Vehiculos();
        List<Vehiculo> vehiculos = objVehiculos.CrearVehiculo("1997", "Auto", "AXR-1326", "El profe", "izquierda", 1);
        vehiculos = objVehiculos.CrearVehiculo("2020", "Auto", "DNN-8755", "Benito C.", "derecha", 4);
        Pintar objPintar = new Pintar();
        objPintar.Auto(vehiculos);
    break;

    case "3":
        Animales objAnimales = new Animales();
        List<Animal> animales = objAnimales.CrearAnimal("Gato", "Masculino", "Mamifero", "5 años", "izquierda", 1);
        animales = objAnimales.CrearAnimal("Delfin", "Masculino", "Mamifero", "10 años", "derecha", 2);
        Pintar1 objPintar1 = new Pintar1();
        objPintar1.Gato(animales);
    break;

    case "4":
        Robots objRobots = new Robots();
        List<Robot> robots = objRobots.CrearRobot("Robot 1", "Acero", "Marcos", 1, "quieto");
        robots = objRobots.CrearRobot("Robot 2", "Plastico", "Juan", 2, "quieto");
        robots = objRobots.CrearRobot("Robot 3", "Aluminio", "Pedro", 3, "quieto");

        Orden objOrden = new Orden();
        objOrden.Mostrar(robots);
    break;
}