package solution

// TwoSum finds two indices such that their values add up to the target.
func TwoSum(nums []int, target int) []int {
    numMap := make(map[int]int) // map to store numbers and their indices

    for i, num := range nums {
        complement := target - num
        if idx, found := numMap[complement]; found {
            return []int{idx, i} // found the two indices
        }
        numMap[num] = i // store index of the current number
    }
    
    return nil // return nil if no solution is found
}
