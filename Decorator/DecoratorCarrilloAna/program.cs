using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace decorator
{
    class Program
    {

        public interface ComponenteGraficoVehiculo
        {

            void visualiza();

        }
        public class VistaVehiculo : ComponenteGraficoVehiculo
        {

            public void visualiza()
            {

                Console.WriteLine("Visualización del vehículo");

            }

        }
        public abstract class Decorador :

 ComponenteGraficoVehiculo
        {

            protected ComponenteGraficoVehiculo componente;

            public Decorador(ComponenteGraficoVehiculo componente)
            {

                this.componente = componente;

            }

            public virtual void visualiza()
            {

                componente.visualiza();

            }

        }
        public class ModeloDecorador : Decorador
        {

            public ModeloDecorador(ComponenteGraficoVehiculo

            componente)

                : base(componente) { }

            protected void visualizaInformacionTecnica()
            {

                Console.WriteLine("Información técnica del modelo");

            }

            public override void visualiza()
            {

                base.visualiza();

                this.visualizaInformacionTecnica();

            }

        }
        public class MarcaDecorador : Decorador
        {

            public MarcaDecorador(ComponenteGraficoVehiculo componente) : base(componente) { }

            protected void visualizaLogo()
            {
                Console.WriteLine("Logotipo de la marca");
            }

            public override void visualiza()
            {
                base.visualiza();
                this.visualizaLogo();

            }

        }
        public class VistaCatalogo
        {

            static void Main(string[] args)
            {

                VistaVehiculo vistaVehiculo = new VistaVehiculo();

                ModeloDecorador modeloDecorador = new

                ModeloDecorador(vistaVehiculo);

                MarcaDecorador marcaDecorador = new

                MarcaDecorador(modeloDecorador);

                marcaDecorador.visualiza();
                Console.ReadKey();

            }

        }
    }
}
