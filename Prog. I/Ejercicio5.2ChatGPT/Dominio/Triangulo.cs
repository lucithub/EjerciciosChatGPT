using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5._2ChatGPT.Dominio
{
    public class Triangulo : FiguraGeometrica
    {
        private double _lados;

        public double Lados
        {
            get { return _lados; }
            set { _lados = value; }
        }

        public Triangulo()
        {
            Longitud = 0;
            Ancho=0;
            Lados = 0;
        }
        public double CalcularAreaT()
        {
            double area;
            area=(Ancho/2)*Longitud;
            return area;
        }
        public double CalcularPerimetroT()
        {
            double perimetro;
            perimetro = Lados + Lados + Ancho;
            return perimetro;
        }
    }
}
