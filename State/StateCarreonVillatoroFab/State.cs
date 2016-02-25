using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    
        }
    }
 /// < Resumen >
  /// Clase de arranque para MainApp estructural
  /// Diseño Estado del patrón.
  /// </ Resumen >
  clase  MainApp
  {
    /// < Resumen >
    /// Punto de entrada en aplicación de consola.
    /// </ Resumen >
    estática  vacío  Principal ()
    {
      // Contexto de configuración en un estado
      Contexto c = nuevo contexto ( nueva ConcreteStateA ());
 
      // Peticiones de emisión, que cambia el estado
      c.Request ();
      c.Request ();
      c.Request ();
      c.Request ();
 
      // Espera a que el usuario
      Console.ReadKey ();
    }
  }
 
  /// < Resumen >
  /// La clase abstracta "Estado"
  /// </ Resumen >
  abstracta  clase  Estado
  {
    pública  abstracta  vacío  manija ( Contexto  contexto );
  }
 
  /// < Resumen >
  /// Una clase 'ConcreteState'
  /// </ Resumen >
  clase  ConcreteStateA : Estado
  {
    pública  override  void  manija ( Contexto  contexto )
    {
      context.State = nueva ConcreteStateB ();
    }
  }
 
  /// < Resumen >
  /// Una clase 'ConcreteState'
  /// </ Resumen >
  clase  ConcreteStateB : Estado
  {
    pública  override  void  manija ( Contexto  contexto )
    {
      context.State = nueva ConcreteStateA ();
    }
  }
 
  /// < Resumen >
  /// La clase 'Contexto'
  /// </ Resumen >
  clase  Contexto
  {
    privada _state Estado;
 
    // Constructor
    pública  Contexto ( Estado  Estado )
    {
      este .State = Estado;
    }
 
    // Obtiene o establece el estado
    pública del Estado Estado
    {
      obtener { retorno _state; }
      conjunto
      {
        _state = valor ;
        Console.WriteLine ( " Estado: " +
          . _state.GetType () Nombre);
      }
    }
 
    pública  vacío  Solicitud ()
    {
      _state.Handle ( este );

