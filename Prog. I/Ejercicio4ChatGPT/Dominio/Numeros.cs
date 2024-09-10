using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4ChatGPT.Dominio
{
    public class Numeros
    {
		private int _numero;

		public int Numero
		{
			get { return _numero; }
			set { _numero = value; }
		}
        public Numeros(int numero)
        {
            this.Numero = numero;
        }
    }
}
