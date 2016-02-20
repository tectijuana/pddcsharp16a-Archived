#CHAIN OF RESPONSABILITY 
El patrón de diseño Chain of Responsibility es un patrón de comportamiento que evita acoplar el emisor de una petición a su receptor dando a más de un objeto la posibilidad de responder a una petición. Para ello, se encadenan los receptores y pasa la petición a través de la cadena hasta que es procesada por algún objeto. Este patrón es utilizado a menudo en el contexto de las interfaces gráficas de usuario donde un objeto puede contener varios objetos. Según si el ambiente de ventanas genera eventos, los objetos los manejan o los pasan.

Aplicabilidad

El patrón Cadena de Responsabilidad debe usarse cuando:

hay más de un objeto que puede manejar una petición, y el manejador no se conoce a priori, sino que debería determinarse automáticamente.
se quiere enviar una petición a un objeto entre varios sin especificar explícitamente el receptor.
el conjunto de objetos que pueden tratar una petición debería ser especificado dinámicamente.


Participantes

Manejador: define una interfaz para tratar las peticiones. Opcionalmente, implementa el enlace al sucesor.
ManejadorConcreto: trata las peticiones de las que es responsable; si el ManejadorConcreto puede manejar la petición, lo hace; en caso contrario la reenvía a su sucesor.
Cliente: inicializa la petición a un Manejador Concreto de la cadena.
Consecuencias

Reduce el acoplamiento. El patrón libera a un objeto de tener que saber qué otro objeto maneja una petición. Ni el receptor ni el emisor se conocen explícitamente entre ellos, y un objeto de la cadena tampoco tiene que conocer la estructura de ésta. Por lo tanto, simplifica las interconexiones entre objetos. En vez de que los objetos mantengan referencias a todos los posibles receptores, sólo tienen una única referencia a su sucesor.

Añade flexibilidad para asignar responsabilidades a objetos. Se pueden añadir o cambiar responsabilidades entre objetos para tratar una petición modificando la cadena de ejecución en tiempo de ejecución. Esto se puede combinar con la herencia para especializar los manejadores estáticamente.

Por otra parte presenta el inconveniente de no garantizar la recepción. Dado que las peticiones no tienen un receptor explícito, no hay garantías de que sean manejadas. La petición puede alcanzar el final de la cadena sin haber sido procesada.
Patrones Relacionados

Este patrón se aplica en ocasiones con el patrón Composite. En él, los padres de los componentes pueden actuar como sucesores.
