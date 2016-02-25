using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
     la clase  de programa
    {
        estática  vacío  Principal ()
        {
            Abstracción ab = nueva RefinedAbstraction ();
            // Aplicación establecimiento y la recuperación 
            ab.Implementor = nueva ConcreteImplementorA ();
            ab.Operation ();
            // Cambio IMPLEMENTACIÓN y llamada 
            ab.Implementor = nueva ConcreteImplementorB ();
            ab.Operation ();
            // Espera a que el usuario 
            Console.Read ();
        }
    }
    // "Abstracción" 
    clase  Abstracción
    {
        protegida implementador implementador;
        // Propiedad 
        pública implementador implementador
        {
            conjunto {implementador = valor ; }
        }
        pública  virtual de  vacío  Operación ()
        {
            implementor.Operation ();
        }
    }
    // "Implementador" 
    abstracta  clase  Implementor
    {
        pública  abstracta  vacío  Operación ();
    }
    // "RefinedAbstraction" 
    clase  RefinedAbstraction : Abstracción
    {
        pública  override  void  Operación ()
        {
            implementor.Operation ();
        }
    }
    // "ConcreteImplementorA" 
    clase  ConcreteImplementorA : Implementor
    {
        pública  override  void  Operación ()
        {
            Console.WriteLine ( " Operación ConcreteImplementorA " );
        }
    }
    // "ConcreteImplementorB" 
    clase  ConcreteImplementorB : Implementor
    {
        pública  override  void  Operación ()
        {
            Console.WriteLine ( " Operación ConcreteImplementorB " );

        }
    }
}
