coefiX1=[]
coefiX2=[]
coefiX3=[]

conta=0

for i in range (4):
    ec1=float(input("Ingrese coeficientes ec1: "))
    coefiX1.append(ec1)
print(((f"{coefiX1[0]}x1")),"{}{}".format("+" if coefiX1[1]>0 else "",coefiX1[1])+"x2"+"{}{}".format("+" if coefiX1[2]>0 else "",coefiX1[2])+"x3" ,"=",coefiX1[3],"\n")

for i in range (4):
    ec2=float(input("Ingrese coeficientes ec2: "))
    coefiX2.append(ec2)
print(((f"{coefiX2[0]}x1")),"{}{}".format("+" if coefiX2[1]>0 else "",coefiX2[1])+"x2"+"{}{}".format("+" if coefiX2[2]>0 else "",coefiX2[2])+"x3" ,"=",coefiX2[3],"\n")

for i in range (4):
    ec3=float(input("Ingrese coeficientes ec3: "))
    coefiX3.append(ec3)
print(((f"{coefiX3[0]}x1")),"{}{}".format("+" if coefiX3[1]>0 else "",coefiX3[1])+"x2"+"{}{}".format("+" if coefiX3[2]>0 else "",coefiX3[2])+"x3" ,"=",coefiX3[3],"\n")



x1=int(input("Vector inicial: "))
x2=int(input("Vector inicial: "))
x3=int(input("Vector inicial: "))

ex1=100
ex2=100
ex3=100

despex1=(coefiX1[3] + ((coefiX1[1]*-1) *x2)+ ((coefiX1[2]*-1) *x3))/coefiX1[0]
despex2=(coefiX2[3] + ((coefiX2[0]*-1) *x1)+ ((coefiX2[2]*-1) *x3))/coefiX2[1]
despex3=(coefiX3[3] + ((coefiX3[0]*-1) *x1)+ ((coefiX3[1]*-1) *x2))/coefiX3[2]

ex1=(abs(despex1-x1)/despex1)*100
ex2=(abs(despex2-x2)/despex2)*100
ex3=(abs(despex3-x3)/despex3)*100

while (ex1 > 5 or ex2 >  5 or ex3 > 5) :

    despex1=(coefiX1[3] + ((coefiX1[1]*-1) *x2)+ ((coefiX1[2]*-1) *x3))/coefiX1[0]
    despex2=(coefiX2[3] + ((coefiX2[0]*-1) *x1)+ ((coefiX2[2]*-1) *x3))/coefiX2[1]
    despex3=(coefiX3[3] + ((coefiX3[0]*-1) *x1)+ ((coefiX3[1]*-1) *x2))/coefiX3[2]

    ex1 = (abs(despex1-x1)/despex1)*100
    ex2 = (abs(despex2-x2)/despex2)*100
    ex3 = (abs(despex3-x3)/despex3)*100

    x1=despex1
    x2=despex2
    x3=despex3

    conta+=1
    print("Vuelta: ",conta)
    print("X1: ",despex1,"\nX2: ",despex2, "\nX3: ",despex3,"\n")
    print("Error X1: ","{:.6f}".format(ex1),"\nError X2: ","{:.6f}".format(ex2),"\nError X3: ","{:.6f}".format(ex3),"\n")

