using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Programación_1.Vehiculos
{
    internal class _4X4 :VehiculoBase
    {
        public bool ReduccionDiferencial { get; set; }
        public string SuspensionElevada { get; set; }
        public string AlturaMaximaSuelo { get; set; }
       

        public void BloquearDiferenciales()
        {
            Console.WriteLine("Bloqueando los diferenciales en el vehículo 4x4");
        }
    }
}
