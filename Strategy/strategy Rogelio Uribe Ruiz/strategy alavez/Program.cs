using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace strategy_alavez
{
    class Program
    {
        public interface DibujaCatalogo
        {
            void dibuja(IList<VistaVehiculo> contenido);
        }

        public class DibujaUnVehiculoPorLinea : DibujaCatalogo
        {
            public void dibuja(IList<VistaVehiculo> contenido)
            {
                Console.WriteLine(
                "Dibuja los vehículos mostrando un vehículo por línea");
                foreach (VistaVehiculo vistaVehiculo in contenido)
                {
                    vistaVehiculo.dibuja();
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
        public class DibujaTresVehiculosPorLinea : DibujaCatalogo
{
 public void dibuja(IList<VistaVehiculo> contenido)
 {
 int contador;
 Console.WriteLine(
 "Dibuja los vehículos mostrando tres vehículos por línea");
 contador = 0;
 foreach (VistaVehiculo vistaVehiculo in contenido)
 {
 vistaVehiculo.dibuja();
 contador++;
 if (contador == 3)
 {
 Console.WriteLine();
 contador = 0;
 }
 else
     Console.Write(" ");
 }
 if (contador != 0)
     Console.WriteLine();
 Console.WriteLine();
 }
}

        public class VistaVehiculo
        {
            protected string descripcion;
            public VistaVehiculo(string descripcion)
            {
                this.descripcion = descripcion;
            }
            public void dibuja()
            {
                Console.Write(descripcion);
            }
        }
        public class VistaCatalogo
        {
            protected IList<VistaVehiculo> contenido =
            new List<VistaVehiculo>();
            protected DibujaCatalogo dibujo;
            public VistaCatalogo(DibujaCatalogo dibujo)
            {
                contenido.Add(new VistaVehiculo("vehículo económico"));
                contenido.Add(new VistaVehiculo("vehículo especial"));
                contenido.Add(new VistaVehiculo("vehículo rápido"));
                contenido.Add(new VistaVehiculo("vehículo confortable"));
                contenido.Add(new VistaVehiculo("vehículo deportivo"));
                this.dibujo = dibujo;
            }
            public void dibuja()
            {
                dibujo.dibuja(contenido);
            }
        }
        static void Main(string[] args)
        {
            VistaCatalogo vistaCatalogo1 = new VistaCatalogo(new
 DibujaTresVehiculosPorLinea());
            vistaCatalogo1.dibuja();
            VistaCatalogo vistaCatalogo2 = new VistaCatalogo(new
            DibujaUnVehiculoPorLinea());
            vistaCatalogo2.dibuja();
            Console.ReadKey();
        }
    }
}
