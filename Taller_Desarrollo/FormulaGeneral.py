import math

a=int(input("a= "))
b=int(input("b= "))
c=int(input("c= "))

if ((b**2) - (4 *a*c)) >= 0:
    x1= (-b + math.sqrt((b**2)-(4*a*c))) / 2*a
    x2= (-b - math.sqrt((b**2)-(4*a*c))) / 2*a
    print("x1= ",x1,"\nx2= ",x2)
else:
    print("ERROR")


def raizPositiva(a,b,c):
    raiz= (-b + math.sqrt((b*b)-(4*a*c))) / 2*a
    return raiz

print("Inicio de la validacion")
assert(raizPositiva(1,4,4) == -2)
print("Fin de la validacion")  #ASSERT evaluar si el procedimiento va bien