using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosChatGPTProg2.Domain
{
    public class Moto : IVehiculo
    {
        public int VelocidadActual { get; set; }
        public string Modelo { get; set; }
        public Moto(string modelo)
        {
            Modelo = modelo;
        }
        public string Arrancar()
        {
            return "La moto ha arrancado";
        }

        public string Detener()
        {
            VelocidadActual = 0;
            return "La moto se ha detenido";
        }

        public string Acelerar(int velocidad)
        {
            VelocidadActual = velocidad;
            return $"La moto ha acelerado a {velocidad} km/h";
        }
    }
}
