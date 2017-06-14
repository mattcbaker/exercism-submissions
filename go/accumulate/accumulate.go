package accumulate

const testVersion = 1

func Accumulate(source []string, transform func(string) string) []string {
	transformed := make([]string, len(source))

	for i := 0; i < len(source); i++ {
		transformed[i] = transform(source[i])
	}

	return transformed
}
