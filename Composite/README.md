Favor de explicar el Patron de este directorio a nuestros visitantes.

Patron Composite: 

Ofrece un marco de diseño de una composicion de objetos de profundidad variable
que a su vez esta basado en un arbol 

Por otro lado, esta composición está encapsulada respecto a los clientes de los objetos que pueden interactuar sin tener que conocer la profundidad de la composición.

El patrón se utiliza en los siguientes casos:
● es necesario representar jerarquías de composición en un sistema;
● los clientes de una composición deben ignorar si se comunican con objetos compuestos o no.

Ejemplo c#
using System; 
public abstract class Empresa 
{ 
 protected static double costeUnitarioVehiculo = 5.0; 
 protected int nVehiculos; 
 public void agregaVehiculo() 
   { 
    nVehiculos = nVehiculos + 1; 
   } 

 public abstract double calculaCosteMantenimiento(); 
 public abstract bool agregaFilial(Empresa filial); 
}

@firelander:Se agrego Ejemplo y un poco mas de informacion
