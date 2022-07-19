using System;

namespace Ocp.Vehicles
{
    class Barco : Vehicle
    {
        private int seats;
        private int doors;
        private double comprimento;

        public Barco(string color, int year, double engine, int seats, int doors, double comprimento) : base(color, year, engine)
        {
            this.seats = seats;
            this.doors = doors;
            this.comprimento = comprimento;

            ConfigureBarco();
        }
        public void ConfigureBarco()
        {
            Console.WriteLine($"Criando um barco {color}, {year}, {engine} {doors} portas e {seats} assentos e medindo {comprimento} mts");
            StartVehicle();
        }
    }
}
