Patron Adapter

El patrón Adapter sirve para hacer que dos interfaces, en principio diferentes,
puedan comunicarse. Para ello añadiremos un adaptador intermedio, que se
encargará de realizar la conversión de una interface a otra.

Este patrón se utiliza generalmente cuándo ya existe una interface, pero no
podemos (o no queremos) usarla. Por ejemplo, cuando tenemos que utilizar
librerías externas.

Convierte la interfaz de una clase en otra interfaz que el cliente espera. 
Adapter permite a las clases trabajar juntas, lo que de otra manera no podría
hacerlo debido a sus interfaces incompatibles.

Se aplica cuando:

Se desea usar una clase existente, y su interfaz no se iguala con la necesitada.
Cuando se desea crear una clase reusable que coopera con clases no relacionadas
, es decir, las clases no tienen necesariamente interfaces compatibles.

