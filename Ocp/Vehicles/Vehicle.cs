using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp.Vehicles
{
    class Vehicle : IVehicle
    {
        protected string color;
        protected int year;
        protected double engine;

        public Vehicle(string color, int year, double engine)
        {
            this.color = color;
            this.year = year;
            this.engine = engine;
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando o motor!!!");
        }

    }
}
