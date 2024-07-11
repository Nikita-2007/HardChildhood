package main

import "fmt"

func main() {
	var x int64
	fmt.Scan(&x)
	if x > 3 {
		fmt.Println(fmt.Sprint(x) + " > 3")
	} else if x < 3 {
		fmt.Println(fmt.Sprint(x) + " < 3")
	} else {
		fmt.Println(fmt.Sprint(x) + " = 3")
	}
}
