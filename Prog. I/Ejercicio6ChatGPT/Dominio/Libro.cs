using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6y7ChatGPT.Dominio
{
    public class Libro
    {
		private string _titulo;

		public string Titulo
		{
			get { return _titulo; }
			set { _titulo = value; }
		}
		private string _autor;

		public string Autor
		{
			get { return _autor; }
			set { _autor = value; }
		}
		private int _anio;

		public int Anio
		{
			get { return _anio; }
			set { _anio = value; }
		}
		private long _isbn;

		public long ISBN
		{
			get { return _isbn; }
			set { _isbn = value; }
		}
        public Libro(string titulo, string autor, int anio, long isbn)
        {
			Titulo = titulo;
			Autor = autor;
			Anio = anio;
			ISBN = isbn;
        }

        public override string? ToString()
        {
			return "Titulo: " + _titulo + ", Autor: " + _autor + ", Anio: " + _anio + ", ISBN: " + _isbn;
        }
    }
}
