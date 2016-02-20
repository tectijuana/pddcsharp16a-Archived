#PROXY

Proxy: construye un objeto que se substituye por otro objeto y que controla su acceso;

Proxy:  se  sustituye  el  objeto  existente  otorgando  un  comportamiento  adaptado  a  necesidades  de
optimización o de protección.

#Descripción

El patrón Proxy tiene como objetivo el diseño de un objeto que sustituye a otro objeto (el sujeto) y que controla el acceso.
El objeto que realiza la sustitución posee la misma interfaz que el sujeto, volviendo la sustitución transparente de cara a los clientes.

#EJEMPLO:

Queremos ofrecer para cada vehículo del catálogo la posibilidad de visualizar un pequeño vídeo de presentación del vehículo. Un clic sobre la fotografía de la presentación del vehículo permitirá reproducir este vídeo.
Una página del catálogo contiene numerosos vehículos y es muy pesado guardar en memoria todos los objetos de animación,  pues  los  vídeos  necesitan  gran  cantidad  de  memoria,  y  su  transferencia  a  través  de  la  red  toma bastante tiempo.
El patrón Proxy ofrece una solución a este problema difiriendo la creación de los sujetos hasta el momento en que  el sistema tiene necesidad de ellos, en este caso tras un clic en la fotografía del vehículo.

#Esta solución aporta dos ventajas:

● la página del catálogo se carga mucho más rápidamente, sobre todo si tiene que cargarse a través de una red como Internet;
● sólo aquellos vídeos que van a visualizarse se crean, cargan y reproducen.
El objeto fotografía se llama el proxy del vídeo. Procede a la creación del sujeto únicamente tras haber hecho clic en  ella.  Posee  la  misma  interfaz  que  el  objeto  vídeo.  La  figura  16.1  muestra  el  diagrama  de  clases correspondiente. La clase del proxy, AnimaciónProxy, y la clase del vídeo, Vídeo, implementan ambas la misma interfaz, a saber Animación.

#EJEMPLO C# CONSOLA

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication9
{
    public interface Animacion
    {
        void dibuja();
        void clic();
    }
/*El código  fuente C# de la clase Video que implementa esta interfaz aparece a continuación. En el marco de la 
simulación cada método muestra simplemente un mensaje, excepto el método clic que no realiza ninguna acción.*/
    public class Video : Animacion
    {
        public void clic() { }
        public void dibuja()
        {
            Console.WriteLine("Mostrar el vídeo");
        }
        public void carga()
        {
            Console.WriteLine("Cargar el vídeo");
        }
        public void reproduce()
        {
            Console.WriteLine("Reproducir el vídeo");
        }
    }
/*El  código  fuente  del  proxy,  y  por  tanto  de  la  clase AnimacionProxy  aparece  a  continuación.*/    public class AnimacionProxy : Animacion
    {
        protected Video video = null;
        protected string foto = "mostrar la foto";
        public void clic()
        {
            if (video == null)
            {
                video = new Video();
                video.carga();
            }
            video.reproduce();
        }
        public void dibuja()
        {
            if (video != null)
                video.dibuja();
            else
                dibuja(foto);
        }
        public void dibuja(string foto)
        {
            Console.WriteLine(foto);
        }
/*Por último, la clase VistaVehiculo que representa al programa principal se escribe de la siguiente manera.*/
        public class VistaVehiculo
        {
            static void Main(string[] args)
            {
                Animacion animacion = new AnimacionProxy();
                animacion.dibuja();
                animacion.clic();
                animacion.dibuja();
            }
        }
        Console.ReadKey();
    }
}

La ejecución de este programa muestra la diferencia de comportamiento del método dibuja del proxy según el método clic haya sido invocado previamente o no.

#RESULTADO:

mostrar la foto 
Cargar el vídeo 
Reproducir el vídeo 
Mostrar el vídeo
