using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator_GarciaJoel
{
    public class Boton : Control
    {
        public Boton(string nombre) : base(nombre) { }
        public override void informa()
        {
            Console.WriteLine("¿Desea activar el botón " + nombre + " ?");
            string respuesta = Console.ReadLine();
            if (respuesta == "sí")
                this.modifica();
        }
    }
    //*Clase CONTROL*
    public abstract class Control
    {
        public string valor { get; protected set; }
        public Formulario Director { get; set; }
        public string nombre { get; protected set; }
        public Control(string nombre)
        {
            this.valor = "";
            this.nombre = nombre;
        }
        public abstract void informa();
        protected void modifica()
        {
            Director.controlModificado(this);
        }
    }
    //*Clase Formulario*
    public class Formulario
    {
        protected IList<Control> controles =
new List<Control>();
        protected IList<Control> controlesCoprestatario =
        new List<Control>();
        public PopupMenu menuCoprestatario { protected get; set; }
        public Boton botonOK { protected get; set; }
        protected bool enCurso = true;
        public void agregaControl(Control control)
        {
            controles.Add(control);
            control.Director = this;
        }
        public void agregaControlCoprestatario(Control
        control)
        {
            controlesCoprestatario.Add(control);
            control.Director = this;
        }
        public void controlModificado(Control control)
        {
            if (control == menuCoprestatario)
                if (control.valor == "con coprestatario")
                {
                    foreach (Control elementoCoprestatario in
                    controlesCoprestatario)
                        elementoCoprestatario.informa();
                }
            if (control == botonOK)
            {
                enCurso = false;
            }
        }
        public void informa()
        {
            while (true)
            {
                foreach (Control control in controles)
                {
                    control.informa();
                    if (!enCurso)
                        return;
                }
            }
        }
    }
    //*Clase POPUPMENU*
    public class PopupMenu : Control
    {
        protected IList<string> opciones =
new List<string>();
        public PopupMenu(string nombre) : base(nombre) { }
        public override void informa()
        {
            Console.WriteLine("Información de: " + nombre);
            Console.WriteLine("Valor actual: " + valor);
            for (int indice = 0; indice < opciones.Count; indice++)
                Console.WriteLine("- " + indice + " )" +
                opciones[indice]);
            int eleccion = int.Parse(Console.ReadLine());
            if ((eleccion >= 0) && (eleccion < opciones.Count))
            {
                bool cambia = (valor != opciones[eleccion]);
                if (cambia)
                {
                    valor = opciones[eleccion];
                    this.modifica();
                }
            }
        }
        public void agregaOpcion(string opcion)
        {
            opciones.Add(opcion);
        }
    }
    //*Clase ZONAINFORMACION*
    public class ZonaInformacion : Control
    {
        public ZonaInformacion(string nombre) : base(nombre) { }
        public override void informa()
        {
            Console.WriteLine("Información de: " + nombre);
            valor = Console.ReadLine();
            this.modifica();
        }
    }
    //*Clase PROGRAM*
    static class Program
    {

        static void Main()
        {
            Formulario formulario = new Formulario();
            formulario.agregaControl(new ZonaInformacion("Nombre"));
            formulario.agregaControl(new
            ZonaInformacion("Apellidos"));
            PopupMenu menu = new PopupMenu("Coprestatario");
            menu.agregaOpcion("sin coprestatario");
            menu.agregaOpcion("con coprestatario");
            formulario.agregaControl(menu);
            formulario.menuCoprestatario = menu;
            Boton boton = new Boton("OK");
            formulario.agregaControl(boton);
            formulario.botonOK = boton;
            formulario.agregaControlCoprestatario(new
            ZonaInformacion("Nombre del coprestatario"));
            formulario.agregaControlCoprestatario(new
            ZonaInformacion("Apellidos del coprestatario"));
            formulario.informa();
        }
    }
}