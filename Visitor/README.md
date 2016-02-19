
**#Patron Visitor**

Este patrón permite añadir funcionalidades a una clase sin tener que modificarla, siendo usado para manejar algoritmos, relaciones y responsabilidades entre objetos.

Así pues, nos resultará útil cuando necesitemos realizar operaciones distintas y no relacionadas sobre una estructura de objetos, aunque si lo utilizamos y luego tenemos que modificar alguna de las clases implicadas, hemos de tener en cuenta que se produce cierto nivel de acoplamiento entre ellas.

Construye una operación a realizar en los elementos de un conjunto de objetos. Es posible agregar nuevas operaciones sin modificar las clases de estos objetos

El patrón visitor es una forma de separar el algoritmo de la estructura de un objeto.

Es un patrón de comportamiento, que permite definir una operación sobre objetos de una jerarquía de clases sin modificar las clases sobre las que opera. Representa una operación que se realiza sobre los elementos que conforman la estructura de un objeto.

Muy utilizado en compiladores, intérpretes y analizadores de código.

**Es recomendable usar el patrón Visitor cuando:**

    +Estructuras jerárquicas (arboles).
    +Muchas clases poco relacionadas entre sí.
    +Estructura de objetos con diferentes interfaces y posibilidad de ampliación.
    +Estructura con altas probabilidades de incluir de nuevos métodos.

