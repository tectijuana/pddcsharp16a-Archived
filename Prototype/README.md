#Patron Prototype
<
El patrón de diseño Prototype (Prototipo), tiene como finalidad crear nuevos objetos duplicándolos, clonando una instancia creada previamente.

Este patrón especifica la clase de objetos a crear mediante la clonación de un prototipo que es una instancia ya creada. La clase de los objetos que servirán de prototipo deberá incluir en su interfaz la manera de solicitar una copia, que será desarrollada luego por las clases concretas de prototipos.

using System;

public abstract class Documento 

{ 

 protected string contenido = ""; 

 public Documento duplica() 

 { 

 Documento resultado; 

 resultado = (Documento)this.MemberwiseClone(); 

 return resultado; 

 } 

 public void rellena(string informacion) 

 { 

 contenido = informacion; 

 } 

 public abstract void imprime(); 

 public abstract void visualiza(); 

} 

using System; 

public class OrdenDePedido : Documento 

{ 

 public override void visualiza() 

 { 

 Console.WriteLine("Muestra la orden de pedido: " + 

 contenido); 

 } 

 public override void imprime() 

 { 

 Console.WriteLine("Imprime la orden de pedido: " + 

 contenido); 

 } 

} 

using System; 

public class SolicitudMatriculacion : Documento 

{ 

 public override void visualiza() 

 { 

 Console.WriteLine( 

 "Muestra la solicitud de matriculación: " + contenido); 

 } 

 public override void imprime() 

 { 

 Console.WriteLine( 

 "Imprime la solicitud de matriculación: " + contenido); 

 } 

} 

using System;
public class CertificadoCesion : Documento

{ 

 public override void visualiza() 

 { 

 Console.WriteLine( 

 "Muestra el certificado de cesión: " + contenido); 

 } 

 public override void imprime() 

 { 

 Console.WriteLine( 

 "Imprime el certificado de cesión: " + contenido); 

 } 

}
