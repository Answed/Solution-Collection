def duplicate_encode(word: str):
    word = list(word.upper())
    endoded_word = list(word)
    for i in range(0, len(word)-1):
        I_IsDouble = False
        for y in range(0, len(word)):
            if(word[i] == word[y] and i != y):
                endoded_word[y] = ")"
                I_IsDouble = True
        if(I_IsDouble):
            I_IsDouble = False
            endoded_word[i] = ")"
        else: endoded_word[i] = "("
    for  i in range(len(word)-1, 0, -1):
        print(i-1)
        if(word[-1] == word[i-1]):
                endoded_word[-1] = ")"
                break
    else: endoded_word[-1] = "("

    return "".join(endoded_word)

#Other Solutions

def duplicate_encoder2(word):
    word = word.upper()
    result = ""
    for char in word:
        if word.count(char) > 1:
            result += ")"
        else:
            result += "("
            
    return result

def duplicate_encoder3(word):
    return "".join(["(" if word.lower().count(c) == 1 else ")" for c in word.lower()])