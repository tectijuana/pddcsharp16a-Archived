Favor de explicar el Patron de este directorio a nuestros visitantes.

Patron Abstract Factory:

El problema que intenta solucionar este patron es el de crear diferentes familias de objetos, 
es decir, nos ayuda a crear diferentes objetos de la misma familia, por ejemplo: las bibliotecas, 
para crear interfaces graficas suelen utilizar este patron y cada familia seria un sistema operativo distinto. 
Asi pues, el usuario declara un Boton, pero de forma mas interna lo que esta creando es un BotonWindows o un BotonLinux, por ejemplo.

Este patron esta aconsejado cuando se preve la inclusion de nuevas familias de productos,
pero puede resultar contraproducente cuando se a;aden nuevos productos o cambian los existentes, 
puesto que afectaria a todas las familias creadas.


/////////////////////
//Abstract Factory///
/////////////////////

	Descripcion:
	------------
	El objetivo del patrón  Abstract Factory  es la creación de objetos agrupados en familias sin tener que conocer 
	las clases concretas destinadas a la creación de estos objetos. 

	Dominios de uso:
	----------------

	El patrón se utiliza en los dominios siguientes: 
		●Un sistema que utiliza productos necesita ser independiente de la forma en que se crean y agrupan estos 
		productos; 
		●Un sistema está configurado según varias familias de productos que pueden evoluciona.
	
	Ejemplo:
	--------
			using System;
			namespace DZoneArticles.FactoryDesignPattern
			{
		    		public abstract class EmployeeFactory
		    		{
			 		public abstract Employee Create();
		    		}

		    		public class DBAFactory : EmployeeFactory
		    		{
			 		public override Employee Create() { return new DBA(); }
		    		}
		    	
				public class ManagerFactory : EmployeeFactory
		    		{
			 		public override Employee Create() { return new Manager(); }
		    		}
			}
	
	
