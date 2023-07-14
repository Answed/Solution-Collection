import math

def format_duration(seconds):
    if (seconds == 0):
        return "now"
   
    components = calculate_components(seconds)
    used_components = []
   
    for i in range(5):
        if(components[i] == 0):
            continue
        if(i == 0):
            used_components.append("{} year".format(components[i]))
        elif(i == 1):
            used_components.append("{} day".format(components[i]))
        elif(i == 2):
            used_components.append("{} hour".format(components[i]))
        elif(i == 3):
            used_components.append("{} minute".format(components[i]))
        elif(i == 4):
            used_components.append("{} second".format(components[i]))            

    components = list(filter((0).__ne__, components))

    for i in range(len(components)):
        if(components[i] > 1):
            used_components[i] += "s"

    result_string = ""
    for i in range(len(used_components)):
        if (i < len(used_components) - 2):
            result_string += "{}, ".format(used_components[i])
        elif(i + 1 == len(used_components)-1):
            result_string += "{} and ".format(used_components[i])
        else: result_string += used_components[i]
    return result_string


def calculate_components(seconds):
    components = []
    components.append(math.floor(seconds / 31536000))
    seconds -= components[0] * 31536000
    components.append(math.floor(seconds / 86400))
    seconds -= components[1] * 86400
    components.append(math.floor(seconds / 3600))
    seconds -= components[2] * 3600
    components.append(math.floor(seconds / 60))
    seconds -= components[3] * 60
    components.append(seconds)
    return components
