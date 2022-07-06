def valid_parentheses(string):
    s = 0;
    for i in string:
        if i == '(': s += 1;
        elif i == ')': s -= 1;
        if s < 0: return False
    if s == 0: return True
    else: return False

#для локального запуска
string = '(())((()())())'

print(valid_parentheses(string))
input()
