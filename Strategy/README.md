Patron Strategy:

“Definir una familia de algoritmos, encapsular cada uno de ellos y hacerlos intercambiables. 
Strategy permite cambiar el algoritmo independientemente de los clientes que lo utilicen”.

El nombre de este patrón evoca la posibilidad de realizar un cambio de estrategia en tiempo de ejecución sustituyendo un objeto que se encargará de implementarla. No nos preocupará el “cómo”.
De hecho, ni siquiera nos importará “el qué”: la clase que actúa como interfaz del patrón únicamente tendrá que exponer el método o métodos que deberá invocar el cliente.
