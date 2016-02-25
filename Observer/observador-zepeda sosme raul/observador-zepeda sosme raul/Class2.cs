using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class VistaVehiculo : Observador {
protected Vehiculo vehiculo;
protected string texto = "";

public VistaVehiculo(Vehiculo vehiculo) {
this.vehiculo = vehiculo;
vehiculo.agrega(this);
actualizaTexto();
}

protected void actualizaTexto()  {
   texto = "Descripción " + vehiculo.descripcion + " Precio: " + vehiculo.precio;
 }

public void actualiza() {
actualizaTexto();
this.redibuja();
}

public void redibuja(){ 
Console.WriteLine(texto);
}
}