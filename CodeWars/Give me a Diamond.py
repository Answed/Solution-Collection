import numpy as np

def diamond(n):
    if(n <= 0 or n % 2 == 0):
        return None
    diamond_s =""
    for i in range(1, n+1, 2):
        diamond_s +="{}{}\n".format(np.char.multiply(' ', int((n-i) /2)),np.char.multiply('*', i))
    for i in range(n-2, 0, -2):
        diamond_s +="{}{}\n".format(np.char.multiply(' ', int((n-i) /2)),np.char.multiply('*', i))
    return diamond_s

print(diamond(7))