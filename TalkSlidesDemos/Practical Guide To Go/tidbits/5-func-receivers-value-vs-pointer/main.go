package main

import "fmt"

// Values vs Pointers For Function Receivers
// - Be default, you should always use value receivers. Go hsa optimizations
//   to make these calls efficient. Only use pointer receivers if you need to
//   change the value of a field or work with a concurrency primitive like a mutex.

func main() {
	c := Config{ComparisonType: "anything else"}
	fmt.Println("Comparison Type: " + c.GetComparisonTypeOrDefault())
}

const DefaultComparisonType = "case-sensitive"

type Config struct {
	ComparisonType string
}

// This is a value function receiver. Change the signature to:
//
//	func (c *Config) GetComparisonTypeOrDefault() string {
//
// to change it to a pointer receiver.
func (c Config) GetComparisonTypeOrDefault() string {
	if c.ComparisonType == "" {
		return DefaultComparisonType
	}

	return c.ComparisonType
}
