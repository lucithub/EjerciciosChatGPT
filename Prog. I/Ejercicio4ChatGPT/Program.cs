using Ejercicio4ChatGPT.Dominio;

public class Program
{
    static void Main(string[] args)
    {
        //Creo el array
        Nombres[] nombres1 = new Nombres[4];
        //Creo los objetos que van a ir dentro del array
        Nombres n1 = new Nombres("Lucas");
        Nombres n2 = new Nombres("Marcelo");
        Nombres n3 = new Nombres("Frnaco");
        Nombres n4 = new Nombres("Benja");
        //Los ubico a los objetos en c/posicion del array
        nombres1[0]=n1;
        nombres1[1]=n2;
        nombres1[2]=n3;
        nombres1[3]=n4;
        //impirmo el que esta en la posicion 1
        Console.WriteLine(nombres1[1].Nombre);//.Nombre siemore se refiere a llamar la property, en este caso, Nombre
        //creo array
        Numeros[] numeros1= new Numeros[3];
        //creo objs
        Numeros num1 = new Numeros(78);
        Numeros num2 = new Numeros(190);
        Numeros num3 = new Numeros(11);
        //ubico objs
        numeros1[0]=num1;
        numeros1[1]=num2;
        numeros1[2]=num3;
        //Con un for, los muestro a todos
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(numeros1[i].Numero);//llamo a la property Numero para mostrar
        }
        
    }
}