using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class Program
    {

        public interface Catalogo 
{ 
IList<string> buscaVehiculos(int precioMin, int 
precioMax); 
} 

public class ComponenteCatalogo : Catalogo 
    { 
    protected object[] descripcionVehiculo =  
            { 
            "Berlina 5 puertas", 6000, "Compacto 3 puertas", 4000,  
            "Espace 5 puertas", 8000, "Break 5 puertas", 7000,  
            "Coupé 2 puertas", 9000, "Utilitario 3 puertas", 5000 
            }; 
            public IList<string> buscaVehiculos(int precioMin, 
            int precioMax) 
            { 
            int indice, tamaño; 
            IList<string> resultado = new List<string>(); 
            tamaño = descripcionVehiculo.Length / 2; 
            for (indice = 0; indice < tamaño; indice++) 
            { 
            int precio = (int)descripcionVehiculo[2 * indice + 1]; 
            if ((precio >= precioMin) && (precio <= precioMax)) 
            resultado.Add((string)descripcionVehiculo[2 * 
            indice]); 
            } 
            return resultado; 
    } 
}

        public interface GestionDocumento 
        { 
        string documento(int indice); 
        }

        public class ComponenteGestionDocumento : GestionDocumento
        {
            public string documento(int indice)
            {
                return "Documento número " + indice;
            }
        }

        public interface WebServiceAuto
        {
            string documento(int indice);
            IList<string> buscaVehiculos(int precioMedio, int
            desviacionMax);
        }

        public class WebServiceAutoImpl : WebServiceAuto
        {
            protected Catalogo catalogo = new ComponenteCatalogo();
            protected GestionDocumento gestionDocumento = new
            ComponenteGestionDocumento();
            public string documento(int indice)
            {
                return gestionDocumento.documento(indice);
            }
            public IList<string> buscaVehiculos(int precioMedio,
            int desviacionMax)
            {
                return catalogo.buscaVehiculos(precioMedio -
                desviacionMax, precioMedio + desviacionMax);
            }
        }

        ////////

        static void Main(string[] args)
        {
            WebServiceAuto webServiceAuto = new
            WebServiceAutoImpl();
            Console.WriteLine(webServiceAuto.documento(0));
            Console.WriteLine(webServiceAuto.documento(1));
            IList<string> resultados =
            webServiceAuto.buscaVehiculos(6000, 1000);
            if (resultados.Count > 0)
            {
                Console.WriteLine(
                "Vehículo(s) cuyo precio está comprendido " +
                "entre 5000 y 7000");
                foreach (string resultado in resultados)
                    Console.WriteLine(" " + resultado);
            }
            Console.ReadKey();
        }
    }
}
