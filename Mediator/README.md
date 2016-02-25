# _**Mediator**_
Propósito
Define un objeto que encapsula como interactúan una serie de objetos. Promueve un bajo
acoplamiento al evitar que los objetos se refieran unos a otros explícitamente y permite variar
la interacción entre ellos de forma independiente.
## Motivación
Los diseñadores orientados a objetos promueven la distribución de comportamiento entre
objetos. Esto puede dar a lugar una estructura de objetos con muchas conexiones entre
ellos; en el peor de los casos, cada objeto acaba por conocer a todos los demás.
Aunque dividir un sistema en muchos objetos suele mejorar la reutilización, la proliferación de
interconexiones tiende a reducir esta de nuevo. Tener muchas interconexiones hace que sea
menos probable que un objeto pueda funcionar sin la ayuda de otros. Mas aún, puede ser
difícil cambiar el comportamiento del sistema de manera significativa, ya que el mismo se
encuentra distribuido en muchos objetos. Como resultado, podemos vernos forzados a definir
muchas subclases para personalizar el comportamiento del sistema.
Estos problemas pueden ser evitados encapsulando el comportamiento colectivo en un
objeto aparte llamado Mediador, responsable de controlar y coordinar las interacciones entre
un grupo de objetos, evitando que los mismos se refieran unos a otros explícitamente. Los
objetos solo conocen al Mediador, reduciendo así el numero de interconexiones.
## Aplicabilidad
Usar Mediator cuando:

1. Un conjunto de objetos se comunican de forma bien definida, pero compleja. Las
interdependencias resultantes no están estructuradas y son difíciles de comprender.
2.Es difícil reutilizar un objeto, ya que este se refiere a otros muchos objetos con los
que se comunica.
3. Un comportamiento que esta distribuido entre varias clases debería poder ser
adaptado sin necesidad de una gran cantidad de subclases.

>Germán Verdoza González -12211479

>Gómez Cuandón Julio Cesar  -12211462

