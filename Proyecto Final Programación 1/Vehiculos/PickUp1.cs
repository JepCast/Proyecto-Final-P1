using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Programación_1.Vehiculos
{
    internal class PickUp1 : VehiculoBase
    {
        public string CapacidadCarga { get; set; }
        public bool Diesel { get; set; }
        public string Motor { get; set; }

        public void ActivarTraccion4x4()
        {
                Console.WriteLine("Activando tracción 4x4 en la pick-up");
        }
    }
}
