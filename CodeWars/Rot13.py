import string
def rot13(message):
    new_message = ""
    for char in message:
        if(char.isalpha()):
            new_char = (find_alphabet_position(char) - 3) % 26
            if(char.isupper()):
                new_message += string.ascii_uppercase[new_char]
            else: new_message += string.ascii_lowercase[new_char]
        else: new_message += char
    return new_message

def find_alphabet_position(char):
    return string.ascii_lowercase.index(char.lower())

print(rot13("Nohrsdwud"))