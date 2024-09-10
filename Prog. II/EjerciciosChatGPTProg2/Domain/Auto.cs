using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosChatGPTProg2.Domain
{
    public class Auto : IVehiculo
    {
        public int VelocidadActual { get; set; }
        public string Modelo { get; set; }
        public Auto(string modelo)
        {
            Modelo = modelo;
        }
        public string Arrancar()
        {
            return "El auto ha arrancado";
        }

        public string Detener()
        {
            VelocidadActual = 0;
            return "El auto se ha detenido";
        }

        public string Acelerar(int velocidad)
        {
            VelocidadActual = velocidad;
            return $"El auto ha acelerado a {velocidad} km/h";
        }
    }
}
