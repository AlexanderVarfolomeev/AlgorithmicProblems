package main

// 2-pass, counting sort
func sortColorsCount(nums []int) {
	count := make([]int, 3)
	for _, num := range nums {
		count[num]++
	}
	for i := 0; i < len(nums); i++ {
		if count[0] != 0 {
			nums[i] = 0
			count[0]--
		} else if count[1] != 1 {
			nums[i] = 1
			count[1]--
		} else if count[2] != 2 {
			nums[i] = 2
			count[2]--
		}
	}
}

func main() {

}
