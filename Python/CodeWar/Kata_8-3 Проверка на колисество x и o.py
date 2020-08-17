def xo(s):
    s = s.lower()
    if s.count("x") == s.count("o"):
        return True
    else:
        return False
#для локального запуска
print("xxoo -", xo("xxoo"))
print("xoz -", xo("xoz"))
print("z -", xo("z"))
print("xxo -", xo("xxo"))
print("xooz -", xo("xooz"))
input()