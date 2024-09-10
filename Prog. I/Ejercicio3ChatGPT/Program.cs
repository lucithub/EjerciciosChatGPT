using Ejercicio3ChatGPT.Dominio;

public class Program
{
    static void Main(string[] args)
    {
        Calculadoras n1= new Calculadoras();
        Calculadoras n2= new Calculadoras();
        n2.Numero1 = 7842;
        n2.Numero2 =10;
        n1.Numero1 = 100000;
        n1.Numero2 = 88970;
        Console.WriteLine(n2.SumaCalculadora());
        Console.WriteLine(n1.RestaCalculadora());
    }
}