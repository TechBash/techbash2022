package main

import (
	"fmt"
	"strings"

	"github.com/spf13/viper"
)

// This project represents the final state of the sample application from the
// "Practical Guide to Go" session at TechBash 2022 presented by Scott Kay.
//
// Some comments have been added to explain non-obvious parts of code.

func main() {
	c, err := loadConfig()
	if err != nil {
		fmt.Printf("Error Loading Config: %v\n", err.Error())
		return
	}

	people := []string{"scott", "alice", "bob"}
	found := findPerson(people, "BOB", c.IgnoreCase)
	fmt.Printf("Found: %v\n", found)
}

type Config struct {
	IgnoreCase bool `mapstructure:"ignore-case"`
}

func loadConfig() (Config, error) {
	v := viper.New()

	v.SetConfigName("config")
	v.SetConfigType("yaml")
	v.AddConfigPath(".")

	if err := v.ReadInConfig(); err != nil {
		// Cast the error to the "File Not Found" type from the Viper library. If that
		// error is encountered we will ignore it and return an empty config. We want the
		// config to be optional for this sample app.
		if _, ok := err.(viper.ConfigFileNotFoundError); ok {
			return Config{}, nil
		}

		// If we encountered a different type of error it's likely because the config file
		// is invalid.
		return Config{}, err
	}

	c := Config{}
	if err := v.Unmarshal(&c); err != nil {
		return Config{}, err
	}

	return c, nil
}

func findPerson(people []string, s string, ignoreCase bool) bool {
	for _, person := range people {
		if ignoreCase {
			// To compare strings in Go while ignoring case, use the EqualFold method. The "fold"
			// part of the name refers to UTF case-folding.
			if strings.EqualFold(s, person) {
				return true
			}
		} else {
			if s == person {
				return true
			}
		}
	}
	return false
}
