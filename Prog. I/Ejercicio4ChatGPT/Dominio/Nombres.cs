using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4ChatGPT.Dominio
{
    public class Nombres
    {
		private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}
        public Nombres(string nombre)
        {
            this.Nombre= nombre;
        }
    }
}
