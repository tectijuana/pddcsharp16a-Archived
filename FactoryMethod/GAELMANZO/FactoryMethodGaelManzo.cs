using System;
namespace Factory
{
/// <summary>
/// The 'Product' interface
/// </summary>
public interface IFactory
{
void Drive(int miles);
}
/// <summary>
/// A 'ConcreteProduct' class
/// </summary>
public class Scooter : IFactory
{
public void Drive(int miles)
{
Console.WriteLine("Drive the Scooter : " + miles.ToString() + "km");
}
}
/// <summary>
/// A 'ConcreteProduct' class
/// </summary>
public class Bike : IFactory
{
public void Drive(int miles)
{
Console.WriteLine("Drive the Bike : " + miles.ToString() + "km");
}
}
/// <summary>
/// The Creator Abstract Class
/// </summary>
public abstract class VehicleFactory
{
public abstract IFactory GetVehicle(string Vehicle);
}
/// <summary>
/// A 'ConcreteCreator' class
/// </summary>
public class ConcreteVehicleFactory : VehicleFactory
{
public override IFactory GetVehicle(string Vehicle)
{
switch (Vehicle)
{
case "Scooter":
return new Scooter();
case "Bike":
return new Bike();
default:
throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Vehicle));
}
}
}
/// <summary>
/// Factory Pattern Demo
/// </summary>
class Program
{
static void Main(string[] args)
{
VehicleFactory factory = new ConcreteVehicleFactory();
IFactory scooter = factory.GetVehicle("Scooter");
scooter.Drive(10);
IFactory bike = factory.GetVehicle("Bike");
bike.Drive(20);
Console.ReadKey();
}
}
}
