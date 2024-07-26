package main

import "fmt"

func main() {
	//var money map[string]int = map[string]int{
	money := map[string]int{
		"dollars": 1000,
		"euros":   2000,
		"apples":  3,
	}
	money["dollars"] = 5000
	delete(money, "apples")
	fmt.Println(money)
	fmt.Println(money["dollars"])

	el, status := money["euros"]
	fmt.Println(el, status)
	el, status = money["rub"]
	fmt.Println(el, status)
}
