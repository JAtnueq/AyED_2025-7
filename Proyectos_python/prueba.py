import os
from colorama import init

init()

def POS(x, y):
    return "\033[" + str(y) + ";" + str(x) + "H"

def limpiar_pantalla():
    os.system("cls")

def encabezado_pantalla(titulo):
    limpiar_pantalla()
    print(POS(35, 3) + "REGISTRO DE ASISTENCIAS ESCOLARES")
    print(POS(35, 4) + "-----------------------------")
    print(POS(35, 6) + titulo)
    print(POS(35, 7) + "-" * len(titulo))

def registrar_asistencia():
    encabezado_pantalla("1. REGISTRAR ASISTENCIA")
    print(POS(42, 9) + "¿Qué día es? escribir en formato: DD/MM/AAAA (ejemplo: 21/03/2009): ", end="")
    fecha = input().strip()
    print(POS(42, 10) + "Ingrese el apellido del alumno: ", end="")
    apellido = input().strip().lower()
    print(POS(42, 11) + "¿Presente o Ausente? (P = Presente, A = Ausente): ", end="")
    estado = input().strip().upper()

    while estado not in ['P', 'A']:
        print(POS(42, 13) + "Entrada inválida. Use solo 'P' o 'A'.", end="")
        input()
        return

    with open("asistencias.txt", 'a') as archivo:
        archivo.write(f"{fecha}|{apellido}|{estado}\n")

    print(POS(42, 14) + "Asistencia registrada con éxito.")
    input(POS(42, 16) + "Presione ENTER para continuar...")

def modificar_asistencia():
    encabezado_pantalla("2. MODIFICAR ASISTENCIA")
    print(POS(42, 9) + "Ingrese la fecha, escribir en formato: DD/MM/AAAA (ejemplo: 21/03/2009): ", end="")
    fecha = input().strip()
    print(POS(42, 10) + "Ingrese el apellido del alumno: ", end="")
    apellido = input().strip().lower()

    encontrado = False
    nuevas_lineas = []

    with open("asistencias.txt", 'r') as archivo:
        lineas = archivo.readlines()

    for linea in lineas:
        datos = linea.strip().split('|')
        if len(datos) == 3:
            fecha_archivo, apellido_archivo, estado = datos
            if fecha_archivo == fecha and apellido_archivo.lower() == apellido:
                encontrado = True
                print(POS(42, 12) + f"Registro encontrado: {fecha_archivo} | {apellido_archivo} | {estado}")
                print(POS(42, 13) + "Actualiza la asistencia del alumno (P = Presente, A = Ausente): ", end="")
                nuevo_estado = input().strip().upper()

                if nuevo_estado in ['P', 'A']:
                    nuevas_lineas.append(f"{fecha_archivo}|{apellido_archivo}|{nuevo_estado}\n")
                    print(POS(42, 14) + "Asistencia modificada.")
                else:
                    print(POS(42, 14) + "Entrada inválida. No se modificó el registro.")
                    nuevas_lineas.append(linea)
            else:
                nuevas_lineas.append(linea)
        else:
            nuevas_lineas.append(linea)

    with open("asistencias.txt", 'w') as archivo:
        archivo.writelines(nuevas_lineas)

    if not encontrado:
        print(POS(42, 12) + "Verifique la fecha y/o apellido del alumno.")

    input(POS(42, 16) + "Presione ENTER para continuar...")

def consultar_asistencia_individual():
    encabezado_pantalla("3. CONSULTAR ASISTENCIA DE UN ALUMNO")
    print(POS(42, 9) + "Ingrese el apellido del alumno: ", end="")
    apellido = input().strip().lower()

    fila = 11
    encontrado = False

    with open("asistencias.txt", 'r') as archivo:
        for linea in archivo:
            datos = linea.strip().split('|')
            if len(datos) == 3:
                fecha, apellido_archivo, estado = datos
                if apellido_archivo.lower() == apellido:
                    print(POS(42, fila) + f"{fecha} | {apellido_archivo} | {'Presente' if estado == 'P' else 'Ausente'}")
                    fila += 1
                    encontrado = True

    if not encontrado:
        print(POS(42, 11) + "No se encontraron asistencias para ese alumno.")

    input(POS(42, fila + 2) + "Presione ENTER para continuar...")

def menu_principal():
    while True:
        encabezado_pantalla("MENÚ PRINCIPAL")
        print(POS(38, 9) + "1. Registrar asistencia de un alumno")
        print(POS(38, 10) + "2. Modificar asistencia de un alumno")
        print(POS(38, 11) + "3. Consultar asistencias de un alumno")
        print(POS(38, 12) + "4. Limpiar pantalla")
        print(POS(38, 13) + "5. Salir del programa")
        print(POS(38, 16) + "Ingrese su opción: ", end="")

        opcion = input().strip()

        if opcion == '1':
            registrar_asistencia()
        elif opcion == '2':
            modificar_asistencia()
        elif opcion == '3':
            consultar_asistencia_individual()
        elif opcion == '4':
            limpiar_pantalla()
        elif opcion == '5':
            limpiar_pantalla()
            print(POS(50, 12) + "¡Gracias por usar el Sistema de Asistencia!")
            input(POS(50, 14) + "Presione ENTER para salir...")
            break
        else:
            print(POS(38, 18) + "Opción inválida. Por favor, ingrese un número del 1 al 5.")
            input(POS(38, 19) + "Presione ENTER para continuar...")

if __name__ == "__main__":
    menu_principal()
