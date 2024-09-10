using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosChatGPTProg2.Domain
{
    public class Avion : ITransporteAereo
    {
        public string Despegar()
        {
            return "Despegando";
        }

        public string IniciarViaje()
        {
            return "Iniciando viaje";
        }
    }
}