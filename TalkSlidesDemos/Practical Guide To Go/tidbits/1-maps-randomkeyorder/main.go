package main

import "fmt"

// Maps Have Random Key Order
// - The iteration order for the key value pairs of a map is not guaranteed in Go
//   and is intentionally randomized to help drive that point home. You likely won't
//   purposefully code against the iteration order in normal development, but it's
//   easy to overlook in tests. Remember to write tests to assert in no specific order
//   when maps are involved.
//
//   Run this code multiple times to see the iteration order is not always the same.

func main() {
	m := map[string]string{
		"1": "a",
		"2": "b",
		"3": "c",
	}
	for k, v := range m {
		fmt.Printf("key: %s, value %s\n", k, v)
	}
}
