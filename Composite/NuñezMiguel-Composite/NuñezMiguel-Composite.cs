using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patron_Composite
{
    public abstract class Empresa
    {

        protected static double costeUnitarioVehiculo = 5.0;

        protected int nVehiculos;

        public void agregaVehiculo()
        {

            nVehiculos = nVehiculos + 1;

        }

        public abstract double calculaCosteMantenimiento();

        public abstract bool agregaFilial(Empresa filial);

    }

    public class EmpresaSinFilial : Empresa
    {

        public override bool agregaFilial(Empresa filial)
        {

            return false;

        }

        public override double calculaCosteMantenimiento()
        {

            return nVehiculos * costeUnitarioVehiculo;

        }

    }
    public class EmpresaMadre : Empresa
    {

        protected IList<Empresa> filiales =

        new List<Empresa>();

        public override bool agregaFilial(Empresa filial)
        {

            filiales.Add(filial);

            return true;

        }
        public override double calculaCosteMantenimiento()
        {

            double coste = 0.0;

            foreach (Empresa filial in filiales)

                coste = coste + filial.calculaCosteMantenimiento();

            return coste + nVehiculos * costeUnitarioVehiculo;

        }

    }
    public class Usuario
    {

        static void Main(string[] args)
        {

            Empresa empresa1 = new EmpresaSinFilial();

            empresa1.agregaVehiculo();

            Empresa empresa2 = new EmpresaSinFilial();

            empresa2.agregaVehiculo();

            empresa2.agregaVehiculo();

            Empresa grupo = new EmpresaMadre();

            grupo.agregaFilial(empresa1);

            grupo.agregaFilial(empresa2);

            grupo.agregaVehiculo();

            Console.WriteLine(

            "Coste de mantenimiento total del grupo: " +

            grupo.calculaCosteMantenimiento());

            Console.ReadKey();

        }

    }
}
