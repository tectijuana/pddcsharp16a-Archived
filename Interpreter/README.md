Favor de explicar el Patron de este directorio a nuestros visitantes.

#***Patron Interpreter***

##Concepto
Proporciona un marco para dar una representación mediante objetos de la gramática de un lenguaje con el objetivo de evaluar, interpretándolas, expresiones escritas en este lenguaje.

![](http://www.godtic.com/blog/wp-content/uploads/2012/11/gof-interpreter.png)

##Participantes
Expresión: es una clase abstracta que representa cualquier tipo de expresión, es decir cualquier nodo del árbol sintáctico;

OperadorAbstracto (OperadorBinario): Es también una clase abstracta. Describe cualquier nodo de tipo operador, es decir que posea operandos que son subárboles del árbol sintáctico.

OperadorConcreto1 y OperadorConcreto2 (OperadorY, OperadorO): Son implementaciones del OperadorAbstracto que describen completamente la semántica del operador y por tanto son capaces de evaluarlo.

ElementoTerminal: Es una clase abstracta que describe cualquier nodo correspondiente a un elemento terminal.

ElementoTerminalConcreto1 y ElementoTerminalConcreto2 (PalabraClave): Son clases concretas que corresponden con un elemento terminal, capaces de evaluar este elemento.

###Material de Apoyo
[Hacer click para reproducir video de youtube: Patron Interpreter](https://www.youtube.com/watch?v=p3adWU_Z4Yk)
