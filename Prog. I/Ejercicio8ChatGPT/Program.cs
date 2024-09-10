using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una serie de números separados por comas:");
        string input = Console.ReadLine();

        // Dividir la cadena de entrada en números individuales
        string[] numerosComoCadenas = input.Split(',');

        // Convertir cada número de cadena a tipo double y almacenarlo en un arreglo de doubles
        double[] numeros = new double[numerosComoCadenas.Length];
        for (int i = 0; i < numerosComoCadenas.Length; i++)
        {
            numeros[i] = Convert.ToDouble(numerosComoCadenas[i]);
        }

        // Calcular la suma de todos los números
        double suma = 0;
        foreach (double numero in numeros)
        {
            suma += numero;
        }

        // Calcular el promedio
        double promedio = suma / numeros.Length;

        // Mostrar el promedio al usuario
        Console.WriteLine("El promedio de los números ingresados es: " + promedio);
    }
}