package Patrones_De_Diseño;


public class Main {

	public static void main(String[] args) {
		
		TrianguloFactoryMethod factory= new TrianguloFactory();
		
		Triangulo triangulo = factory.createTriangulo(10, 10, 10);
		System.out.println(triangulo.getDescripcion());
	}
	
	
	
}

/* ventajas:
 * se elimina la necesidad de introducir clases espeficicas 
 * en el codigo  del creador solo de maneja interfaz Product, por lo
 * que premite  añadir cualquier clase  ConcretProduct definida por el usuario
 * 
 * desventaja: es mas flexible  crear un  objeto con un factory MEthod que directamente
 * un metodo factoria puede dar una implementacion  por defecto
 */

