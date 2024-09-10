public class Program
{
    static void Main(string[] args)
    {
        int cuenta = 1;
        int suma = 0;
        int promedio = 0;
        Console.WriteLine("Ingrese numeros separados por una coma: ");
        string input = Console.ReadLine();
        string[] numerosstrings = input.Split(',');
        foreach (string numerostring in numerosstrings) 
        {
            int.TryParse(numerostring, out int value);
            Console.WriteLine("Numero "+cuenta+": "+value);
            suma = suma+value;
            cuenta = cuenta + 1;
        }
        Console.WriteLine("La suma de los numeros ingresados es de: "+suma);
        promedio = suma / cuenta;
        Console.WriteLine("El promedio de los numeros ingresados es de: "+promedio);
    }
}