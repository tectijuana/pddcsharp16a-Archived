El patrón Command tiene como objetivo transformar una solicitud en un objeto, facilitando operaciones tales como la anulación, el encolamiento de solicitudes y su seguimiento.
Ejemplo

En ciertos casos, la gestión de una solicitud puede ser bastante compleja: puede ser anulable, encolada o trazada. En el marco del sistema de venta de vehículos, el gestor puede solicitar al catálogo rebajar el precio de los vehículos de ocasión que llevan en el stock cierto tiempo. Por motivos de simplicidad, esta solicitud debe poder ser anulada y, eventualmente, restablecida. Para gestionar esta anulación, una primera solución consiste en indicar a nivel de cada vehículo si está o no rebajado. Esta solución no es suficiente pues un mismo vehículo puede estar rebajado varias veces con tasas diferentes. Otra solución sería conservar su precio antes de la última rebaja, aunque esta solución no es satisfactoria pues la anulación puede realizarse sobre otra solicitud de rebaja que no sea la última.

El patrón Command resuelve este problema transformando la solicitud en un objeto cuyos atributos van a contener los parámetros así como el conjunto de objetos sobre los que la solicitud va a ser aplicada. En nuestro ejemplo, esto hace posible anular o restablecer una solicitud de rebaja.
El patrón se utiliza en los casos siguientes:

    Un objeto debe configurarse para realizar un procesamiento concreto. En el caso del patrón Command, es el solicitante el que se configura mediante una solicitud que contiene la descripción de un procesamiento a realizar sobre uno o varios receptores;
    las solicitudes deben encolarse y poder ejecutarse en un momento cualquiera, eventualmente varias veces;
    las solicitudes pueden ser anuladas;
    las solicitudes deben quedar registradas en un archivo de log;
    las solicitudes deben estar reagrupadas bajo la forma de una transacción. Una transacción es un conjunto ordenado de solicitudes que actúan sobre el estado de un sistema y que pueden ser anuladas.

