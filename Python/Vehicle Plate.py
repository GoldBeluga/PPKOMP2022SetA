Input = input()
Sum = 0

for x in Input:
    if x.isdigit():
        Sum += int(x)

print(Sum)