Patrón de Diseño Iterator en C#

Objetivo: “Proporcionar una forma de acceder a los elementos de un objeto agregado de forma secuencial sin exponer sus detalles”.

Introducción: Proporciona un modo de acceder secuencialmente a los elementos de un objeto agregado sin exponer su representación interna.

Clasificación del Patrón: Patrón de Comportamiento.

Intención: Proporcionar una forma coherente de acceder secuencialmente a los elementos de una colección, independientemente del tipo de colección subyacente.

Funcionalidad:

•Obtener una referencia al elemento actual de la colección.

•Obtener una referencia al siguiente elemento de la colección (el situado a continuación del elemento actual).

•Obtener información sobre si existen más elementos después del actual.

•Reiniciar la colección para que el iterador apunte nuevamente al primer elemento de la colección.

Motivación: Un objeto agregado, tal como una lista, debería proveer un modo de brindar acceso a sus elementos sin exponer su estructura interna. Más aún, quizás se desea recorrer la lista en diferentes formas, dependiendo de lo que Ud. quiera realizar. Pero, probablemente, la idea no es aumentar la interfaz de la lista con operaciones para recorridos diferentes, aún anticipando los que se necesitarán. Tal vez, también se necesite tener más de un recorrido en la misma lista.

El patrón Iterator permite llenar todas estas expectativas. La idea principal en este patrón es tomar la responsabilidad del acceso y recorrido de la lista y colocarla dentro del objeto iterator. La clase Iterator define una interfaz para el acceso de los elementos de la lista. Un objeto iterador es responsable de mantener la pista del elemento actual; esto es, sabe cuáles elementos ya han sido recorridos.

Participantes:

Las entidades participantes en el diseño propuesto por el patrón iterador son:

•Iterador (Iterator): Define la interfaz para recorrer el agregado de elementos y acceder a ellos, de manera que el cliente no tenga que conocer los detalles y sea capaz de manejarlos de todos modos.

•Iterador Concreto (ConcreteIterator): Implementa la interfaz propuesta por el Iterador. Es el que se encarga de mantener la posición actual en el recorrido de la estructura.

•Agregado (Aggregate): Define la interfaz para el método de fabricación de iteradores.

•Agregado Concreto (ConcreteAggregate): Implementa la estructura de datos y el método de fabricación de iteradores que crea un iterador específico para su estructura.
