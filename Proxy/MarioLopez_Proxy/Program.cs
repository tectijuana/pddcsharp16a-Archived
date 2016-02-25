using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System; using System.Collections.Generic; using System.Linq; using System.Text; namespace ConsoleApplication1 
{ public interface Animacion 
{ void dibuja(); 
    void clic(); } //El código fuente C# de la clase Video que implementa esta interfaz aparece a continuación. En el marco de la simulación cada método muestra simplemente un mensaje, excepto el método clic que no realiza ninguna acción./ 
    public class Video : Animacion 
    { public void clic() 
    { }
        public void dibuja() 
        { Console.WriteLine("Mostrar el vídeo"); } 
        public void carga() 
        { Console.WriteLine("Cargar el vídeo"); } 
        public void reproduce() { Console.WriteLine("Reproducir el vídeo"); } } //El código fuente del proxy, y por tanto de la clase AnimacionProxy aparece a continuación./
        public class AnimacionProxy : Animacion { protected Video video = null; protected string foto = "mostrar la foto";
            public void clic() {
                if (video == null) 
                { video = new Video(); video.carga(); } 
                video.reproduce(); } public void dibuja()
                { if (video != null) video.dibuja(); else dibuja(foto); }
            public void dibuja(string foto) { Console.WriteLine(foto); }//Por último, la clase VistaVehiculo que representa al programa principal se escribe de la siguiente manera./ 
            
            public class VistaVehiculo 
            { static void Main(string[] args) 
            {
                Animacion animacion = new AnimacionProxy(); animacion.dibuja(); animacion.clic(); animacion.dibuja(); 
            Console.ReadKey();
            }
            } 
        } 
}