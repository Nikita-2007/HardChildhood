class add(int):
    def __call__(self, n):
		return add(self+n)
#для локального запуска
#print(add(1)(2))
