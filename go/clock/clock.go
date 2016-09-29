package clock

import "fmt"

const testVersion = 3

type Clock int

func New(hour, minute int) Clock {
	var totalMinutes = hour%24*60 + minute

	totalMinutes = normalizeMinutes(totalMinutes)

	return Clock(totalMinutes)
}

func (c Clock) String() string {
	var hours = c / 60
	var minutes = c % 60
	return fmt.Sprintf("%02d:%02d", hours, minutes)
}

func (c Clock) Add(minutes int) Clock {
	var sum = int(c) + minutes
	return New(0, sum)
}

func normalizeMinutes(minutes int) int {
	var minutesInDay = 24 * 60

	if minutes < 0 {
		minutes = minutesInDay + minutes
	}

	if minutes > minutesInDay {
		minutes = minutes - minutesInDay
	}

	return minutes
}
