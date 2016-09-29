package leap

const testVersion = 2

func IsLeapYear(year int) bool {
	return (isDivisibleBy(year, 4) && !isDivisibleBy(year, 100)) || isDivisibleBy(year, 400)
}

func isDivisibleBy(value, divisor int) bool {
	return value%divisor == 0
}
