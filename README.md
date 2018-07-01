# P02-Dataset-DataTable-i-DataView
practica de vb.net + ADO
Realizar la siguiente aplicación con tecnología ado.net

Se quiere hacer una pequeña gestión de la tabla Contacto de la base de datos CIUDADES

Las funcionalidades básicas a desarrollar son:

    Navegación entre el registros (anterior, posterior, primero, último y acceder a un id de cliente en concreto)
    Creación de nuevos contactos.
    Modificar datos de contactos.
    Eliminar registros de contactos.

Además se deben hacer las siguientes funcionalidades:

    Existirá un mecanismo para que el usuario pueda indicar que se grabará en disco los cambios pendientes.
    Si el usuario intenta salir de la gestión y hay registros pendientes de grabar en disco deberá mostrar un mensaje indicando la incidencia y preguntando si se desea grabar o no.

 Hay que tener presente algunas restricciones sobre los campos de la tabla Clientes:

    CÓDIGO: Clave primaria cadena.
    NOMBRE: Campo obligatorio.
    CP: Clave foránea en la tabla CIUDAD, si se informa su valor (el campo es opcional) deberá validar que sea una clave foránea correcto, en caso negativo mostrar un mensaje de error obligando a rectificar, tener en cuenta que este campo no es obligatorio.
    TELEFONO: Cadena no obligatoria
    CATEGORÍA: Número no obligatorio.
    EMAIL: Si este campo se informa se deberá comprobar que tenga un formato de email, es decir, que tenga el símbolo de '@' y que después de este símbolo haya al menos un símbolo de punto ' . '
    RISCMAXIM: Valor numérico obligatorio. Es necesario que se su valor sea 0 o mayor.

También deberá existir un botón para grabar los cambios que el usuario haga sobre cualquier registro, no persistencia.

Para facilitar la gestión al usuario, y que éste no tenga que acordarse de todas los códigos postales de memoria, existirá un botoncito junto al código postal que automáticamente abrirá otro formulario donde dentro habrá un ListBox donde se mostrarán todos los códigos postales / nombre población, ordenados por código postal o por población, según el usuario lo estriado. Además existirá un textbox que a medida que se escriba el ListBox se irá filtrando por el nombre de la población, mostrando así sólo las poblaciones que coincidan con el filtro.

Finalmente si el usuario estría el botón ELEGIR el codipostal que esté seleccionado en el ListBox pasará al textbox de la gestión principal donde se muestra el código postal cerrando automáticamente el formulario de búsqueda. También existirá un botón de CERRAR para cuando el usuario no quiera estriar ningún código postal.
