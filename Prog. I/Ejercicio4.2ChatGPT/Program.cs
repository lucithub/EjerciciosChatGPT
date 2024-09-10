public class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i < 11; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Ingrese un numero");
        int numero = int.Parse(Console.ReadLine());
        int i2= 1;
        while (i2<11)
        {
            Console.WriteLine(numero+" * "+""+i2+": "+numero*i2);
            i2++;
        }
        
        
    }
}