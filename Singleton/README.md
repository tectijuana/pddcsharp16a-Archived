
Patron Singleton:

En ingeniería de software, el patrón singleton (instancia única en inglés) es un patrón de diseño diseñado para restringir la creación de objetos pertenecientes a una clase o el valor de un tipo a un único objeto.

Su intención consiste en garantizar que una clase sólo tenga una instancia y proporcionar un punto de acceso global a ella.

El patrón singleton se implementa creando en nuestra clase un método que crea una instancia del objeto sólo si todavía no existe alguna. Para asegurar que la clase no puede ser instanciada nuevamente se regula el alcance del constructor (con modificadores de acceso como protegido o privado).

La instrumentación del patrón puede ser delicada en programas con múltiples hilos de ejecución. Si dos hilos de ejecución intentan crear la instancia al mismo tiempo y esta no existe todavía, sólo uno de ellos debe lograr crear el objeto. La solución clásica para este problema es utilizar exclusión mutua en el método de creación de la clase que implementa el patrón.

Las situaciones más habituales de aplicación de este patrón son aquellas en las que dicha clase controla el acceso a un recurso físico único (como puede ser el ratón o un archivo abierto en modo exclusivo) o cuando cierto tipo de datos debe estar disponible para todos los demás objetos de la aplicación.

El patrón singleton provee una única instancia global gracias a que:

La propia clase es responsable de crear la única instancia.
Permite el acceso global a dicha instancia mediante un método de clase.
Declara el constructor de clase como privado para que no sea instanciable directamente




Un ejemplo correcto de inicialización diferida y segura en entornos multi-hilo en C# sería:

public class Singleton { // Variable estática para la instancia, se necesita utilizar una función lambda ya que el constructor es privado private static readonly Lazy instance = new Lazy(() => new Singleton());

// Constructor privado para evitar la instanciación directa
private Singleton()
{
}

// Propiedad para acceder a la instancia
public static Singleton Instance
{
    get
    {
        return instance.Value;
    }
}

}

// Clase de prueba public class Prueba { private static void Main(string[] args) { //Singleton s0 = new Singleton(); //Error Singleton s1 = Singleton.Instance; Singleton s2 = Singleton.Instance; if(s1==s2) { // Misma instancia } } }
