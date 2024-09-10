using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7._3ChatGPT.Dominio
{
    public class Empleado
    {
		private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}
		private int _edad;

		public int Edad
		{
			get { return _edad; }
			set { _edad = value; }
		}
		private int _salario;

		public int Salario
		{
			get { return _salario; }
			set { _salario = value; }
		}
		private Departamentos _departamento;

		public Departamentos Departamento
		{
			get { return _departamento; }
			set { _departamento = value; }
		}
        public Empleado()
        {
            Nombre = string.Empty;
			Edad = 0;
			Salario = 0;
			Departamento = null;
        }
		public int CalcularSalarioAnual()
		{
			int salarioAnual = Salario * 12;
			return salarioAnual;
		}

        public override string? ToString()
        {
			return "Nombre: " + Nombre + " | Edad: " + Edad + " | Salario: " + Salario + " | Departamento: " + Departamento.ToString();
        }
    }
}
