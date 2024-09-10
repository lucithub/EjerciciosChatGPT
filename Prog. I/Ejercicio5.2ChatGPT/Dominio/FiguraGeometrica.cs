using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5._2ChatGPT.Dominio
{
    public class FiguraGeometrica
    {
        
        private double _radio;

        public double Radio
        {
            get { return _radio; }
            set { _radio = value; }
        }


        private double _longitud;
        public double Longitud
        {
            get { return _longitud; }
            set { _longitud = value; }
        }
        private double _ancho;

        public double Ancho
        {
            get { return _ancho; }
            set { _ancho = value; }
        }
   
    }
}
