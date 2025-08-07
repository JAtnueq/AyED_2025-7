# ##############################################################################
# #   PROGRAMA DE GESTIÓN DE PRÉSTAMOS - EJEMPLO ABM BÁSICO EN PYTHON        #
# #   Este programa simula la gestión de préstamos, permitiendo registrar,   #
# #   modificar (saldos) y consultar información almacenada en un archivo   #
# #   de texto, similar a un procedimiento manual.                           #
# ##############################################################################

import os    # Importa el módulo 'os' (Operating System).
             # Este módulo nos permite interactuar con el sistema operativo,
             # por ejemplo, para ejecutar comandos como "limpiar la pantalla".
from colorama import init # Importa la función 'init' de la librería Colorama.
                          # Colorama es una librería de Python que facilita
                          # el uso de colores y el posicionamiento del cursor
                          # en la consola (terminal) de manera que funcione
                          # correctamente en Windows.

# ##############################################################################
# #   INICIALIZACIÓN DE LIBRERÍAS                                            #
# ##############################################################################

# La función 'init()' de Colorama prepara la consola.
# Es esencial llamarla al inicio del programa para que las secuencias de escape
# ANSI (que controlan el posicionamiento del cursor) sean interpretadas correctamente.
init()

# ##############################################################################
# #   FUNCIONES AUXILIARES PARA EL MANEJO DE PANTALLA                        #
# ##############################################################################

# Función: POS(x, y)
# Propósito: Posicionar el cursor en un punto específico de la consola.
# 'x' representa la columna (posición horizontal), e 'y' la fila (posición vertical).
def POS(x, y):
    # Retorna una "cadena de escape ANSI". Las consolas modernas de Windows interpretan
    # estas cadenas para realizar acciones especiales, como mover el cursor.
    # Por ejemplo, "\033[5;10H" movería el cursor a la fila 5, columna 10.
    return "\033[" + str(y) + ";" + str(x) + "H"

# Función: limpiar_pantalla()
# Propósito: Borra todo el contenido visible de la consola.
def limpiar_pantalla():
    # 'os.system("cls")' ejecuta el comando "cls" (clear screen) en el sistema operativo Windows.
    # Este comando borra todo el texto mostrado en la ventana de la terminal.
    os.system("cls")

# Función: encabezado_pantalla(titulo)
# Propósito: Muestra un encabezado consistente en la parte superior de cada pantalla.
# 'titulo' es el texto específico de la pantalla actual (ej. "MENÚ PRINCIPAL").
def encabezado_pantalla(titulo):
    limpiar_pantalla() # Primero, se limpia la pantalla para una presentación ordenada.
    
    # Imprime el título principal del sistema, ajustando su posición para centrarlo.
    print(POS(35, 3) + "REGISTRO DE ASISTENCIAS ESCOLARES")
    print(POS(35, 4) + "-----------------------------")
    
    # Imprime el título específico de la pantalla actual, también centrado.
    print(POS(35, 6) + titulo)
    # Se crea una línea de guiones del mismo largo que el título para subrayarlo.
    print(POS(35, 7) + "-" * len(titulo))

# ##############################################################################
# #   FUNCIONES PRINCIPALES DEL SISTEMA ABM DE PRÉSTAMOS                       #
# ##############################################################################

