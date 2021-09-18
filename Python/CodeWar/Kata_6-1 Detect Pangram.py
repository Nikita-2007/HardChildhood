import string

def is_pangram(s):
    alphabet = 'qwertyuiopasdfghjklzxcvbnm'
    for i in alphabet:
        if s.find(i) == -1:
            return False
        elif i == 'm':
            return True
    
# Для локального запуска
pangram = "qwertyuiopasdfghjklzxcvbnm"
print(is_pangram(pangram))
input()