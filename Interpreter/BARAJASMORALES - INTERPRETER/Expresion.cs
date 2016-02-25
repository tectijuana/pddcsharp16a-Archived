using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patron_Interpreter
{
    public abstract class Expresion
    {
        public abstract bool evalua(string descripcion);

        // parte análisis sintáctico
        protected static string fuente;
        protected static int indice;
        protected static string pieza;

        protected static void siguientePieza()
        {
            while ((indice < fuente.Length) && (fuente[indice] ==' '))
            indice++;
            if (indice == fuente.Length)
                pieza = null;
            else if ((fuente[indice] == '(') || (fuente[indice] ==')'))
            {
                pieza = fuente.Substring(indice, 1);
                indice++;
            }
            else
            {
                int inicio = indice;
                while ((indice < fuente.Length) && (fuente[indice] !=' ') && (fuente[indice] != ')'))
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
}