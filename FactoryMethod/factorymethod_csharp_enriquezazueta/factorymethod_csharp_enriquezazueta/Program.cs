using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace factorymethod_csharp_enriquezazueta
{
    class Program
    {
        static void Main(string[] args)
        {
             // An array of creators 
    Creator[] creators = new Creator[2];
    creators[0] = new ConcreteCreatorA();
    creators[1] = new ConcreteCreatorB();
    // Iterate over creators and create products 
    foreach(Creator creator in creators)
    {
      Product product = creator.FactoryMethod();
      Console.WriteLine("Created {0}", 
        product.GetType().Name);
    }
    // Wait for user 
    Console.Read();
  }
}
// "Product" 
abstract class Product
{
}
// "ConcreteProductA" 
class ConcreteProductA : Product
{
}
// "ConcreteProductB" 
class ConcreteProductB : Product
{
}
// "Creator" 
abstract class Creator
{
  public abstract Product FactoryMethod();
}
// "ConcreteCreator" 
class ConcreteCreatorA : Creator
{
  public override Product FactoryMethod()
  {
    return new ConcreteProductA();
  }
}
// "ConcreteCreator" 
class ConcreteCreatorB : Creator
{
  public override Product FactoryMethod()
  {
    return new ConcreteProductB();
  }
}
        }
    

