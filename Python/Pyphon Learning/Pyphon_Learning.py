#This is a comment in Python

"""
This is
a multi line
comment
"""
'''
var_a = 2
var_b = 3.5
var_c = "string"

def sum(a, b):
    return a + b

print("int - " + str(var_a))
print("float - " + str(float(var_a)))

print("float - " + str(var_b))
print("float - " + str(int(var_b)))
'''
"""
animals = ["fish", "bird", "bear", "dog", "cat", "unicorn", "dragon"]
for x in range(len(animals)):
    if(animals[x] + "unicorn" or animals[x] == "dragon"):
        print(animals[x] + " does not exist.")
    else:
        print(animals[x] + " is a real animal.")
"""
"""
q = False
while(q == False):
    print("Program is running")
    user_input("Would you like to quit?")
    if(user_input == 'Y'):
        q = True
"""

collection = ["a", "b", "c", "d", "e", "f", "g"]
def linear_search(search_term):
    for x in collection: #for every element in 'collection' array
        if(x == str(search_term)): #compare element value to search parameter
            return True #return True because term has been found
        return False #if the for loop ends , return False

print (linear_search("f"))
