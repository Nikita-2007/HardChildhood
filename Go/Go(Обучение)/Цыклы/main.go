package main

import "fmt"

func main() {
	for i := 1; i < 21; i++ {
		if i == 17 {
			break
		}
		fmt.Print(i, " ")
	}

	for i, e := range []int{1, 75, 435, 147, 891} {
		fmt.Println(i, e)
	}
}
