using System;

namespace FactoryPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Should your vehicle have 2 or 4 tires?    ");
            int tires = int.Parse(Console.ReadLine());
            IVehicle hondaAccord = VehicleFactory.GetVehicle(tires);
            hondaAccord.Drive();
        }
    }
}
