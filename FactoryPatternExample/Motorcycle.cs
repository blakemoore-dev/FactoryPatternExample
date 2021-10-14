namespace FactoryPatternExample
{
    public class Motorcycle : IVehicle
    {
        public void Drive()
        {
            System.Console.WriteLine("Building a MOTORCYCLE");
        }
    }
}
