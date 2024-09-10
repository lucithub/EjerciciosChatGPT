using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosChatGPTProg2.Domain
{
    public class Tesla : IAutopilot, IElectric
    {
        public string ActivarAutopilot()
        {
            return "Autopilot activado";
        }

        public string CargarBateria()
        {
            return "Batería cargada";
        }
    }
}
