package main

import "fmt"

func main() {
	name := "Bard"
	switch name {
	case "Anton":
		fmt.Println("Hi! Anton")
	case "Bard":
		fmt.Println("Hi! Bard")
	case "Leon":
		fmt.Println("Hi! Leon")
	default:
		fmt.Println("Hi! unknown")
	}
	fmt.Println()
	age := 10
	switch {
	case age > 5:
		fmt.Println("> 5")
		fallthrough
	case age < 20:
		fmt.Println("< 20")
	case age > 500:
		fmt.Println("> 500")
	}
}