def datos_alumno():
    # ##########################################################################
    # # Función: REGISTRAR NUEVOS ALUMNOS (ALUMNO)                             #
    # # Descripción: Permite ingresar el apellido y la asistencia de un nuevo  # 
    # # alumno. Este proceso corresponde a 'Ingresar datos de un nuevo alumno' #
    # # en un procedimiento manual (ej. anotar un nuevo registro en una        #
    # # planilla).                                                             #
    # ##########################################################################

    encabezado_pantalla("1. REGISTRAR NUEVOS ALUMNOS ( ALUMNO )")
    print(POS(42, 9) + "Ingrese los datos del nuevo alumno:")
    
    # Se solicita **solamente el apellido** del cliente.
    # 'input()' pausa el programa y espera que el usuario escriba y presione Enter.
    # El argumento 'end=""' en la función 'print()' es crucial aquí:
    # Normalmente, 'print()' añade un salto de línea al final de lo que imprime.
    # Al usar 'end=""', le indicamos a 'print()' que NO añada ese salto de línea.
    # Esto hace que la entrada del usuario (lo que se escribe con 'input()')
    # aparezca justo después del texto "Apellido del Cliente: " en la misma línea.
    print(POS(42, 11) + "Apellido del Alumno: ", end="")
    apellido_alumno = input() 
    
    # Se pide el monto inicial del préstamo.
    print(POS(42, 12) + "Presente: ", end="")
    asistencia = input() 
    
    # El saldo actual al registrar es igual al monto del préstamo.
    asistencia_actual = asistencia 
    # Al inicio, no hay cuotas pagadas.
    cuotas_pagadas = "0" 
    
    # # Manejo de Archivo: Apertura y Escritura #
    # 'open("prestamos.txt", 'a')' abre el archivo 'prestamos.txt'.
    # El modo 'a' (append) significa "agregar". Si el archivo existe, el nuevo contenido
    # se añade al final. Si no existe, el archivo es creado.
    # Se asume que esta operación de archivo siempre es exitosa.
    # NOTA: Al no especificar una ruta completa, Python buscará o creará
    # el archivo en el mismo directorio donde se ejecute el script 'prestamos.py'.
    archivo = open("prestamos.txt", 'a')
    
    # 'archivo.write()' escribe la cadena de texto en el archivo.
    # Los datos se unen (concatenan) usando el operador '+' y el caracter '|' como separador.
    # El '\n' al final agrega un salto de línea, asegurando que cada préstamo esté en una línea distinta.
    archivo.write(apellido_alumno + "|" + asistencia + "|" + asistencia_actual + "|" + cuotas_pagadas + "\n")
    archivo.close() # 'archivo.close()' es crucial. Guarda los cambios pendientes y libera el archivo.

    print(POS(42, 14) + "Préstamo registrado con éxito.")
    input(POS(42, 16) + "Presione ENTER para continuar...")

