package main

import "fmt"

func main() {
	age := 30
	name := "John"
	/*
		%d число
		%s строка
		%f число с запятой
		%t 1 или 0
		\n перенос на новую строку
		\t табуляция
	*/
	fmt.Printf("Возраст: %d \nИмя: %s", age, name)
}
