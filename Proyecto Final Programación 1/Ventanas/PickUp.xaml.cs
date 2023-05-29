namespace Proyecto_Final_Programación_1.Ventanas;

public partial class PickUp : ContentPage
{
    public PickUp()
    {
        InitializeComponent();
    }

    internal class PickUp1 : VehiculoBase
    {
        public string CapacidadCarga { get; set; }
        public bool Diesel { get; set; }
        public string Motor { get; set; }

        public void ActivarTraccion4x4()
        {
            Console.WriteLine("Activando tracción 4x4 en la pick-up");
        }
        internal class VehiculoBase : IVehiculo
        {
            public string Marca { get; set; }
            public string Modelo { get; set; }
            public string Color { get; set; }
            public int Anio { get; set; }
            public string Placa { get; set; }
            public string Tipo { get; set; }
            public int VelocidadMaxima { get; private set; }
            public int VelocidadActual { get; private set; }
            public int Encendido = 0;
            public void Bocina()
            {
                Console.WriteLine("-Se empieza a escuchar música-");
            }
            public void Acelerar(int cuanto)
            {
                if (Encendido == 1)
                {
                    if (VelocidadActual + cuanto <= VelocidadMaxima && Encendido == 1)
                    {
                        VelocidadActual += cuanto;
                        Console.WriteLine($"Acelerando el vehículo en {cuanto} km/h");
                    }
                    else
                    {
                        Console.WriteLine("No se puede acelerar más allá de la velocidad máxima");
                    }
                }
                if (Encendido == 0)
                {
                    Console.WriteLine("No puedes acelerar, el auto esta apagado");
                }

            }
            public void Encender()
            {
                if (Encendido == 0)
                {
                    Console.WriteLine("Bienvenido");
                    Encendido = 1;
                }
                else
                {
                    Console.WriteLine("Lo siento, el auto ya estaba encendido");
                }
            }
            public void Apagar()
            {
                if (Encendido == 1)
                {
                    Console.WriteLine("El auto se ha apagado");
                    Encendido = 0;
                }
                else
                {
                    Console.WriteLine("El auto ya estaba encendido");
                }
            }
            public void Frenar(int cuanto)
            {
                if (Encendido == 1)
                {
                    Console.WriteLine($"Frena con una fuerza de {cuanto} km/h");
                }
                else
                {
                    Console.WriteLine($"Freno con una fuerza de {cuanto} km/h");
                }
            }

        }


    }
}