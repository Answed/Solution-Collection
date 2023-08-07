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

# Answer to Phone Number Validator from the Sololearn Phyton Core Course
import re

pattern = r"^[1, 8, 9]"
if (len(txt) == 8 and re.match(pattern, txt)):
     print("Valid")
else: print("Invalid")     

# Answer to adding words from the SoloLearn Python Core Course

def concatenate(*args):
    result = args[0]
    for i in range(1, len(args)):
        result += "-{}".format(args[i])
    return result    

print(concatenate("I", "love", "Python", "!"))

# Answer to Basketball Players from the Python for Data Science Course

import numpy as np
players = np.array([180, 172, 178, 185, 190, 195, 192, 200, 210, 190])

mean = players.mean()
standard_dev = np.std(players)
# Players in range 
player_in_range = 0
for player in players:
    if (mean - standard_dev <= player <= mean + standard_dev):
        player_in_range += 1

print(player_in_range)

# Answe to House Prices from the Python for Data Science Course
data = np.array([150000, 125000, 320000, 540000, 200000, 120000, 160000, 230000, 280000, 290000, 300000, 500000, 420000, 100000, 150000, 280000])

standard_dev = np.std(data)
mean = np.mean(data)

result = data[(data > mean-standard_dev) & (data < mean + standard_dev)]

print((len(result) / len(data)) * 100)

# Annswer to COVID Data Analysis from the Python for Data Science Course
import pandas as pd

df = pd.read_csv("/usercode/files/ca-covid.csv")

df.drop('state', axis=1, inplace=True)
df.set_index('date', inplace=True)

df['ratio'] = df['deaths'] / df['cases']

print(df.loc[df['ratio'] == df['ratio'].max() ])

def count_vowels(text):
    vowels = "aeiouAEIOU"
    count = 0
    for char in text:
        if char in vowels:
            count += 1
    return count

def string_operations(input):
    for i in range(len(input)):
        print(input[i] * (i+1))

def replace_string(text, find, replace):
    print(text.count(find))
    print(text.replace(find, replace))

def letter_frequency(text, letter):
     print(int(text.count(letter)/len(text)*100))

def list_operation():
    data = [
    [23, 11, 5, 14],
    [8, 32, 20, 5]
    ]
    color = input()
    if(color == "brown"):
        print(int((data[0][0]+data[1][0]) / 118 * 100))
    elif(color == "blue"):
        print(int((data[0][1]+data[1][1]) / 118 * 100))
    elif(color =="green"):
        print(int((data[0][2]+data[1][2]) / 118 * 100))
    else: 
        print(int((data[0][3]+data[1][3]) / 118 * 100))

def above_average(list):
    average_cost = sum(list)/len(list)
    above_range = 0
    for price in list:
        if(price >= average_cost):
            above_range += 1
    print(above_range)

def list_comprehensions(n):
    result = [n*2**i for i in range(12)]