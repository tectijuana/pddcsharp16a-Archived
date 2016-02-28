using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    public class Program
    {
        public class Vehiculo
        {
            protected string nombre;
            protected long fechaEntradaStock;
            protected double precioVenta;
            public Vehiculo(string nombre, long fechaEntradaStock, double precioVenta)
            {
                this.nombre = nombre;
                this.fechaEntradaStock = fechaEntradaStock;
                this.precioVenta = precioVenta;
            }
            public long getTiempoEnStock(long hoy)
            {
                return hoy - fechaEntradaStock;
            }
            public void modificaPrecio(double coeficiente)
            {
                this.precioVenta = 0.01 * Math.Round(coeficiente *
                this.precioVenta * 100);
            }
            public void visualiza()
            {
                Console.WriteLine(nombre + " precio: " + precioVenta +
                " fecha entrada stock " + fechaEntradaStock);
            }

        }

        public class SolicitudRebaja
        {
            protected IList<Vehiculo> vehiculosEnStock =
            new List<Vehiculo>();
            protected long hoy;
            protected long tiempoEnStock;
            public SolicitudRebaja(long hoy, long tiempoEnStock, double tasaDescuento)
            {
                this.hoy = hoy;
                this.tiempoEnStock = tiempoEnStock;
                tasaDescuento2 = tasaDescuento;
            }
            public void rebaja(IList<Vehiculo> vehiculos)
            {
                vehiculosEnStock.Clear();
                foreach (Vehiculo vehiculo in vehiculos)
                    if (vehiculo.getTiempoEnStock(hoy) >=
                    tiempoEnStock)
                        vehiculosEnStock.Add(vehiculo);
                foreach (Vehiculo vehiculo in vehiculosEnStock)
                    vehiculo.modificaPrecio(1.0 - tasaDescuento2);
            }
            public void anula()
            {
                foreach (Vehiculo vehiculo in vehiculosEnStock)
                    vehiculo.modificaPrecio(1.0 / (1.0 - tasaDescuento2));
            }
            public void restablece()
            {
                foreach (Vehiculo vehiculo in vehiculosEnStock)
                    vehiculo.modificaPrecio(1.0 - tasaDescuento2);
            }

            public double tasaDescuento2 { get; set; }
        }

        public class Catalogo
        {
            protected IList<Vehiculo> vehiculosStock =
            new List<Vehiculo>();
            protected IList<SolicitudRebaja> solicitudes = new List<SolicitudRebaja>();
            public void ejecutaSolicitudRebaja(SolicitudRebaja solicitud)
            {
                solicitudes.Insert(0, solicitud);
                solicitud.rebaja(vehiculosStock);
            }
            public void anulaSolicitudRebaja(int orden)
            {
                solicitudes[orden].anula();
            }
            public void restableceSolicitudRebaja(int orden)
            {
                solicitudes[orden].restablece();
            }
            public void agrega(Vehiculo vehiculo)
            {
                vehiculosStock.Add(vehiculo);
            }
            public void visualiza()
            {
                foreach (Vehiculo vehiculo in vehiculosStock)
                    vehiculo.visualiza();
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Command";
            Vehiculo vehiculo1 = new Vehiculo("A01", 1, 1000.0);
            Vehiculo vehiculo2 = new Vehiculo("A11", 6, 2000.0);
            Vehiculo vehiculo3 = new Vehiculo("Z03", 2, 3000.0);
            Catalogo catalogo = new Catalogo();
            catalogo.agrega(vehiculo1);
            catalogo.agrega(vehiculo2);
            catalogo.agrega(vehiculo3);
            Console.WriteLine("Visualización inicial del catálogo");
            catalogo.visualiza();
            Console.WriteLine();
            SolicitudRebaja solicitudRebaja = new SolicitudRebaja
            (10, 5, 0.1);
            catalogo.ejecutaSolicitudRebaja(solicitudRebaja);
            Console.WriteLine("Visualización del catálogo tras " +
            "ejecutar la primera solicitud");
            catalogo.visualiza();
            Console.WriteLine();
            SolicitudRebaja solicitudRebaja2 = new SolicitudRebaja(10, 5, 0.5);
            catalogo.ejecutaSolicitudRebaja(solicitudRebaja2);
            Console.WriteLine("Visualización del catálogo tras " +
            "ejecutar la segunda solicitud");
            catalogo.visualiza();
            Console.WriteLine();
            catalogo.anulaSolicitudRebaja(1);
            Console.WriteLine("Visualización del catálogo tras " +
            "anular la primera solicitud");
            catalogo.visualiza();
            Console.WriteLine();
            catalogo.restableceSolicitudRebaja(1);
            Console.WriteLine("Visualización del catálogo tras " +
            "restablecer la primera solicitud");
            catalogo.visualiza();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}