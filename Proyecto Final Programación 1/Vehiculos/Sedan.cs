using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Programación_1.Vehiculos
{
    internal class Sedan : VehiculoBase
    {
        public int NumeroPuertas { get; set;}
        public bool MaleteroAmplio { get; set; }
        public string Tipodecaja { get; set; }

        public void AbrirMaletero()
        {
            Console.WriteLine("Abriendo el maletero del sedán");
        }

    }
}
