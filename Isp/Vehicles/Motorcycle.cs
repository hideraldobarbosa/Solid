using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isp.Vehicles
{
    class Motorcycle : IVehicleMotorcycle
    {
        private string Color;
        private int Year;
        private Double Engine;

        public Motorcycle(string color, int year, double engine)
        {
             ConfigureMotorcycle(color, year, engine);
        }

        public void ConfigureCar(string color, int year, double engine, int seat, int doors)
        {
        }

        public void ConfigureMotorcycle(string color, int year, double engine)
        {
            Color = color;
            Year = year;
            Engine = engine;
            Console.WriteLine($"Criando moto ano {year}, motor {engine} cilindradas de cor{color}");
            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os Motores");
        }
    }
}
