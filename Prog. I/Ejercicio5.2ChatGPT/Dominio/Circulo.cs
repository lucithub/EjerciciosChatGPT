using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5._2ChatGPT.Dominio
{
    public class Circulo:FiguraGeometrica
    {
        public Circulo()
        {
            Radio = 0;
        }
        public double CalcularAreaC()
        {
            double area;
            area = Math.PI * (Radio * Radio);
            return area;
        }
    }
}
