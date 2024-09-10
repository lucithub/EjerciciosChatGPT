using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5._2ChatGPT.Dominio
{
    public class Rectangulo : FiguraGeometrica
    {
        public Rectangulo()
        { 
            Longitud=0;
            Ancho=0;
        }
        public double CalcularAreaR()
        {
            double area;
            area = Longitud * Ancho;
            return area;
        }
        public double CalcularPerimetroR()
        {
            double perimetro;
            perimetro = (Longitud * 2) + (Ancho * 2);
            return perimetro;
        }
    }
}
