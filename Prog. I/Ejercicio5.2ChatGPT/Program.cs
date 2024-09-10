using Ejercicio5._2ChatGPT.Dominio;

public class Program
{
    static void Main(string[] args)
    {
        Rectangulo r1 = new Rectangulo();
        r1.Longitud = 0.2;
        r1.Ancho = 17.5;
        Circulo c1 = new Circulo();
        c1.Radio = 0.7;
        Triangulo t1 = new Triangulo();
        t1.Ancho = 19.7;
        t1.Longitud = 19.7;
        t1.Lados = 9.2;
        Console.WriteLine("El area del rectangulo creado(Longitud: "+r1.Longitud+" y Ancho: "+r1.Ancho+") es: "+r1.CalcularAreaR());
        Console.WriteLine("El perimetro del rectangulo creado(Longitud: " + r1.Longitud + " y Ancho: " + r1.Ancho + ") es: " + r1.CalcularPerimetroR());
        Console.WriteLine("El area del circulo creado(Radio: "+c1.Radio+") es: "+c1.CalcularAreaC());
        Console.WriteLine("El area del triangulo creado(Ancho: "+t1.Ancho+", Longitud: "+t1.Longitud+" y Lado: "+t1.Lados+") es: "+t1.CalcularAreaT());
        Console.WriteLine("El perimetro del triangulo creado(Ancho: "+t1.Ancho+", Longitud: "+t1.Longitud+" y Lado: "+t1.Lados+") es: " + t1.CalcularPerimetroT());

    }
}