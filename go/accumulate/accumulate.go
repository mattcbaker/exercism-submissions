package accumulate

const testVersion = 1

func Accumulate(source []string, transform func(string) string) []string {
	transformed := make([]string, len(source))

	for i, v := range source {
		transformed[i] = transform(v)
	}

	return transformed
}
