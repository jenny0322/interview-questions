package solution

import "testing"

func TestLongestCommonPrefix(t *testing.T) {
    tests := []struct {
        name  string
        strs  []string
        want  string
    }{
        {"All common prefix", []string{"flower", "flow", "flight"}, "fl"},
        {"No common prefix", []string{"dog", "racecar", "car"}, ""},
        {"Mixed length strings", []string{"interspecies", "interstellar", "interstate"}, "inters"},
        {"Single character common", []string{"circle", "circuit", "cirrus"}, "cir"},
        {"One string only", []string{"alone"}, "alone"},
        {"Empty string list", []string{}, ""},
    }

    for _, tt := range tests {
        t.Run(tt.name, func(t *testing.T) {
            if got := LongestCommonPrefix(tt.strs); got != tt.want {
                t.Errorf("LongestCommonPrefix() = %v, want %v", got, tt.want)
            }
        })
    }
}
