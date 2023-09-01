import datetime

line1 = input()
time_parts = line1.split(':')
date = datetime.datetime(2023, 12, 12, int(time_parts[0]), int(time_parts[1]), 0)
minutes = int(input())
date = date + datetime.timedelta(minutes=minutes)
formatted_time = date.strftime("%H:%M")
print(formatted_time)