def modificar_alumno():
    # ##########################################################################
    # # Función: ACTUALIZAR SALDO DE PRÉSTAMO (Modificaciones)                 #
    # # Descripción: Permite cambiar el saldo de un préstamo existente,       #
    # # simulando el pago de una cuota.                                       #
    # # Corresponde a 'Datos Calculados' en un procedimiento manual (ej.      #
    # # recalcular un saldo después de una operación).                        #
    # ##########################################################################

    encabezado_pantalla("2. MODIFICACIONES (Datos Calculados: Actualizar Saldo)")
    print(POS(42, 9) + "Ingrese el Apellido del Cliente para actualizar su saldo: ", end="")
    
    # Se pide el apellido para buscar.
    # '.strip()': Elimina espacios en blanco (ej. espacios, tabulaciones, saltos de línea)
    #             que puedan estar al inicio o al final de la cadena ingresada por el usuario.
    # '.lower()': Convierte toda la cadena a letras minúsculas. Esto hace que
    #             la búsqueda no distinga entre mayúsculas y minúsculas (ej. "Gatti" y "gatti" son iguales).
    apellido_buscar = input().strip().lower() 
    
    lineas_en_memoria = [] # Lista temporal para guardar todas las líneas del archivo.
                          # Las líneas que se modifiquen se actualizarán aquí, las otras no.
    encontrado = False # Bandera (variable booleana) para indicar si el cliente fue encontrado.

    # # Manejo de Archivo: Lectura y Reescribir #
    # Abre el archivo en modo lectura ('r').
    archivo = open("prestamos.txt", 'r')
    # 'readlines()' lee **todas** las líneas del archivo de texto y las devuelve como una lista de cadenas.
    # Cada elemento de la lista es una línea del archivo, incluyendo el salto de línea al final ('\n').
    lineas = archivo.readlines() 
    archivo.close() # Cierra el archivo inmediatamente después de leer para liberar los recursos.

    # Iteramos (recorremos) cada línea que hemos leído del archivo.
    for linea in lineas:
        # '.split('|')': Divide la cadena 'linea' en una lista de subcadenas (elementos),
        # usando el caracter '|' como delimitador. Por ejemplo, la línea "Gatti|1000|1000|0\n"
        # se convierte en la lista ['Gatti', '1000', '1000', '0\n'].
        linea_split = linea.strip().split('|') 
        
        # Verificamos que la línea tenga el formato esperado (4 campos de datos).
        if len(linea_split) == 4:
            apellido_archivo = linea_split[0]
            # 'float()': Convierte una cadena de texto a un número con decimales (flotante).
            # Es necesario para poder realizar operaciones matemáticas con el monto y saldo.
            asistencia = float(linea_split[1]) 
            asistencia_actual = float(linea_split[2])
            # 'int()': Convierte una cadena de texto a un número entero.
            cuotas_pagadas = int(linea_split[3])

            # Comparamos el apellido buscado (en minúsculas) con el apellido del archivo (también en minúsculas).
            if apellido_buscar == apellido_archivo.lower():
                encontrado = True # Marcamos la bandera 'encontrado' como Verdadera.
                print(POS(42, 11) + "Préstamo encontrado para: " + apellido_archivo)
                print(POS(42, 12) + "Saldo actual: " + str(asistencia_actual) + " (Formato original)")
                
                print(POS(42, 14) + "Ingrese el monto de la cuota a pagar: ", end="")
                monto_cuota = float(input()) 

                nuevo_saldo = asistencia_actual - monto_cuota # Realiza el cálculo del nuevo saldo.
                cuotas_pagadas = cuotas_pagadas + 1 # Incrementa el contador de cuotas pagadas.
                
                print(POS(42, 16) + "Saldo actualizado. Nuevo saldo: " + str(nuevo_saldo) + " (Formato original)")
                
                # Reconstruimos la línea con los datos actualizados, usando el operador '+' para concatenar.
                # Es importante convertir los números de nuevo a cadenas con 'str()' antes de concatenar.
                linea_modificada = apellido_archivo + "|" + str(asistencia) + "|" + str(nuevo_saldo) + "|" + str(cuotas_pagadas) + "\n"
                lineas_en_memoria.append(linea_modificada) # Agregamos la línea modificada a nuestra lista temporal.
            else:
                # Si la línea no corresponde al cliente buscado, se añade tal cual a la lista.
                lineas_en_memoria.append(linea)
        else:
            # Si una línea tiene un formato incorrecto (ej. no tiene 4 campos), la mantenemos sin cambios.
            lineas_en_memoria.append(linea)
    
    # # Manejo de Archivo: Escritura para Reescribir #
    # Abrimos el archivo en modo escritura ('w').
    # El modo 'w' (write) BORRA todo el contenido existente del archivo
    # antes de empezar a escribir. Por eso, el procedimiento es:
    # 1. Leer todo el contenido del archivo.
    # 2. Realizar las modificaciones necesarias en la lista en memoria (lineas_en_memoria).
    # 3. Reescribir todo el contenido de la lista 'lineas_en_memoria' en el archivo.
    archivo = open("prestamos.txt", 'w')
    # 'writelines()' escribe todas las cadenas de la lista 'lineas_en_memoria' en el archivo.
    # Cada cadena en la lista ya debe contener su propio salto de línea ('\n') si lo necesita.
    archivo.writelines(lineas_en_memoria) 
    archivo.close() # Cierra el archivo para guardar los cambios.

    if not encontrado: # Si la bandera 'encontrado' sigue siendo Falsa al final del bucle.
        print(POS(42, 11) + "Cliente no encontrado. Verifique el apellido.")
    
    input(POS(42, 18) + "Presione ENTER para continuar...")

