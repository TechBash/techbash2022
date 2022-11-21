package main

import (
	"fmt"
	"time"
)

// Use Channels For Async/Await
// - Channels in Go are a built-in way to access concurrent functionality. There are
//   many ways of using channels. This is one example similar to C#'s async/await.
// - For more comparisons of how to channels, please see:
//   https://phuctm97.com/blog/go-channel-as-async-await

func main() {
	fmt.Println("Started")

	answer := <-longTask() // Equivalent To C# `await longTask()``
	fmt.Printf("The Answer: %v\n", answer)

	fmt.Println("Stopped")
}

func longTask() <-chan int { // `<-chan int` is a return value for a read-only channel
	c := make(chan int)

	// The `go` command ahead of this anonymous function call causes the function to be
	// called in parallel to the longTask function.
	go func() {
		// always close the channel no matter what happens. roughly equivalent to a C# finally block
		defer close(c)

		// do something
		time.Sleep(5 * time.Second)

		// return result by sending to the channel
		c <- 42
	}()

	return c
}
