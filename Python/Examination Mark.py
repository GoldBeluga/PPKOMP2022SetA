Marks = {
    0: 0,
    1: 0,
    2: 0,
    3: 0,
}
for x in range(4):
    Input = input()
    Molecular = float(Input.split('/')[0])
    Denominator = float(Input.split('/')[1])
    Marks[str(x)] = Molecular / Denominator

TopMarks = max(Marks.values())
for key, value in Marks.items():
        if value == TopMarks:
             SubjectCode = int(key)

if(SubjectCode == 0):
    print('Bahasa Melayu')
elif(SubjectCode == 1):
    print('Bahasa Inggeris')
elif(SubjectCode == 2):
    print('Sains')
elif(SubjectCode == 3):
    print("Matematik")