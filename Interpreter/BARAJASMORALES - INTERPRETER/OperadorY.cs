using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patron_Interpreter
{
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
}