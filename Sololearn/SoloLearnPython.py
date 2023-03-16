# Answer to longest word from the Sololearn Python Core Course
# It takes an Input of Multiple words and returns the longest of them. Is also used for the solution of phone number Validator
txt = input()

def FindLongestWord(txt):
    words = txt.split()
    temp_longest_word = words[0]
    for word in words:
        if len(word) > len(temp_longest_word):
            temp_longest_word = word
    print(temp_longest_word)

# Answer to Fibonacci from the Sololearn Python Core Course
num = int(input())
def fibonacci(n):
	if (n <= 1):
		return n
	else: 
		return fibonacci(n-1) + fibonacci(n-2)
#Prints the results from 0 to num
for i in range(num):
	print(fibonacci(i))
	
#Answer to Juice Maker from the Sololearn Python Core Course
class Juice:
    def __init__(self, name, capacity):
        self.name = name
        self.capacity = capacity

    def __add__(self, other):
        self.name = self.name + "&" + other.name
        self.capacity = self.capacity + other.capacity
        return self

    def __str__(self):
        return (self.name + ' ('+str(self.capacity)+'L)')



a = Juice('Orange', 1.5)
b = Juice('Apple', 2.0)

result = a + b
print(result)

# Answe to Phone Number Validator from the Sololearn Phyton Core Course
import re

pattern = r"^[1, 8, 9]"
if (len(txt) == 8 and re.match(pattern, txt)):
     print("Valid")
else: print("Invalid")     
     