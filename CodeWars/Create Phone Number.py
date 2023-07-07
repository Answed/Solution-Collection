#First Solution
def create_phone_number(n):
    first_part = create_number_string(n, 0, 3)
    second_part = create_number_string(n, 3, 6)
    third_part = create_number_string(n, 6, 10)
    return "({}) {}-{}".format(first_part, second_part, third_part)

def create_number_string(list, start, end):
    number_string = ""
    for i in range(start, end):
        number_string += str(list[i])
    return number_string

def create_phone_number2(n):
    str1 = "".join(str(x) for x in n[0:3])
    str2 = "".join(str(x) for x in n[3:6])
    str3 = "".join(str(x) for x in n[6:10])

    return "({}) {}-{}".format(str1, str2, str3)

def create_phone_number3(n):
    return "({}{}{}) {}{}{}-{}{}{}{}".format(*n)
