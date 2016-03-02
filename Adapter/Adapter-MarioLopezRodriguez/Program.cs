using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    public interface Documento
    {
        string contenido { set; }
        void dibuja();
        void imprime();
    }

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
            Console.WriteLine("Dibuja el documento HTML: " +
            contenido);
        }

        public void imprime()
        {
            Console.WriteLine("Imprime el documento HTML: " +
            contenido);
        }
    }

    public class ComponentePdf 
{ 
    protected string contenido; 
    public void pdfFijaContenido(string contenido)
    {
        this.contenido = contenido;
    }
    public void pdfPreparaVisualizacion()
    {
        Console.WriteLine("Visualiza PDF: Comienzo");
    }
    public void pdfRefresca()
    {
        Console.WriteLine("Visualiza contenido PDF: " +
        contenido);
    }
    public void pdfFinalizaVisualizacion()
    {
        Console.WriteLine("Visualiza PDF: Fin");
    }
    public void pdfEnviaImpresora()
    {
        Console.WriteLine("Impresión PDF: " + contenido);
    }
}

    public class DocumentoPdf : Documento
    {
        protected ComponentePdf herramientaPdf = new ComponentePdf();
        public string contenido
        {
            set
            {
                herramientaPdf.pdfFijaContenido(value);
            }
        }
        public void dibuja()
        {
            herramientaPdf.pdfPreparaVisualizacion();
            herramientaPdf.pdfRefresca();
            herramientaPdf.pdfFinalizaVisualizacion();
        }
        public void imprime()
        {
            herramientaPdf.pdfEnviaImpresora();
        }
    }


    ////////////////
    class Program
    {
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
 //////////////////
}
