package main

import "fmt"

// Standard Library Handles Nil Nicely
// - Many of the built-in methods and much of the standard library implementation
//   in Go is tolerant of nil values.
// - Nil is the default value for a slice or map. I've made the assignment in these
//   examples to drive home the point and make the examples obvious. You would not
//   normally set a var initialized value to nil.

func main() {
	// Append To Nil Slice
	// - If you append to a nil slice, Go will initialize the slice and proceed with
	//   appending the item.
	var people []string = nil
	people = append(people, "scott")
	fmt.Printf("Nil Slice Append: %v\n", people)

	// Iterate Over A Nil Map
	// - For loops will gracefully do nothing if told to iterate over a nil map, slice,
	//   or array.
	var folks map[string]string = nil
	fmt.Println("Folks:")
	for k, v := range folks {
		fmt.Printf("- key: %s, value %s\n", k, v)
	}

	// Length Of Nil Slice
	// - Asking for the length of a nil map, slice, or array will nicely return 0.
	var members []string = nil
	fmt.Printf("Members: %v\n", len(members))

	// These are just some examples. Check the behavior of the method you're using
	// before adding nil check protection, as it may be unnecessary.
}
