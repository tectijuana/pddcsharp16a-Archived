using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    public abstract class Sujeto
    {
        protected IList<Observador> observadores = new List<Observador>();

        public void agrega(Observador observador)
        {
            observadores.Add(observador);
        }

        public void suprime(Observador observador)
        {
            observadores.Remove(observador);
        }

        public void notifica()
        {
            foreach (Observador observador in observadores)
                observador.actualiza();
        }
    }

    public interface Observador
    {
        void actualiza();
    }

    public class Vehiculo : Sujeto
    {
        protected string _descripcion;
        protected double _precio;

        public string descripcion
        {
            get { return _descripcion; }
            set
            {
                _descripcion = value;
                this.notifica();
            }
        }

        public double precio
        {
            get { return _precio; }

            set
            {
                _precio = value;
                this.notifica();
            }
        }
    }

    public class VistaVehiculo : Observador
    {
        protected Vehiculo vehiculo;
        protected string texto = "";

        public VistaVehiculo(Vehiculo vehiculo)
        {
            this.vehiculo = vehiculo;
            vehiculo.agrega(this);
            actualizaTexto();
        }

        protected void actualizaTexto()
        {
            texto = "Descripción " + vehiculo.descripcion + " Precio: " + vehiculo.precio;
            Console.ReadKey();
        }

        public void actualiza()
        {
            actualizaTexto();
            this.redibuja();
        }

        public void redibuja()
        {
            Console.WriteLine(texto);
        }
    }

    public class Usuario
    {
        static void Main(string[] args)
        {
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.descripcion = "Vehículo económico"; vehiculo.precio = 5000.0;
            VistaVehiculo vistaVehiculo = new VistaVehiculo(vehiculo);
            vistaVehiculo.redibuja();
            vehiculo.precio = 4500.0;
            VistaVehiculo vistaVehiculo2 = new VistaVehiculo(vehiculo);
            vehiculo.precio = 5500.0;

        }
    }
}
