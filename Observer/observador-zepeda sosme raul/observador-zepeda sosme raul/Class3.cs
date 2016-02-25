using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


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
