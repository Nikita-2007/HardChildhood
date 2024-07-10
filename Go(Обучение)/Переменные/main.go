package main

import "fmt"

func main() {
	var age int8 = 23
	var n float64 = 275.727
	x := 16
	fmt.Println(age, n, x)
	name := "Nikita"
	fmt.Println(name, len(name))
	name2 := ""
	fmt.Println("Твое имя?")
	fmt.Scan(&name2)
	fmt.Println("Hello " + name2 + "!")
	fmt.Println("old: " + fmt.Sprint(age))
	var a int64 = int64(age)
	fmt.Println(a)
}
