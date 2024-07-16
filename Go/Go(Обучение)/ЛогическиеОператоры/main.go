package main

import "fmt"

func main() {
	a := 3
	b := 10
	if a >= 1 && b < 15 {
		fmt.Println(true)
	}
	if a > 5 || b == 10 {
		fmt.Println(true)
	}
	if b != 10 {
		fmt.Println(true)
	}
}
