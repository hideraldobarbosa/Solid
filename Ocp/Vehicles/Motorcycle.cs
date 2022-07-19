using System;
namespace Ocp.Vehicles
{
    class Motorcycle : Vehicle
    {
        private int seats;
        private int doors;

        public Motorcycle(string color, int year, double engine) : base(color, year, engine)
        {
            ConfigureMotorcycle();
        }
        public void ConfigureMotorcycle()
        {
            Console.WriteLine($"Criando uma moto {color}, {year}, {engine} cilindradas ");
            StartVehicle();
        }
    }
}
