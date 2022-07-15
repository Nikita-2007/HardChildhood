def norm(x):
	if x < 0:
		return '00'
	elif x > 255:
		return 'FF'
	elif x > 15:
		return hex(x)[2:].upper()
	else:
		return "0"+hex(x)[2:].upper()

def rgb(r, g, b):
	return norm(r)+norm(g)+norm(b)

#для локального запуска
print(rgb(16, 255, 255))
