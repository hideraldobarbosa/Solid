using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isp.Vehicles
{
    class Car : IVehicle, IVehicleCar
    {
        private string Color;
        private int Year;
        private Double Engine;
        private int Seats;
        private int Doors;

        public Car(string color, int year, double engine, int seats, int doors)
        {
            ConfigureCar(color, year, engine, seats, doors);
        }

        public void ConfigureCar(string color, int year, double engine, int seat, int doors)
        {
            Color = color;  
            Year = year;    
            Engine = engine; 
            Seats = seat;   
            Doors = doors;
            Console.WriteLine($"Criando carro ano {year}, motor {engine} de cor{color}");
            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os Motores");
        }
    }
}
