using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplo_de_patron_de_diseño
{
    class Program
    {
        //Interfaz Documento
        public interface Documento
        {
            string contenido { set; }
            void dibuja();
            void imprime();
        }

        //La clase DocumentoHtml es el ejemplo de clase que implementa la interfaz Documento.
        public class DocumentoHtml : Documento
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

        //La clase ComponentePdf representa el componente existente que se quiere integrar en la aplicación. Su diseño es 

        //independiente  de  la  aplicación  y,  en  particular,  de  la  interfaz  Documento.  Esta  clase  tendrá  que  adaptarse  a 

        //continuación.

        public class ComponentePdf
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

        //La clase DocumentoPdf representa el adaptador. Está asociada a la clase ComponentePdf mediante el atributo 

        //herramientaPdf que se asocia con el objeto adaptado.

        public class DocumentoPdf : Documento
        {
            protected ComponentePdf hrrafdf = new ComponentePdf();
            public string contenido
            {
                set
                {
                    hrrafdf.obtenerpdf(value);
                }
            }

            public void dibuja()
            {
                hrrafdf.prepararpfd();
                hrrafdf.actualizarpdf();
                hrrafdf.finalizarpdf();
            }

            public void imprime()
            {
                hrrafdf.imprimirpdf();
            }
        }



        static void Main(string[] args)
        {
            Documento documento1, documento2;
            documento1 = new DocumentoHtml();
            documento1.contenido = "Hello";
            documento1.dibuja();
            Console.WriteLine();
            documento2 = new DocumentoPdf();
            documento2.contenido = "Hola";
            documento2.dibuja();
            Console.ReadKey();
        }
    }
}
