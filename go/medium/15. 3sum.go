package main

import "sort"

type Triplet struct {
	p1 int
	p2 int
	p3 int
}

func threeSum(nums []int) [][]int {
	set := make(map[Triplet]struct{}, 0)
	sort.Slice(nums, func(i, j int) bool {
		return nums[i] < nums[j]
	})

	for i := 0; i < len(nums); i++ {
		j := i + 1
		k := len(nums) - 1
		for j < k {
			sum := nums[i] + nums[j] + nums[k]
			if sum > 0 {
				k--
			} else if sum < 0 {
				j++
			} else {
				set[Triplet{p1: nums[i], p2: nums[j], p3: nums[k]}] = struct{}{}
				j++
				k--
			}
		}
	}

	res := make([][]int, 0)
	for t, _ := range set {
		res = append(res, []int{t.p1, t.p2, t.p3})
	}
	return res
}
