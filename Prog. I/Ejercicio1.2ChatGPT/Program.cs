using Ejercicio1._2ChatGPT.Dominio;

public class Program
{
    static void Main(string[] args)
    {
        Estudiante p1=new Estudiante();
        p1.Nombre = "Lucas";
        p1.Edad = 18;
        p1.NumeroIdentificacion = 412238;
        Console.WriteLine("Elije una opcion");
        Console.WriteLine("1. Imprimir detalles del estudiante");
        Console.WriteLine("2. Actaulizar edad del estudiante");
        int opcion;
        while (true)
        {
            Console.Write("Ingresa tu elección (1 o 2): ");
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                if (opcion == 1 || opcion == 2)
                {
                    break; // Si la elección es válida, salir del bucle
                }
            }
            Console.WriteLine("Por favor, ingresa 1 o 2 como opción.");
        }

        // Aquí puedes continuar con el código dependiendo de la elección del usuario
        if (opcion == 1)
        {
            Console.WriteLine("Has elegido la opción 1.");
            Console.WriteLine(p1.ToString());
        }
        else if (opcion == 2)
        {
            Console.WriteLine("Has elegido la opción 2.");
            int opedad;
            Console.Write("A que edad quieres actualizar: ");
            int.TryParse(Console.ReadLine(), out opedad);
            Console.WriteLine(p1.ActualizarEdad(opedad));
            Console.WriteLine("Se actualizo la edad");
            Console.WriteLine(p1.ToString());
        }
      

    }
}