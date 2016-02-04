Patron Proxy
Descripción

El patrón Proxy tiene como objetivo el diseño de un objeto que sustituye a otro objeto (el sujeto) y que controla el acceso.

El objeto que realiza la sustitución posee la misma interfaz que el sujeto, volviendo la sustitución transparente de cara a los clientes.

Ejemplo

Queremos ofrecer para cada vehículo del catálogo la posibilidad de visualizar un pequeño vídeo de presentación del vehículo. Un clic sobre la fotografía de la presentación del vehículo permitirá reproducir este vídeo.

Una página del catálogo contiene numerosos vehículos y es muy pesado guardar en memoria todos los objetos de animación, pues los vídeos necesitan gran cantidad de memoria, y su transferencia a través de la red toma bastante tiempo.

El patrón Proxy ofrece una solución a este problema difiriendo la creación de los sujetos hasta el momento en que el sistema tiene necesidad de ellos, en este caso tras un clic en la fotografía del vehículo.

Esta solución aporta dos ventajas:

la página del catálogo se carga mucho más rápidamente, sobretodo si tiene que cargarse a través de una

red como Internet;

sólo aquellos vídeos que van a visualizarse se crean, cargan y reproducen.

El objeto fotografía se llama el proxy del vídeo. Procede a la creación del sujeto únicamente tras haber hecho clic en ella. Posee la misma interfaz que el objeto vídeo. La figura 16.1 muestra el diagrama de clases correspondiente. La clase del proxy, AnimaciónProxy, y la clase del vídeo, Vídeo, implementan ambas la misma interfaz, a saber Animación.

Estructura

Diagrama de clases
La figura 16.4 ilustra la estructura genérica del patrón.

Participantes
Los participantes del patrón son los siguientes:

Sujeto (Animación) es la interfaz común al proxy y al sujeto real;

SujetoReal (Vídeo) es el objeto que el proxy controla y representa;

Proxy (AnimaciónProxy) es el objeto que se sustituye por el sujeto real. Posee una interfaz idéntica a este último (interfaz Sujeto). Se encarga de crear y de destruir al sujeto real y de delegarle los mensajes.

Colaboraciones
El proxy recibe las llamadas del cliente en lugar del sujeto real. Cuando lo juzga apropiado, delega estos mensajes en el sujeto real. Debe, en este caso, crear previamente el sujeto real si no está creado ya.

Dominios de aplicación

Los proxys son muy útiles en programación orientada a objetos. Existen distintos tipos de proxy. Vamos a ilustrar tres:

proxy virtual: permite crear un objeto de tamaño importante en el momento adecuado;

proxy remoto: permite acceder a un objeto ejecutándose en otro entorno. Este tipo de proxy se implementa en sistemas de objetos remotos (CORBA, Java RMI);

proxy de protección: permite securizar el acceso a un objeto, por ejemplo mediante técnicas de autenticación.

Ejemplo C#

using System; public class Video : Animacion { public void clic() { }``` public void dibuja() { Console.WriteLine("Mostrar el vídeo"); } public void carga() { Console.WriteLine("Cargar el vídeo"); } public void reproduce() { Console.WriteLine("Reproducir el vídeo"); } }`
