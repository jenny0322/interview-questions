package solution

// MaxArea calculates the maximum area of water that can be trapped between the lines.
func MaxArea(height []int) int {
    maxArea, left, right := 0, 0, len(height)-1
    for left < right {
        // Calculate the width
        width := right - left
        // Calculate the height using the smaller of the two heights
        minHeight := height[left]
        if height[left] < height[right] {
            left++
        } else {
            minHeight = height[right]
            right--
        }
        // Calculate the current area and update maxArea if it's larger
        currentArea := width * minHeight
        if currentArea > maxArea {
            maxArea = currentArea
        }
    }
    return maxArea
}
