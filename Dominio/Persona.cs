using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosChatGPT.Dominio
{
    public class Persona
    {
		private string nombre;
		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}
		private int edad;
		public int Edad
		{
			get { return edad; }
			set { edad = value; }
		}
		private string correo;
		public string CorreoElectronico
		{
			get { return correo; }
			set { correo = value; }
		}
        public Persona()
        {
            this.edad = 0;
			this.nombre = string.Empty;
			this.correo = string.Empty;
        }
		public string ImprimirDetalles(string nombre, int edad, string correo)
		{
			string resultado;
			resultado = ("El nombre es: " + nombre + ", la edad es: " + edad + ", y el correo es: " + correo);
			return resultado;
		}

    }
}
