using Ejercicio7._3ChatGPT.Dominio;

namespace Ejercicio7._3ChatGPT
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            Departamentos ventas = new Departamentos();
            ventas.Departamento = "Ventas";
            Departamentos marketing = new Departamentos();
            marketing.Departamento = "Marketing";
            Departamentos ia = new Departamentos();
            ia.Departamento = "IA";
            Departamentos rrhh = new Departamentos();
            rrhh.Departamento = "Recursos Humanos";
            Departamentos finanzas = new Departamentos();
            finanzas.Departamento = "Finanzas";
            Empleado e1 = new Empleado();
            e1.Nombre = "Lucas";
            e1.Edad = 18;
            e1.Salario = 150000;
            e1.Departamento = ventas;
            Empleado e2 = new Empleado();
            e2.Nombre = "Zafir";
            e2.Edad = 20;
            e2.Salario = 160000;
            e2.Departamento = marketing;
            Empleado e3 = new Empleado();
            e3.Nombre = "Juan";
            e3.Edad = 30;
            e3.Salario = 500000;
            e3.Departamento = ia;
            Empleado e4 = new Empleado();
            e4.Nombre = "Maria";
            e4.Edad = 25;
            e4.Salario = 600000;
            e4.Departamento = rrhh;
            Empleado e5 = new Empleado();
            e5.Nombre = "Carlos";
            e5.Edad = 35;
            e5.Salario = 700000;
            e5.Departamento = finanzas;
            Empleado e6 = new Empleado();
            e6.Nombre = "Ana";
            e6.Edad = 28;
            e6.Salario = 650000;
            e6.Departamento = marketing;
            List<Empleado> empleados = new List<Empleado>();
            empleados.Add(e1);
            empleados.Add(e2);
            empleados.Add(e3);
            empleados.Add(e5);
            empleados.Add(e4);
            empleados.Add(e6);
            for (int i = 0; i < empleados.Count; i++)
            {
                Console.WriteLine(empleados[i]);

            }

            //Console.WriteLine(e1.ToString());
            //Console.WriteLine(e1.CalcularSalarioAnual());

        }
    }
}