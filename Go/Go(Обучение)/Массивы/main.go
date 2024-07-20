package main

import "fmt"

func main() {
	var arr [3]string
	arr[0] = "Bard"
	arr[1] = "Kate"
	arr[2] = "John"
	fmt.Println(arr)

	arr2 := [3]string{"Bard", "Kate", "John"}

	for i := 0; i < len(arr2); i++ {
		fmt.Println(arr[i])
	}
	var sum float64 = 0
	marks := [5]float64{3, 4, 4, 3, 5}
	for i := 0; i < len(marks); i++ {
		sum = sum + marks[i]
	}
	var res float64 = sum / float64(len(marks))
	fmt.Println(res)

	arr2d := [3][4]int{{1, 2, 3, 4}, {5, 6, 7, 8}, {9, 10, 11, 12}}
	fmt.Println(arr2d)
	fmt.Println(arr2d[1][2])
}
