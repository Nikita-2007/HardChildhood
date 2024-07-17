package main

import (
	"fmt"
	"math"
)

func main() {
	a := 3
	b := 5
	c := a - b                   // -2
	d := a / b                   // 0
	e := float64(a) / float64(b) // 0.6
	f := a % b                   // 3 (Остаток)
	fmt.Println(c, d, e, f)

	//Math
	var x float64 = 144
	y := math.Sqrt(x)
	fmt.Println(y)
	x = 25.345634
	fmt.Println(math.Ceil(x))  //Округление в большую сторону
	fmt.Println(math.Round(x)) //Округление
	fmt.Println(math.Floor(x)) //Округление в меньшую сторону
}
