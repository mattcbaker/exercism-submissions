package acronym

import "strings"

const testVersion = 3

func Abbreviate(raw string) string {
	split := strings.Split(strings.Replace(raw, "-", " ", -1), " ")
	result := ""

	for _, v := range split {
		result += strings.ToUpper(string(v[0]))
	}

	return result
}
