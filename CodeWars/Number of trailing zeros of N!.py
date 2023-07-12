import math

def zeros(n):
    if(n == 0):
        return 0
    number_zeros = 0
    while(n >= 5):
        n //= 5
        number_zeros += n
    return number_zeros