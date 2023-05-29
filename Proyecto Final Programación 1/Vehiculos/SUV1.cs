using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Programación_1.Vehiculos
{
    internal class SUV1 : VehiculoBase
    {
        public bool TerceraFilaAsientos { get; set; }
        public string CapacidadRemolque { get; set; }
        public bool TieneTechoCorredizo { get; set; }
        
        public void ModoOffRoad()
        {
            Console.WriteLine("Activando el modo off-road en el SUV");
        }
    }
}
