using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1._2ChatGPT.Dominio
{
    public class Estudiante
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
		private int numId;

		public int NumeroIdentificacion
		{
			get { return numId; }
			set { numId = value; }
		}
        public Estudiante()
        {
			Nombre = string.Empty;
			Edad = 0;
			NumeroIdentificacion = 0;
        }

        public override string? ToString()
		{
			return "Estudiante: " + Nombre + " | Numero ID: " + NumeroIdentificacion + " | Edad: "+Edad;
		}
		public string ActualizarEdad(int edad)
		{
			Edad = edad;
            return "Edad actualizada";
        }
	}
}
