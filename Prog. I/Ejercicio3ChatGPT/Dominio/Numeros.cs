using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3ChatGPT.Dominio
{
    public class Calculadoras
    {
        private int numero;

        public int Numero1
        {
            get { return numero; }
            set { numero = value; }
        }
        private int numero2;
        public int Numero2
        {
            get { return numero2; }
            set { numero2 = value; }
        }
        public int SumaCalculadora()
        {
            int resultado = numero + numero2;
            return resultado;
        }
        public int RestaCalculadora()
        {
            int resultado = numero - numero2;
            return resultado;
        }
        public int MultiplicacionCalculadora()
        {
            int resultado = numero * numero2;
            return resultado;
        }
        public int DivisionCalculadora()
        {
            int resultado = numero / numero2;
            return resultado;
        }
    }
}
