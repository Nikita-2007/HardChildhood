def cakes(recipe, available):
    s = 1000;
    for ing in recipe:
        if ing in available:
            s = min(s, available[ing] // recipe[ing])
        else:
            s = 0
            break
    return s

#для локального запуска
recipe = {"apples": 3, "flour": 300, "sugar": 150, "milk": 100, "oil": 100}
available = {"sugar": 500, "flour": 2000, "milk": 2000}

print(cakes(recipe, available))
input()
