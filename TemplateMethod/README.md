# Patrón de diseño: Template Method

## Propósito

Define en una operación el esqueleto de un algoritmo, delegando en las subclases algunos de sus pasos. Permite que las subclases redefinan ciertos pasos de un algoritmo sin cambiar su estructura.

## Aplicación

El método de plantilla está diseñado para frameworks, donde cada cual implementa las partes de la arquitectura de un ámbito, dejando espacios para personalizar las opciones.

## Código

### Clase principal
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;
  
  namespace TemplateMethod
  {
      class Program
      {
          static void Main(string[] args)
          {
              Tea MyTea = new Tea();
              MyTea.PrepareRecipe();
          }
      }
  }
### Clase "CaffeineBeverage"
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;
  
  namespace TemplateMethod
  {
      public abstract class CaffeineBeverage
      {
          public /*sealed*/ void PrepareRecipe()
          {
              BoilWater();
              Brew();
              PourInCup();
              AddCondiments();
          }
  
          public abstract void Brew();
          public abstract void AddCondiments();
  
          void BoilWater()
          {
              Console.WriteLine("Boiling water...");
              Console.ReadKey();
          }
  
          void PourInCup()
          {
              Console.WriteLine("Poring into cup...");
              Console.ReadKey();
          }
  
      }
  }
### Clase "Coffee"
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;
  
  namespace TemplateMethod
  {
      public class Coffee : CaffeineBeverage
      {
          public override void Brew()
          {
              Console.WriteLine("Dripping coffee through filter...");
              Console.ReadKey();
          }
  
          public override void AddCondiments()
          {
              Console.WriteLine("Adding sugar and milk...");
              Console.ReadKey();
          }
      }
  }
### Clase "Tea"
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;
  
  namespace TemplateMethod
  {
      public class Tea : CaffeineBeverage
      {
          public override void Brew()
          {
              Console.WriteLine("Steeping the tea...");
              Console.ReadKey();
          }
  
          public override void AddCondiments()
          {
              Console.WriteLine("Adding lemon...");
              Console.ReadKey();
          }
      }
  }
