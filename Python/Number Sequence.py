Input = input()
Next = int(input())
First = int(Input.split(' ')[0])
Second = int(Input.split(' ')[1])
Current = int( Input.split(' ')[2])
print(Input, end="")
for x in range(Next):
    Current += Second - First
    print(" " + str(Current), end="")