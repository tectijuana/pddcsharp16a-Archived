using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_RivasLeonPaul
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Carro Electrico \n");
            AutomovilElectricidad Leaf = new AutomovilElectricidad("Leaf", "Blanco", 90, 14.5);
            Leaf.mostrarCaracteristicas();
            Console.WriteLine("Carro Gasolina \n");
            AutomovilGasolina Mustang = new AutomovilGasolina("Mustang", "Negro", 240, 14.5);
            Mustang.mostrarCaracteristicas();
        }
    }

    public abstract class Automovil
    {
        protected string modelo;
        protected string color;
        protected int potencia;
        protected double espacio;
        public Automovil(string modelo, string color, int
                         potencia, double espacio)
        {
            this.modelo = modelo;
            this.color = color;
            this.potencia = potencia;
            this.espacio = espacio;
        }
        public abstract void mostrarCaracteristicas();
    }


    public class AutomovilElectricidad : Automovil
    {
        public AutomovilElectricidad(string modelo, string
                                     color, int potencia, double espacio)
            : base(modelo,
                color, potencia, espacio)
        { }
        public override void mostrarCaracteristicas()
        {
            Console.WriteLine(
                "Automóvil eléctrico de modelo: " + modelo +
                " de color: " + color + " de potencia: " +
                potencia + " de espacio: " + espacio);
            Console.ReadKey();
        }
    }

    public class AutomovilGasolina : Automovil
    {
        public AutomovilGasolina(string modelo, string
                                 color, int potencia, double espacio)
            : base(modelo,
                color, potencia, espacio)
        { }
        public override void mostrarCaracteristicas()
        {
            Console.WriteLine(
                "Automóvil de gasolina de modelo: " + modelo +
                " de color: " + color + " de potencia: " +
                potencia + " de espacio: " + espacio);
            Console.ReadKey();
        }


    }

}
