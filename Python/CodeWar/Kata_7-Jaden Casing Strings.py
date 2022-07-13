def to_jaden_case(string):
    arr = list(string.split())
    for i in range(len(arr)):
        arr[i] = arr[i].capitalize()
    string = ' '.join(arr)
    return string

#для локального запуска
print(to_jaden_case("How can mirrors be real if our eyes aren't real"))