def registro_alumno():
    # ##########################################################################
    # # Función: MUESTRA TODAS LAS ASISTENCIAS DE UN ALUMNO (Consulta Datos)  # 
    # # Descripción: Muestra en pantalla un listado de todas las asistecias   #
    # # de un alumno registrados en el archivo de texto.                      #
    # ##########################################################################

    encabezado_pantalla("4. CONSULTAR TODOS LOS PRÉSTAMOS (Consulta Datos)")
    
    # Imprime un encabezado para la tabla que se mostrará en pantalla.
    print(POS(42, 9) + "Apellido             | Monto Préstamo | Saldo Actual | Cuotas Pagadas")
    print(POS(42, 10) + "---------------------------------------------------------------")
    
    nro_linea_pantalla = 11 # Controla la fila de la pantalla donde se imprimirá cada préstamo.
    hay_prestamos_registrados = False # Bandera para verificar si el archivo contiene datos.

    # # Manejo de Archivo: Lectura #
    # Abre el archivo 'prestamos.txt' en modo lectura ('r').
    archivo = open("prestamos.txt", 'r')
    linea = archivo.readline() # 'readline()' lee la primera línea del archivo.
    
    # Bucle 'while' para recorrer el archivo línea por línea.
    # El bucle continúa mientras 'linea' no esté vacía (una cadena vacía '' significa fin del archivo).
    while linea != '':
        hay_prestamos_registrados = True # Si se entra al bucle, hay al menos un préstamo.
        linea_split = linea.strip().split('|') # Limpia espacios y divide la línea.
        
        if len(linea_split) == 4: # Verifica que la línea tenga 4 campos de datos.
            apellido, monto, saldo, cuotas = linea_split
            # Imprime los datos del préstamo en pantalla, con un formato tabular.
            # Se usa el operador '+' para concatenar las diferentes partes de la cadena.
            # Los números en el formato (ej. :<20) no son de Python, sino una indicación de diseño para el usuario,
            # en Python se usarían métodos como rjust/ljust o f-strings para un formateo estricto.
            # Aquí, para simplicidad y coherencia con el pedido de no usar f-strings, se imprimen directamente con un espacio.
            print(POS(42, nro_linea_pantalla) + apellido + " | " + monto + " | " + saldo + " | " + cuotas)
            nro_linea_pantalla = nro_linea_pantalla + 1 # Avanza a la siguiente fila para el próximo préstamo.
        else:
            # Si una línea está mal formateada, se informa al usuario.
            print(POS(42, nro_linea_pantalla) + "ERROR: Formato incorrecto en una línea del archivo: " + linea.strip())
            nro_linea_pantalla = nro_linea_pantalla + 1
        
        linea = archivo.readline() # Lee la siguiente línea del archivo.

    archivo.close() # Cierra el archivo después de terminar de leer.

    if not hay_prestamos_registrados: # Si la bandera es Falsa, el archivo estaba vacío.
        print(POS(42, 11) + "No hay préstamos registrados aún.")

    input(POS(42, nro_linea_pantalla + 2) + "Presione ENTER para continuar...")

def consultar_prestamo_individual():
    # ##########################################################################
    # # Función: CONSULTAR PRÉSTAMO INDIVIDUAL POR APELLIDO (Consulta Datos)   #
    # # Descripción: Busca y muestra los detalles de un único préstamo        #
    # # basado en el apellido del cliente. Es una 'Consulta Datos' más        #
    # # específica.                                                           #
    # ##########################################################################

    encabezado_pantalla("5. CONSULTAR PRÉSTAMO INDIVIDUAL POR APELLIDO (Consulta Datos)")
    print(POS(42, 9) + "Ingrese el Apellido del Cliente a consultar: ", end="")
    
    # Se pide el apellido para buscar, limpiando espacios y convirtiendo a minúsculas.
    apellido_buscar = input().strip().lower() 

    encontrado = False # Bandera para saber si se encontró el préstamo.
    nro_linea_pantalla = 12 # Fila de inicio en pantalla para mostrar la información.

    # # Manejo de Archivo: Lectura #
    # Abre el archivo 'prestamos.txt' en modo lectura ('r').
    archivo = open("prestamos.txt", 'r')
    linea = archivo.readline() # Lee la primera línea.

    # Recorre el archivo línea por línea.
    while linea != '':
        linea_split = linea.strip().split('|') # Divide la línea por el separador '|'.
        if len(linea_split) == 4: # Verifica el formato de la línea.
            apellido_archivo = linea_split[0]
            asistencia = linea_split[1]
            asistencia_actual = linea_split[2]
            cuotas_pagadas = linea_split[3]

            # Compara el apellido buscado (en minúsculas) con el apellido del archivo (también en minúsculas).
            if apellido_buscar == apellido_archivo.lower():
                encontrado = True # Marcamos que se encontró.
                print(POS(42, nro_linea_pantalla) + "--- PRÉSTAMO ENCONTRADO ---")
                print(POS(42, nro_linea_pantalla + 1) + "Apellido: " + apellido_archivo)
                print(POS(42, nro_linea_pantalla + 2) + "Monto del Préstamo: " + asistencia)
                print(POS(42, nro_linea_pantalla + 3) + "Saldo Actual: " + asistencia_actual)
                print(POS(42, nro_linea_pantalla + 4) + "Cuotas Pagadas: " + cuotas_pagadas)
                break # Una vez que se encuentra el préstamo, salimos del bucle.
            
        linea = archivo.readline() # Lee la siguiente línea.
            
    archivo.close() # Cierra el archivo.

    if not encontrado: # Si no se encontró ningún préstamo con el apellido ingresado.
        print(POS(42, 11) + "Cliente no encontrado. Verifique el apellido ingresado.")
    
    input(POS(42, nro_linea_pantalla + 6) + "Presione ENTER para continuar...")

