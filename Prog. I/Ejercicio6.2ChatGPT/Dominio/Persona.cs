using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6._2ChatGPT.Dominio
{
    public class Persona
    {
		private int _legajo;

		public int Legajo
		{
			get { return _legajo; }
			set { _legajo = value; }
		}
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
		private char _sexo;

		public char Sexo
		{
			get { return _sexo; }
			set { _sexo = value; }
		}
        public Persona()
        {
            Legajo = 0;
			Nombre = string.Empty;
			Edad = 0;
			Sexo=Char.MinValue;
        }

        
    }
}
