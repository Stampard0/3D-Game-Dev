content = "This is a bunch of content."

content += "\nHere is some more content."

file = open("test.txt", "w") #opening the file stream in 'write' mode
file.write(content + "\nThis is a bunch of text.") #writing text to a file
file.close() #closing the file stream

file = open("test.txt", "r") #opening the file stream in 'read' mode
print(file.read())
file.close()

file = open("test.txt", "a")
file.write("\nThis is some extra stuff that has been added.")
file.close()
