using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class DocumentoHtml : Documento
    {
        protected string _contenido;
        public string contenido
        {
            protected get
            {
                return _contenido;
            }

            set
            {
                _contenido = value;
            }
        }

        public void dibuja()
        {
            Console.WriteLine("Dibuja el documento HTML: " + contenido);
        }

        public void imprime()
        {
            Console.WriteLine("Imprime el documento HTML: " + contenido);
        }
    }
}
