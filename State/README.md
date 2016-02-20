Favor de explicar el Patron de este directorio a nuestros visitantes.

Patron Abstract Factory:

El problema que intenta solucionar este patron es el de crear diferentes familias de objetos, 
es decir, nos ayuda a crear diferentes objetos de la misma familia, por ejemplo: las bibliotecas, 
para crear interfaces graficas suelen utilizar este patron y cada familia seria un sistema operativo distinto. 
Asi pues, el usuario declara un Boton, pero de forma mas interna lo que esta creando es un BotonWindows o un BotonLinux, por ejemplo.

Este patron esta aconsejado cuando se preve la inclusion de nuevas familias de productos,
pero puede resultar contraproducente cuando se a;aden nuevos productos o cambian los existentes, 
puesto que afectaria a todas las familias creadas.
