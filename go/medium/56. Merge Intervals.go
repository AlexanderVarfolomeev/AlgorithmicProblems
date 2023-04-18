/*Given an array of intervals where intervals[i] = [starti, endi], merge all overlapping intervals,
and return an array of the non-overlapping intervals that cover all the intervals in the input.
*/

package main

import "sort"

func merge(intervals [][]int) [][]int {
	sort.Slice(intervals, func(i, j int) bool {
		return intervals[i][0] < intervals[j][0]
	})
	res := make([][]int, 0)
	j := -1
	for i := 0; i < len(intervals); i++ {
		if len(res) != 0 {
			if res[j][0] <= intervals[i][0] && res[j][1] >= intervals[i][1] {
				continue
			}
			if res[j][1] >= intervals[i][0] {
				res[j][1] = intervals[i][1]
				continue
			}
		}

		if len(intervals) != i+1 && intervals[i][0] <= intervals[i+1][0] && intervals[i][1] >= intervals[i+1][1] {
			res = append(res, intervals[i])
		} else if len(intervals) != i+1 && intervals[i][1] >= intervals[i+1][0] {
			res = append(res, []int{intervals[i][0], intervals[i+1][1]})
		} else {
			res = append(res, intervals[i])
		}

		j++

	}
	return res
}

func main() {
	merge([][]int{{1, 3}, {8, 16}, {8, 10}, {15, 18}})
	//merge([][]int{{1, 4}, {2, 3}})
}
