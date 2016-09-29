package hamming

import "fmt"

const testVersion = 4

func Distance(a, b string) (int, error) {
	hamming := 0

	if len(a) != len(b) {
		return 0, fmt.Errorf("DNA strands must be same length")
	}

	for i := 0; i < len(a); i++ {
		if a[i] != b[i] {
			hamming++
		}
	}

	return hamming, nil
}
