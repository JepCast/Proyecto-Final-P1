using Proyecto_Final_Programación_1.Vehiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Programación_1
{
    public class Program
    {
        public static void program()
        {
            PickUp1 pickUp = new PickUp1();
            pickUp.Marca = "Ford";
            pickUp.Modelo = "Ranger";
            pickUp.Color = "Rojo";
            pickUp.Anio = 2022;
            pickUp.Placa = "ABC123";
            pickUp.Tipo = "Pick-Up";
            pickUp.CapacidadCarga = "1.37 T";
            pickUp.Diesel = true;
            pickUp.Motor = "Motor 2.3L EcoBoost® de 270HP y 310 lb-pie de Torque";
            pickUp.Encender();
            pickUp.Acelerar(50);
            pickUp.Bocina();
            pickUp.Frenar(30);
            pickUp.Apagar();
            pickUp.ActivarTraccion4x4();

            Sedan sedan = new Sedan();
            sedan.Marca = "Toyota";
            sedan.Modelo = "Camry";
            sedan.Color = "Negro";
            sedan.Anio = 2021;
            sedan.Placa = "XYZ789";
            sedan.Tipo = "Sedán";
            sedan.NumeroPuertas=4;
            sedan.MaleteroAmplio=true;
            sedan.Tipodecaja="Estandar";
            sedan.Encender();
            sedan.Acelerar(40);
            sedan.Bocina();
            sedan.Frenar(20);
            sedan.AbrirMaletero();
            sedan.Apagar();
            

            SUV1 suv = new SUV1();
            suv.Marca = "Jeep";
            suv.Modelo = "Wrangler";
            suv.Color = "Verde";
            suv.Anio = 2023;
            suv.Placa = "DEF456";
            suv.Tipo = "SUV";
            suv.TerceraFilaAsientos = true;
            suv.CapacidadRemolque = "2,000 lb";
            suv.TieneTechoCorredizo = false;
            suv.Encender();
            suv.Acelerar(60);
            suv.Bocina();
            suv.Frenar(40);
            suv.ModoOffRoad();
            suv.Apagar();
            

            _4X4 cuatroPorCuatro = new _4X4();
            cuatroPorCuatro.Marca = "Land Rover";
            cuatroPorCuatro.Modelo = "Defender";
            cuatroPorCuatro.Color = "Blanco";
            cuatroPorCuatro.Anio = 2022;
            cuatroPorCuatro.Placa = "GHI789";
            cuatroPorCuatro.Tipo = "4x4";
            cuatroPorCuatro.ReduccionDiferencial = true;
            cuatroPorCuatro.SuspensionElevada = "Suspensión independiente para cada rueda";
            cuatroPorCuatro.AlturaMaximaSuelo = "29,1 cm";
            cuatroPorCuatro.Encender();
            cuatroPorCuatro.Acelerar(70);
            cuatroPorCuatro.Bocina();
            cuatroPorCuatro.Frenar(50);
            cuatroPorCuatro.BloquearDiferenciales();
            cuatroPorCuatro.Apagar();
        }

    }
}
