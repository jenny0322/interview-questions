package solution

import "testing"

func TestMaxArea(t *testing.T) {
    testCases := []struct {
        description string
        height      []int
        expected    int
    }{
        {"two vertical lines", []int{1, 1}, 1},
        {"mixed heights", []int{1, 8, 6, 2, 5, 4, 8, 3, 7}, 49},
        {"increasing heights", []int{4, 3, 2, 1, 4}, 16},
        {"another case", []int{1, 2, 1}, 2},
        {"large array of heights", []int{2, 3, 10, 5, 7, 8, 9}, 36},
    }

    for _, tc := range testCases {
        t.Run(tc.description, func(t *testing.T) {
            result := MaxArea(tc.height)
            if result != tc.expected {
                t.Errorf("Failed %s: expected %d, got %d", tc.description, tc.expected, result)
            }
        })
    }
}
