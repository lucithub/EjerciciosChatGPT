using Ejercicio6y7ChatGPT.Dominio;

public class Program
{
    static void Main(string[] args)
    {
        Libro l1 = new Libro("La tercera. Los héroes", "Alejandro Wall", 2023, 9789504984528);
        Libro l2 = new Libro("Odisea", "Homero", 1851, 9780060904791);
        Libro l3 = new Libro("Don Quijote de la Mancha", "Miguel de Cervantes", 1065, 9788408061052);
        Console.WriteLine(l1.ToString());
        Libro[] arrlibros;
        arrlibros = new Libro[3];
        arrlibros[0]= l1;
        arrlibros[1]= l2;
        arrlibros[2]= l3;
        Console.WriteLine("Arreglo de Libros:");
        Console.WriteLine(arrlibros[1].ToString());
        Console.WriteLine(arrlibros[2].ToString());
    }
}