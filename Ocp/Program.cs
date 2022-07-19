using Ocp.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp
{
    class Program
    {
        /// <summary>
        /// implementando ocp de forma errada aqui
        /// </summary>
        /// <param name="args">argumentos start sistemas</param>
        static void Main(string[] args)
        {
            TypeVehicle type = TypeVehicle.MOTORCYCLE;

            if (type == TypeVehicle.CAR)
            {
                Car car = new Car("Azul", 2022, 2.0, 5, 4);
            }
            else if(type == TypeVehicle.MOTORCYCLE)
            {
                Motorcycle moto = new Motorcycle("Branca", 2020, 360 );

            }
            else if (type == TypeVehicle.BARCO)
            {
                Barco barco = new Barco("Prata", 2005, 4.0, 15,0, 2.80);

            }
            else 
            {
                Aviao aviao = new Aviao("Branca", 2020, 800.0, 280, 8, 28000);
            }

            Console.ReadLine();
        }
    }
}
