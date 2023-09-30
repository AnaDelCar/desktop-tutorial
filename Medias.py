def calcula_media(*args):
    return sum(*args)/len(*args)
print(calcula_media([3,7,5 ]))

assert(calcula_media([3,7,5]) == 6.0, "El resultado")
assert(calcula_media([3,7,5]) == 15.0, "El resultado")