# ##############################################################################
# #   LÓGICA PRINCIPAL DEL PROGRAMA (MENÚ)                                   #
# ##############################################################################

def menu_principal():
    # Esta función es el corazón del programa.
    # Se encarga de mostrar el menú principal y dirigir la ejecución
    # a la función correspondiente según la opción que elija el usuario.
    while True: # Un bucle 'while True' crea un ciclo infinito.
                # Esto asegura que el menú se muestre repetidamente hasta que
                # el usuario decida salir del programa explícitamente.
        encabezado_pantalla("MENÚ PRINCIPAL") # Muestra el encabezado del menú.
        
        # Muestra las opciones disponibles para el usuario, con descripciones claras.
        # Las posiciones 'x' se ajustan para un mejor centrado visual.
        print(POS(38, 9) + "1. Ingresar datos de un nuevo alumno")
        print(POS(38, 10) + "2. Modificar asistencias de X alumno")
        print(POS(38, 11) + "3. Ver registro de un alumno")
        print(POS(38, 12) + "4. Salir del programa")
        
        # Pide al usuario que ingrese una opción. 'end=""' evita un salto de línea.
        print(POS(38, 16) + "Ingrese su opción: ", end="") 
        opcion = input() # Captura la entrada del usuario como una cadena de texto.

        # Estructura de control 'if-elif-else' para evaluar la opción.
        # Ejecuta la función asociada a la opción elegida.
        if opcion == '1':
            datos_alumno() # Llama a la función para registrar nuevos alumno.
        elif opcion == '2':
            modificar_alumno() # Llama a la función para modificar la asistencia de un alumno.
        elif opcion == '3':
            registro_alumno() # Llama a la función para consultar el registro de faltas de un alumno.
        elif opcion == '4':
            limpiar_pantalla()
            print(POS(50, 12) + "¡Gracias por usar el Sistema de Asistencia!") # Llama a la función para consultar todos los préstamos.
            input(POS(50, 14) + "Presione ENTER para salir...")
            break 
        # 'break' es una palabra clave que sale del bucle 'while True',
                  # terminando así la ejecución del programa.
        else:
            # Si la opción ingresada no es ninguna de las válidas (1 al 6).
            print(POS(38, 18) + "Opción inválida. Por favor, ingrese un número del 1 al 4.")
            input(POS(38, 19) + "Presione ENTER para continuar...")

# ##############################################################################
# #   PUNTO DE INICIO DEL PROGRAMA                                           #
# ##############################################################################

# Este bloque de código es una convención muy común en Python.
# 'if __name__ == "__main__":' asegura que el código dentro de este bloque
# solo se ejecute cuando el script es el programa principal que se inicia.
# Si este archivo fuera importado como un módulo por otro script, el código
# aquí no se ejecutaría automáticamente, lo que es útil para la reutilización.
if __name__ == "__main__":
    menu_principal() # Llama a la función 'menu_principal()' para iniciar el programa.
