using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosChatGPTProg2
{
    public interface IVehiculo
    {
        public int VelocidadActual { get; set; }
        public string Modelo { get; set; }
        string Arrancar();
        string Detener();
        string Acelerar(int velocidad);
    }
}
