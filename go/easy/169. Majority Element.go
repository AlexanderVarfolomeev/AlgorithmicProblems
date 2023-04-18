/*
leetcode
Given an array nums of size n, return the majority element.
The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.
O(1) space!
*/
package main

import "sort"

func majorityElement(nums []int) int {
	sort.Slice(nums, func(i, j int) bool {
		return nums[i] < nums[j]
	})
	maxCount := 0
	curCount := 1
	max := nums[0]

	for i := 1; i < len(nums); i++ {
		if nums[i] == nums[i-1] {
			curCount++
		} else {
			if curCount > maxCount {
				max = nums[i-1]
				maxCount = curCount
				curCount = 1
			}
		}
	}
	if curCount > maxCount {
		max = nums[len(nums)-1]
		maxCount = curCount
		curCount = 1
	}
	return max
}

func main() {

	println(majorityElement([]int{3, 2, 3}))
}
