import tkinter as tk

#CREACION DE FUNCIONES
def borrar():
    entry1.delete(0,tk.END)
    entry1.insert(0, "0.0")
    entry2.delete(0,tk.END)
    entry2.insert(0, "0.0")

def convertir_Celsius():
    fahrenheit = float(entry1.get())
    celsius = (fahrenheit - 32)*5.0/9.0
    entry2.delete(0, tk.END)
    entry2.insert(0, f"{celsius:.2f}")

def convertir_Fahrenheit():
    celsius = float(entry2.get())
    fahrenheit = (celsius * 9/5)+32
    entry1.delete(0, tk.END)
    entry1.insert(0, f"{fahrenheit:.2f}") 

conver = tk.Tk()
conver.title("Conversor de Temperatura")

label1= tk.Label(conver, text="Fahrenheit")
label1.grid(row=0, column=0)

entry1=tk.Entry(conver)
entry1.grid(row=0, column=1)

button1=tk.Button(conver, text="Convertir a Celsius", command=convertir_Celsius)
button1.grid(row=0,column=2)

label2=tk.Label(conver,text="Celsius") #Cuadro de texto
label2.grid(row=1, column=0)

entry2=tk.Entry(conver)
entry2.grid(row=1, column=1)

button2=tk.Button(conver,text="Convertir a Fahrenheit", command=convertir_Fahrenheit)
button2.grid(row=1,column=2)

button3=tk.Button(conver,text="Restablecer", command=borrar)
button3.grid(row=2,column=1)

conver.mainloop()