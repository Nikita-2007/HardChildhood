def likes(names):
    if len(names) == 0:
        return "no one likes this"
    if len(names) == 1:
        return names[0] + " likes this"
    if len(names) == 2:
        return names[0] + " and "+ names[1] +" like this"
    if len(names) == 3:
        return names[0] + ", " + names[1] + " and " + names[2] + " like this"
    if len(names) > 3:
        return names[0] + ", " + names[1] + " and " + str(len(names)-2) + " others like this"

# Для локального запуска
print(likes(["Bob", "Garry", "Jeck", "Oscar", "Daniel"]))
input()