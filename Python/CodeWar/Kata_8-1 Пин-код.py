def validate_pin(pin):    
    l = len(str(pin))
    if (l ==  6 or l == 4) and pin.isdigit():
        return True
    else:
        return False

# Для локального запуска
validate_pin(1234)
input()