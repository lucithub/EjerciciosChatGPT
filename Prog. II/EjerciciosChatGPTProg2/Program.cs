using EjerciciosChatGPTProg2;
using EjerciciosChatGPTProg2.Domain;

class Program
{
    static void Main(string[] args)
    {
        //EJERCICIO 1
        // Crear instancias de Auto y Moto
        //IVehiculo miCoche = new Auto();
        //IVehiculo miMoto = new Moto();

        //// Pruebas con el coche
        //Console.WriteLine("Pruebas con el coche:");
        //Console.WriteLine(miCoche.Arrancar());
        //Console.WriteLine(miCoche.Acelerar(100));
        //Console.WriteLine(miCoche.Detener());

        //Console.WriteLine();

        //// Pruebas con la moto
        //Console.WriteLine("Pruebas con la moto:");
        //Console.WriteLine(miMoto.Arrancar()); 
        //Console.WriteLine(miMoto.Acelerar(100)); 
        //Console.WriteLine(miMoto.Detener());

        //EJERCICIO 2
        //Crear auto y moto para que muestren la velocidad actual y el modelo
        //IVehiculo miAuto = new Auto("Mercedes AMG");
        //miAuto.VelocidadActual = 220;
        //Console.WriteLine($"Velocidad actual: {miAuto.Acelerar(120)}");
        //Console.WriteLine($"Modelo: {miAuto.Modelo}");
        //Console.WriteLine($"Velocidad actual: {miAuto.Detener()}");

        //Console.WriteLine();

        //IVehiculo miMoto2 = new Moto("Ducati Monster");
        //miMoto2.VelocidadActual = 180;
        //Console.WriteLine($"Velocidad actual: {miMoto2.Acelerar(100)}");
        //Console.WriteLine($"Modelo: {miMoto2.Modelo}");
        //Console.WriteLine($"Velocidad actual: {miMoto2.Detener()}");

        //EJERCICIO 3
        //Crear un Tesla y mostrar que puede activar el autopilot y cargar la batería
        //Tesla miTesla = new Tesla();
        //Console.WriteLine($"Activar Autopilot: {miTesla.ActivarAutopilot()}");
        //Console.WriteLine($"Cargar la bateria: {miTesla.CargarBateria()}");

        //EJERCICIO 4
        //Crear un avión y mostrar que puede despegar e iniciar el viaje
        Avion miAvion = new Avion();
        Console.WriteLine($"Despegar: {miAvion.Despegar()}");
        Console.WriteLine($"Iniciar viaje: {miAvion.IniciarViaje()}");
    }
}