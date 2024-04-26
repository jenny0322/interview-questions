package solution

// LongestCommonPrefix finds the longest common prefix string amongst an array of strings.
func LongestCommonPrefix(strs []string) string {
    if len(strs) == 0 {
        return ""
    }

    // Start with the first string in the array as the initial prefix.
    prefix := strs[0]

    // Compare the prefix with each string in the array.
    for _, s := range strs {
        // Adjust the prefix until it matches the beginning of each string.
        for len(s) < len(prefix) || s[:len(prefix)] != prefix {
            if len(prefix) == 0 {
                return "" // Early return if no common prefix
            }
            prefix = prefix[:len(prefix)-1]
        }
    }
    return prefix
}
