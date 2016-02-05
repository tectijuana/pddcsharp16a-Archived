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
	
	
