using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7._3ChatGPT.Dominio
{
    public class Departamentos
    {
		private string _departamento;

		public string Departamento
		{
			get { return _departamento; }
			set { _departamento = value; }
		}
        public Departamentos()
        {
            Departamento = string.Empty;
        }

        public override string? ToString()
        {
            return Departamento;
        }
    }
}
