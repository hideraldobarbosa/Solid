using System;

namespace Ocp.Vehicles
{
    class Aviao : Vehicle
    {
        private int seats;
        private int doors;
        private int alturaMaxima;

        public Aviao(string color, int year, double engine, int seats, int doors, int alturaMaxima) : base(color, year, engine)
        {
            this.seats = seats;
            this.doors = doors;
            this.alturaMaxima = alturaMaxima;

            ConfigureBarco();
        }
        public void ConfigureBarco()
        {
            Console.WriteLine($"Criando um aviao {color}, {year}, {engine} {doors} portas e {seats} assentos e atinge altura de {alturaMaxima} pés ");
            StartVehicle();
        }

    }
}
