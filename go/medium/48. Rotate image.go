/*
You are given an n x n 2D matrix representing an image, rotate the image by 90 degrees (clockwise).

You have to rotate the image in-place, which means you have to modify the input 2D matrix directly.
DO NOT allocate another 2D matrix and do the rotation.
*/
package main

func rotate(matrix [][]int) {
	l := len(matrix)
	for i := 0; i < l/2; i++ {
		for j := 0; j < l; j++ {
			matrix[i][j], matrix[l-1-i][j] = matrix[l-1-i][j], matrix[i][j]
		}
		print()
	}

	for i := 0; i < l; i++ {
		for j := i + 1; j < l; j++ {
			matrix[i][j], matrix[j][i] = matrix[j][i], matrix[i][j]
		}
	}
}

func main() {
	//rotate([][]int{{1, 2, 3}, {4, 5, 6}, {7, 8, 9}})
	rotate([][]int{{5, 1, 9, 11}, {2, 4, 8, 10}, {13, 3, 6, 7}, {15, 14, 12, 16}})
}
