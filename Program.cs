using EjerciciosChatGPT.Dominio;
using System.Security.Cryptography;
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        Persona p1 = new Persona();
        Console.WriteLine(p1.ImprimirDetalles("Lucas", 18, "luvelez@gmail.com"));
        Persona p2 = new Persona();
        Console.WriteLine(p1.ImprimirDetalles("Zamir", 19, "zambir@gmail.com"));
    }
    
}