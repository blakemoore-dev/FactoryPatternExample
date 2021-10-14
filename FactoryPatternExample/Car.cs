namespace FactoryPatternExample
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            System.Console.WriteLine("Building a CAR");
        }
    }
}
