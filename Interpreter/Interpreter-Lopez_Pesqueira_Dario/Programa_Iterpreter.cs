using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patron_Interpreter
{
    public class PalabraClave : Expresion
    {
        protected string palabraClave;

        public PalabraClave(string palabraClave)
        {
            this.palabraClave = palabraClave;
        }
        public override bool evalua(string descripcion)
        {
            return descripcion.IndexOf(palabraClave) != -1;
        }
        // parte análisis sintáctico
        public static new Expresion parsea()
        {
            Expresion resultado;
            resultado = new PalabraClave(pieza);
            siguientePieza();
            return resultado;
        }
    }

    public class OperadorY : OperadorBinario
    {
        public OperadorY(Expresion operandoIzquierdo,
Expresion operandoDerecho)
            : base(operandoIzquierdo,
                operandoDerecho) { }
        public override bool evalua(string descripcion)
        {
            return operandoIzquierdo.evalua(descripcion) &&
            operandoDerecho.evalua(descripcion);
        }
        // parte análisis sintáctico
        public static new Expresion parsea()
        {
            Expresion resultadoIzquierdo, resultadoDerecho;
            resultadoIzquierdo = Expresion.parsea();
            while ((pieza != null) && (pieza == "y"))
            {
                siguientePieza();
                resultadoDerecho = Expresion.parsea();
                resultadoIzquierdo = new OperadorY(resultadoIzquierdo,
                resultadoDerecho);
            }
            return resultadoIzquierdo;
        }
    }

    public abstract class OperadorBinario : Expresion
    {
        protected Expresion operandoIzquierdo, operandoDerecho;

        public OperadorBinario(Expresion operandoIzquierdo,
        Expresion operandoDerecho)
        {
            this.operandoIzquierdo = operandoIzquierdo;
            this.operandoDerecho = operandoDerecho;
        }
    }

    public class OperadorO : OperadorBinario
    {
        public OperadorO(Expresion operandoIzquierdo,
Expresion operandoDerecho)
            : base(operandoIzquierdo,
            operandoDerecho) { }

        public override bool evalua(string descripcion)
        {
            return operandoIzquierdo.evalua(descripcion) ||
            operandoDerecho.evalua(descripcion);
        }
        // parte análisis sintáctico
        public static new Expresion parsea()
        {
            Expresion resultadoIzquierdo, resultadoDerecho;
            resultadoIzquierdo = OperadorY.parsea();
            while ((pieza != null) && (pieza == "o"))
            {
                siguientePieza();
                resultadoDerecho = OperadorY.parsea();
                resultadoIzquierdo = new OperadorO(resultadoIzquierdo,
                resultadoDerecho);
            }
            return resultadoIzquierdo;
        }
    }

    public abstract class Expresion
    {
        public abstract bool evalua(string descripcion);

        // parte análisis sintáctico
        protected static string fuente;
        protected static int indice;
        protected static string pieza;

        protected static void siguientePieza()
        {
            while ((indice < fuente.Length) && (fuente[indice] == ' '))
                indice++;
            if (indice == fuente.Length)
                pieza = null;
            else if ((fuente[indice] == '(') || (fuente[indice] == ')'))
            {
                pieza = fuente.Substring(indice, 1);
                indice++;
            }
            else
            {
                int inicio = indice;
                while ((indice < fuente.Length) && (fuente[indice] != ' ') && (fuente[indice] != ')'))
                    indice++;
                pieza = fuente.Substring(inicio, indice - inicio);
            }
        }

        public static Expresion analiza(string fuente)
        {
            Expresion.fuente = fuente;
            indice = 0;
            siguientePieza();
            return OperadorO.parsea();
        }

        public static Expresion parsea()
        {
            Expresion resultado;
            if (pieza == "(")
            {
                siguientePieza();
                resultado = OperadorO.parsea();
                if (pieza == null)
                    throw new Exception("Error de sintaxis");
                if (pieza != ")")
                    throw new Exception("Error de sintaxis");
                siguientePieza();
            }
            else
                resultado = PalabraClave.parsea();

            return resultado;
        }

    }

    public class Usuario
    {
        static void Main(string[] args)
        {
            Expresion expresionConsulta = null;
            Console.Write("Introduzca su consulta: ");
            string consulta = Console.ReadLine();
            try
            {
                expresionConsulta = Expresion.analiza(consulta);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                expresionConsulta = null;
            }
            if (expresionConsulta != null)
            {
                Console.WriteLine(
                "Introduzca la descripción de un vehículo: ");
                string descripcion = Console.ReadLine();
                if (expresionConsulta.evalua(descripcion))
                    Console.WriteLine(
                    "La descripción responde a la consulta");
                else
                    Console.WriteLine(
                    "La descripción no responde a la consulta");
                Console.ReadKey();
            }

        }
    }
}
