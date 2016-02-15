**Factory Method** sirve para crear objetos así como Template Method se utiliza para implementar un algoritmo. Una superclase especifica todos los comportamientos estándares y genéricos y delega los detalles de la creación a las subclases que son suministradas por el cliente.
Factory Method permite un diseño más personalizable y sólo un poco más complicado. Otros patrones de diseño requieren nuevas clases, mientras que éste sólo requiere una nueva operación.
Éste patrón es similar al patrón Abstract Factory, pero sin el énfasis en las familias de objetos.
Los Factory Methods son especificados de manera rutinaria por un framework arquitectónico, y entonces es implementado por el usuario de dicho framework.

**Intención del patrón**

    *Definir una interfaz para crear un objeto, pero dejar que las subclases decidan cuál clase instanciar.
    *Factory Method permite a una clase diferir la instanciación a subclases.
    *La definición de un constructor "virtual".
    *Que el operador new sea considerado dañino.

**Estructura**
Las clases principales en este patrón son el creador y el producto. El creador necesita crear instancias de productos, pero el tipo concreto de producto no debe ser forzado en las subclases del creador, porque entonces las posibles subclases del creador deben poder especificar subclases del producto para utilizar.

<img src="https://1vabma-ch3302.files.1drv.com/y3mqjTddhXeTn3ppzxdUzagi4zhORt_F9XnVJpCCmgt7tk8A-BK3YaRe-k30X2DrEQktd7F8u3JNu01OGEytu7nrsrm2DEXR4BNYoelZ87vHO_nqnobb71InfNb6dlWVDQ-9grN0JRwbZDRGIbcs59Cc_wCnzvrhwuauPA8v3sOMds?width=527&height=179&cropmode=none" width="527" height="179" />        <img src="https://4fabma-ch3301.files.1drv.com/y3mV_e9-gUpqZssH6kyEo8-9PsT4hxlelhLY61ryMkiZcFEVRG1H5TyljY6J9_2FdHnZ5bvovc8UPp14-6ZL-dS6iivtXHyuiEBIU8htf2d9-3FSdMJvkyhTo_irZWJsN8SKZ0ML4xtp_rVnBYjMgWzApnoQyJ3_P0SwVkmraX5Lsg?width=330&height=176&cropmode=none" width="330" height="176" />


**Ventaja**
Como ventaja podemos citar la centralización de creación de objetos, todo lo haríamos a través de una sola clase por lo que podríamos definir los mismos métodos y acciones para todos los objetos de una aplicación.

**Codigo**
``` java
package Patrones_De_Diseño;
//en nuestro ejemplo tenemos una clase abstracta llamada  TRiangulo de la cual
//heredan 3 tipos de triangulos conocidos
public abstract class Triangulo {
	private int ladoA;
	private int ladoB;
	private int ladoC;
	public Triangulo(int ladoA, int ladoB, int ladoC) {
		setLADO_A(ladoA);
		setLADO_B(ladoB);
		setLADO_C(ladoC);
	}
	// cada subclase debe redefinir estos 3 metodos abstractos
	public abstract String getDescripcion();
	public abstract double getSuperficie();
	public abstract void dibujate();
	public int getladoA() {
		return ladoA;
	}
	public void setLADO_A(int ladoA) {
	}
	public void setLADO_B(int ladoB) {
	}
	public void setLADO_C(int ladoC) {
	}
}
package Patrones_De_Diseño;
public class Equilatero  extends Triangulo{
	public Equilatero (int  angulo_A, int  angulo_B , int angulo_C ) {
		super(angulo_A, angulo_B, angulo_C);
	}
	public String getDescripcion(){
		return "soy un triangulo Equilatero";
	}
	public double getSuperficie() {
		//Aqui ira el algoritmo para calcular superficie de un triangulo equilatero
		 return 0;
	}
	public void dibujate() {
		//aqui va el algoritmo para dibujar un triangulo equilatero
	}
}
package Patrones_De_Diseño;
public class Escaleno extends Triangulo {
	public Escaleno (int  angulo_A, int  angulo_B , int angulo_C) {
super(angulo_A, angulo_B, angulo_C);
	}
	public String getDescripcion(){
		return "soy un triangulo Escaleno";
	}
	public double getSuperficie() {
		//Aqui ira el algoritmo para calcular superficie de un triangulo equilatero
		 return 0;
	}
	public void dibujate() {
		//aqui va el algoritmo para dibujar un triangulo equilatero
	}
}
package Patrones_De_Diseño;
public class Isoceles extends Triangulo {
	public Isoceles(int angulo_A, int angulo_B, int angulo_C) {
		super(angulo_A, angulo_B, angulo_C);
	}
	public String getDescripcion() {
		return "soy un triangulo Isoceles";
	}
	public double getSuperficie() {
		// Aqui ira el algoritmo para calcular superficie de un triangulo
		// equilatero
		return 0;
	}
	public void dibujate() {
		// aqui va el algoritmo para dibujar un triangulo equilatero
	}
}
package Patrones_De_Diseño;
public class TrianguloFactory implements TrianguloFactoryMethod {
	public Triangulo createTriangulo( int ladoA, int ladoB, int ladoC){
	 if ((ladoA==ladoB)&& (ladoA==ladoC)){
		 return new Equilatero(ladoA, ladoB, ladoC);
	}
	 else if ((ladoA != ladoB)&& (ladoA != ladoC)&& (ladoB !=ladoC)){
		 return new Escaleno(ladoA, ladoB, ladoC); 
	 }
	 else{
		 return new Isoceles(ladoA, ladoB, ladoC);
	 }
	}
}
package Patrones_De_Diseño;
public interface TrianCodigoguloFactoryMethod {
	public Triangulo  createTriangulo( int ladoA, int ladoB, int ladoC);
	}
package Patrones_De_Diseño;
public class Main {
	public static void main(String[] args) {
		TrianguloFactoryMethod factory= new TrianguloFactory();
		Triangulo triangulo = factory.createTriangulo(10, 10, 10);
		System.out.println(triangulo.getDescripcion());
	}
}
```
