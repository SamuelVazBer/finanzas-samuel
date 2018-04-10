# FinanzasWeb 
## TL;DR
Implemente un sitio web a través del cual los usuarios puedan "comprar" y "vender" acciones, al igual que a continuación [Ejemplo](http://finance.cs50.net/).

![FINANZAS](/finance.png)

# Especificación
## IEX API
Para obtener los valores de las acciones utilizaremos [API](https://iextrading.com/developer/docs/#stocks)
ej. para appl que es el símbolo de Apple

https://api.iextrading.com/1.0/stock/aapl/batch?types=quote,logo,chart

````
URL base: https://api.iextrading.com/1.0/stock/
símbolo : appl (sustituir por el símbolo deseado)
Opciones :/batch?types=quote,logo,chart
````
## Consultar
Complete la implementación de consultar de tal manera que le permita al usuario buscar el precio actual de una acción.

Requerir que un usuario ingrese el símbolo de una acción, implementado como un campo de texto que llamado símbolo.

Envíe la entrada del usuario al contralodaor correpondiente



## Comprar
Complete la implementación de comprar de tal manera que permita a un usuario comprar acciones.

Requerir que un usuario ingrese el símbolo de una acción, implementado como un campo de texto que nombrado símbolo. Haga una disculpa si la entrada está en blanco o si el símbolo no existe (según el valor de retorno de la API).

Requerir que un usuario ingrese un número de acciones, implementado como un campo de numerico llamado cantidad. Haga una disculpa si la entrada no es un entero positivo.

Envíe la entrada del usuario al controlador correspondiente

Es probable que quiera llamar a la API para consultar el precio actual de una acción.

Es probable que desee saber cuánto dinero tiene actualmente el usuario (ApplicationUser campo Efectivo).

Agregue una o más tablas nuevas a finance.db a través de las cuales realizar un seguimiento de la compra. Almacene suficiente información para que sepa quién compró qué, a qué precio y cuándo.

Haga una disculpa, sin completar la compra, si el usuario no puede pagar la cantidad de acciones al precio actual.

Una vez que haya implementado comprar correctamente, podrá ver las compras de los usuarios en su (s) nueva (s) tabla (s) a través de sqlite3.

## Inicio
Complete la implementación de inicio de tal manera que muestre una tabla HTML que resuma, para el usuario actualmente conectado, qué acciones posee (como mostrar los símbolos de cotización), los números de acciones que posee, el precio actual de cada acción, y el valor total de cada tenencia (es decir, acciones por precio). También muestre el saldo en efectivo actual del usuario junto con un total general (es decir, el valor total de las acciones más efectivo).

Las probabilidades son que querrás ejecutar múltiples SELECTs. Dependiendo de cómo implemente su tabla (s), puede encontrar GROUP BY, SUM, y WHERE de su interés LINQ.



## Vender
Complete la implementación de vender de tal manera que permita a un usuario vender acciones de una acción (que él o ella posee).

Requerir que un usuario ingrese el símbolo de una acción, implementado como un menú llamado símbolo. Haga una disculpa si el usuario no selecciona una acción o si (de alguna manera, una vez enviado) el usuario no posee ninguna acción de esa acción.

Requerir que un usuario ingrese un número de acciones, implementado como un campo de numerico llamado cantidad. Haga una disculpa si la entrada no es un entero positivo o si el usuario no posee tantas acciones del stock.

Envíe la entrada al controlador correpondiente.



## Historial
Complete la implementación de historial de tal forma que muestre una tabla HTML que resuma todas las transacciones de un usuario, enumerando fila por fila todas y cada una de las compras y ventas.

Para cada fila, deje en claro si una acción fue comprada o vendida e incluya el símbolo de la acción, el precio (de compra o venta), la cantidad de acciones compradas o vendidas y la fecha y hora en que se realizó la transacción.

Puede necesitar modificar la tabla que creó en comprar complementarla con una tabla adicional. Intenta minimizar las redundancias.

## Toque personal
Implemente al menos un toque personal de su elección:

Permitir a los usuarios agregar efectivo adicional a su cuenta.

Permita a los usuarios comprar más acciones o vender acciones de las que ya poseen a través de inicio, sin tener que escribir los símbolos de las acciones manualmente.
Implemente alguna otra característica de alcance comparable.