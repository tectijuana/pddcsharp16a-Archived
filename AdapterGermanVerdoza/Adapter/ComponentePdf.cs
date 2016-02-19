using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class ComponentePdf
    {
        protected string contenido;
        public void obtenerpdf(string contenido)
        {
            this.contenido = contenido;
        }

        public void prepararpfd()
        {
            Console.WriteLine("Mostrar PDF: Comienzo");
        }

        public void actualizarpdf()
        {
            Console.WriteLine("Mostrar contenido PDF: " + contenido);
        }

        public void finalizarpdf()
        {
            Console.WriteLine("Mostrar PDF: Fin");
        }

        public void imprimirpdf()
        {
            Console.WriteLine("Imprimir PDF: " + contenido);
        }
    }
}
