using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{


    public interface FormularioImpl
    {
        void dibujaTexto(string texto);
        string administraZonaIndicada();
    }
    /// //////////

    public class FormHtmlImpl : FormularioImpl
    {
        public void dibujaTexto(string texto)
        {
            Console.WriteLine("HTML: " + texto);
        }
        public string administraZonaIndicada()
        {
            return Console.ReadLine();
        }
    }

    public class FormAppletImpl : FormularioImpl
    {
        public void dibujaTexto(string texto)
        {
            Console.WriteLine("Applet: " + texto);
        }
        public string administraZonaIndicada()
        {
            return Console.ReadLine();
        }
    }

    public abstract class FormularioMatriculacion
    {
        protected string contenido;
        protected FormularioImpl implementacion;
        public FormularioMatriculacion(FormularioImpl
        implementacion)
        {
            this.implementacion = implementacion;
        }
        public void visualiza()
        {
            implementacion.dibujaTexto(
            "número de matrícula existente: ");
        }

        public void generaDocumento()
        {
            implementacion.dibujaTexto("Solicitud de matriculación");
            implementacion.dibujaTexto("número de matrícula: " +
            contenido);
        }
        public bool administraZona()
        {
            contenido = implementacion.administraZonaIndicada();
            return this.controlZona(contenido);
        }
        protected abstract bool controlZona(string matricula);
    }


    public class FormularioMatriculacionEspaña :FormularioMatriculacion
    {
        public FormularioMatriculacionEspaña(FormularioImpl
        implementacion)
            : base(implementacion) { }
        protected override bool controlZona(string matricula)
        {
            return matricula.Length == 7;
        }
    }



    public class FormularioMatriculacionPortugal :
    FormularioMatriculacion
    { 
        public FormularioMatriculacionPortugal(FormularioImpl 
        implementacion) : base(implementacion) { } 
        protected override bool controlZona(string matricula) 
        { 
        return matricula.Length == 6; 
        } 
        }



    /// <summary>
    /// ////////////////////////////////////
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            FormularioMatriculacionPortugal formulario1 = new
                FormularioMatriculacionPortugal(new FormHtmlImpl());
            formulario1.visualiza();
            if (formulario1.administraZona())
                formulario1.generaDocumento();
            Console.WriteLine();
            FormularioMatriculacionEspaña formulario2 = new
            FormularioMatriculacionEspaña(new FormAppletImpl());
            formulario2.visualiza();
            if (formulario2.administraZona())
                formulario2.generaDocumento();
        }
    }
}
