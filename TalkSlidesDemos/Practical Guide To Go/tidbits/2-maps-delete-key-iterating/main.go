package main

import "fmt"

// Delete A Key While Iterating Over A Map
// - The iteration over a map in Go is implemented in such a way that the keys
//   may safely be deleted during iteration. If the key hasn't yet been iterated
//   over, it will simply be skipped.

func main() {
	m := map[string]string{
		"1": "a",
		"2": "b",
		"3": "c",
	}

	for k := range m {
		if k == "2" {
			delete(m, k)
		}
	}

	printMap(m)
}

// Go 1.18 introduces generics. I've used generics for the printMap function
// as an example.

func printMap[K comparable, V any](m map[K]V) {
	for k, v := range m {
		fmt.Printf("key: %v, value %v\n", k, v)
	}
}
