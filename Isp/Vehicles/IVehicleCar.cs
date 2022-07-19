namespace Isp.Vehicles
{
    interface IVehicleCar : IVehicle
    {
        void ConfigureCar(string color, int year, double engine, int seat, int doors);
    }
}
