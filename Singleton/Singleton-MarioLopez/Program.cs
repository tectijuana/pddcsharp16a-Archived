using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace singletonn
{
    class Program
    {
        public class Singleton
        {
            // Declaramos un atributo del mismo tipo de la clase con carácter estático
            private static Singleton _instancia = null;

            public string Nombre { get; set; }
            public DateTime HoraArranque { get; set; }

            // Constructor privado. Únicamente puede ser invocado desde el interior
            // de la propia clase
            private Singleton()
            {
                Nombre = "Patrón Singleton";
                HoraArranque = DateTime.Now;
            }

            // Property de solo lectura
            public static Singleton Instance
            {
                get
                {
                    // Si el singleton no ha sido creado previamente, se instancia.
                    // En caso contrario, se devolvera el que haya sido creado previamente
                    if (_instancia == null)
                        _instancia = new Singleton();

                    // Se devuelve la instancia
                    return _instancia;
                }
            }
        }

        static void Main(string[] args)
        {
            Singleton s = Singleton.Instance;

            // Hacemos una pausa de tres segundos
            Thread.Sleep(3000);

            // Intentamos instanciar un segundo Singleton
            Singleton s2 = Singleton.Instance;

            // Comprobamos que ambos objetos son referencias a la misma
            // instancia, que es única
            Console.WriteLine(string.Format("Instancia {0} creada a las {1}",
                s.Nombre, s.HoraArranque.ToLongTimeString()));
            Console.WriteLine(string.Format("Instancia {0} creada a las {1}",
                s2.Nombre, s2.HoraArranque.ToLongTimeString()));

            Console.ReadLine();

        }
    }
}
