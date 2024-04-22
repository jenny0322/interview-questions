package solution

import "testing"

func TestIsValid(t *testing.T) {
    tests := []struct {
        input    string
        expected bool
    }{
        {"()", true},
        {"()[]{}", true},
        {"(]", false},
        {"([)]", false},
        {"{[]}", true},
        {"", true}, // Empty string should also return true
    }

    for _, test := range tests {
        if result := IsValid(test.input); result != test.expected {
            t.Errorf("IsValid(%q) = %v; expected %v", test.input, result, test.expected)
        }
    }
}

