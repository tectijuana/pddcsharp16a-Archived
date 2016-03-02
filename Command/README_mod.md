# Patrón Command #
El patrón Command tiene como objetivo transformar una solicitud en un objeto, facilitando operaciones tales como la anulación, el encolamiento de solicitudes y su seguimiento.

## Ejemplo ##

En ciertos casos, la gestión de una solicitud puede ser bastante compleja: puede ser anulable, encolada o trazada. En el marco del sistema de venta de vehículos, el gestor puede solicitar al catálogo rebajar el precio de los vehículos de ocasión que llevan en el stock cierto tiempo. Por motivos de simplicidad, esta solicitud debe poder ser anulada y, eventualmente, restablecida. Para gestionar esta anulación, una primera solución consiste en indicar a nivel de cada vehículo si está o no rebajado. Esta solución no es suficiente pues un mismo vehículo puede estar rebajado varias veces con tasas diferentes. Otra solución sería conservar su precio antes de la última rebaja, aunque esta solución no es satisfactoria pues la anulación puede realizarse sobre otra solicitud de rebaja que no sea la última.

El patrón Command resuelve este problema transformando la solicitud en un objeto cuyos atributos van a contener los parámetros así como el conjunto de objetos sobre los que la solicitud va a ser aplicada. En nuestro ejemplo, esto hace posible anular o restablecer una solicitud de rebaja.


## El patrón se utiliza en los casos siguientes: ##

* Un objeto debe configurarse para realizar un procesamiento concreto. En el caso del patrón Command, es el solicitante el que se configura mediante una solicitud que contiene la descripción de un procesamiento a realizar sobre uno o varios receptores;
* Las solicitudes deben encolarse y poder ejecutarse en un momento cualquiera, eventualmente varias veces;
* Las solicitudes pueden ser anuladas;
* Las solicitudes deben quedar registradas en un archivo de log;
* Las solicitudes deben estar reagrupadas bajo la forma de una transacción. Una transacción es un conjunto ordenado de solicitudes que actúan sobre el estado de un sistema y que pueden ser anuladas.

### **Código PDD Command
        using System;
        using System.Collections.Generic;
        using System.Linq;
        using System.Text;

        namespace PDDCommand
        {
            public class Program
            {
                public class Vehiculo
                {
                    protected string nombre;
                    protected long fechaEntradaStock;
                    protected double precioVenta;
                    public Vehiculo(string nombre, long fechaEntradaStock,double precioVenta)
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
                    public SolicitudRebaja(long hoy, long tiempoEnStock,double tasaDescuento)
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
                    protected IList<SolicitudRebaja> solicitudes =new List<SolicitudRebaja>();
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

