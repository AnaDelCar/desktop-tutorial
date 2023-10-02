from string import whitespace
import tkinter as tk
from tkinter  import messagebox

def borrarDatos():
    entry_Nombre.delete(0, tk.END)
    entry_Apellido.delete(0, tk.END)
    entry_Edad.delete(0, tk.END)
    entry_Estatura.delete(0, tk.END)
    entry_Telefono.delete(0, tk.END)
    genero.set(0)
    
def guardarDatos():
    nombre = entry_Nombre.get()
    apellido = entry_Apellido.get()
    edad = entry_Edad.get()
    estatura = entry_Estatura.get()
    telefono = entry_Telefono.get()
    
    opgenero = ""
    if genero.get() == 1:
        opgenero = "Hombre"
    elif genero.get() == 2:
        opgenero = "Mujer"
        
#CREAR UNA CADENA CON LOS DATOS
    datos = f"Nombre: {nombre}\nApellido: {apellido}\nEdad: {edad} anos\nEstatura: {estatura} cm\nTelefono: {telefono}\nGenero: {opgenero}"
    
    with open("Formu-Py.txt", "a") as archivo:
        archivo.write(datos + "\n\n")
        
    messagebox.showinfo("Informacion", "Datos guardados con exito:\n\n" + datos)
    
#VENTANA PRINCIPAL
formulario = tk.Tk()
formulario.title ( "FORMULARIO")

genero = tk.IntVar() #CREAR VARIABLES PARA LOS RADIOBUTTONS

label_Nombre = tk.Label(formulario, text = "NOMBRE: ")
label_Nombre.pack()
entry_Nombre= tk.Entry(formulario)
entry_Nombre.pack()

label_Apellido = tk.Label(formulario, text = "APELLIDO: ")
label_Apellido.pack()
entry_Apellido= tk.Entry(formulario)
entry_Apellido.pack()

label_Edad = tk.Label(formulario, text = "EDAD: ")
label_Edad.pack()
entry_Edad= tk.Entry(formulario)
entry_Edad.pack()

label_Estatura = tk.Label(formulario, text = "ESTATURA: (CM)")
label_Estatura.pack()
entry_Estatura= tk.Entry(formulario)
entry_Estatura.pack()

label_Telefono = tk.Label(formulario, text = "TELEFONO: ")
label_Telefono.pack()
entry_Telefono= tk.Entry(formulario)
entry_Telefono.pack()

label_Genero= tk.Label(formulario, text = "GENERO: ")
label_Genero.pack()

radBut_hombre= tk.Radiobutton(formulario, text = "HOMBRE",  variable = genero, value=1)
radBut_hombre.pack()

radBut_mujer= tk.Radiobutton(formulario, text = "MUJER", variable = genero, value=2)
radBut_mujer.pack()

#BOTONES PARA GUARDAR Y ELIMINAR DATOS
butGuardar = tk.Button(formulario, text = "GUARDAR", command= guardarDatos)
butGuardar.pack()

butBorrar= tk.Button(formulario, text = "BORRAR", command= borrarDatos)
butBorrar.pack()

formulario.mainloop() #INICIAR LA VENTANA
               
