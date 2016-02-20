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
