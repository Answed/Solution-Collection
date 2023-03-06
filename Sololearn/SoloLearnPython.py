# Answer to longest word from the Sololearn Python Course
# It takes an Input of Multiple words and returns the longest of them.
txt = input()

def FindLongestWord(txt):
    words = txt.split()
    temp_longest_word = words[0]
    for word in words:
        if len(word) > len(temp_longest_word):
            temp_longest_word = word
    print(temp_longest_word)

# Answer to Fibonacci from the Sololearn Python Course
num = int(input())
def fibonacci(n):
	if (n <= 1):
		return n
	else: 
		return fibonacci(n-1) + fibonacci(n-2)
#Prints the results from 0 to num
for i in range(num):
	print(fibonacci(i))
	
#Answe to Juice Maker from the Sololearn Python Course
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