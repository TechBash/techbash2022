package main

import (
	"testing"

	"github.com/stretchr/testify/assert"
)

func TestFindPerson(t *testing.T) {
	cases := []struct {
		description       string
		givenPeople       []string
		givenPersonToFind string
		givenIgnoreCase   bool
		expected          bool
	}{
		{
			description:       "None",
			givenPeople:       []string{},
			givenPersonToFind: "foo",
			givenIgnoreCase:   false,
			expected:          false,
		},
		{
			description:       "One",
			givenPeople:       []string{"foo"},
			givenPersonToFind: "foo",
			givenIgnoreCase:   false,
			expected:          true,
		},
		{
			description:       "Many",
			givenPeople:       []string{"bar", "foo"},
			givenPersonToFind: "foo",
			givenIgnoreCase:   false,
			expected:          true,
		},
		{
			description:       "Case Sensitive",
			givenPeople:       []string{"foo"},
			givenPersonToFind: "FOO",
			givenIgnoreCase:   false,
			expected:          false,
		},
		{
			description:       "Case Insensitive",
			givenPeople:       []string{"foo"},
			givenPersonToFind: "FOO",
			givenIgnoreCase:   true,
			expected:          true,
		},
	}

	for _, c := range cases {
		t.Run(c.description, func(t *testing.T) {
			actual := findPerson(c.givenPeople, c.givenPersonToFind, c.givenIgnoreCase)
			assert.Equal(t, c.expected, actual)
		})
	}
}

// Tests may be written with just a single case, although the underscore in the
// function name goes against Go naming conventions and the repetition of the test
// definition is undesirable.
//
// func TestFindPerson_One(t *testing.T) {
// 	var (
// 		givenPeople       = []string{"foo"}
// 		givenPersonToFind = "foo"
// 		givenIgnoreCase   = false
// 		expected          = true
// 	)
// 	actual := findPerson(givenPeople, givenPersonToFind, givenIgnoreCase)
// 	assert.Equal(t, expected, actual)
// }

// Tests may also be written as multiple cases, although this approach still
// has much repetition. A table driven test, like the first test in the file,
// is the recommended and most practical approach.
//
// func TestFindPerson(t *testing.T) {
// 	t.Run("None", func(t *testing.T) {
// 		var (
// 			givenPeople       = []string{}
// 			givenPersonToFind = "foo"
// 			givenIgnoreCase   = false
// 			expected          = false
// 		)
// 		actual := findPerson(givenPeople, givenPersonToFind, givenIgnoreCase)
// 		assert.Equal(t, expected, actual)
// 	})

// 	t.Run("One", func(t *testing.T) {
// 		var (
// 			givenPeople       = []string{"foo"}
// 			givenPersonToFind = "foo"
// 			givenIgnoreCase   = false
// 			expected          = true
// 		)
// 		actual := findPerson(givenPeople, givenPersonToFind, givenIgnoreCase)
// 		assert.Equal(t, expected, actual)
// 	})

// 	t.Run("Many", func(t *testing.T) {
// 		var (
// 			givenPeople       = []string{"bar", "foo"}
// 			givenPersonToFind = "foo"
// 			givenIgnoreCase   = false
// 			expected          = true
// 		)
// 		actual := findPerson(givenPeople, givenPersonToFind, givenIgnoreCase)
// 		assert.Equal(t, expected, actual)
// 	})

// 	t.Run("Case Sensitive", func(t *testing.T) {
// 		var (
// 			givenPeople       = []string{"foo"}
// 			givenPersonToFind = "FOO"
// 			givenIgnoreCase   = false
// 			expected          = false
// 		)
// 		actual := findPerson(givenPeople, givenPersonToFind, givenIgnoreCase)
// 		assert.Equal(t, expected, actual)
// 	})

// 	t.Run("Case Insensitive", func(t *testing.T) {
// 		var (
// 			givenPeople       = []string{"foo"}
// 			givenPersonToFind = "FOO"
// 			givenIgnoreCase   = true
// 			expected          = true
// 		)
// 		actual := findPerson(givenPeople, givenPersonToFind, givenIgnoreCase)
// 		assert.Equal(t, expected, actual)
// 	})
// }
