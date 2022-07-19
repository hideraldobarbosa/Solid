using Isp.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Azul", 2002, 4.0, 5, 4);
            Motorcycle moto = new Motorcycle("Branca", 2010, 320);

            Console.ReadLine();
        }
    }
}
