// Given a positive integer n, generate an n x n matrix filled with elements from 1 to n2 in spiral order.
package main

func generateMatrix(n int) [][]int {
	m := make([][]int, n)
	for i := 0; i < n; i++ {
		m[i] = make([]int, n)
	}
	c := 1
	i, j := 0, 0
	for c != n*n {
		for j+1 != n && m[i][j+1] == 0 && c != n*n {
			m[i][j] = c
			c++
			j++
		}
		for i+1 != n && m[i+1][j] == 0 && c != n*n {
			m[i][j] = c
			c++
			i++
		}
		for j-1 != -1 && m[i][j-1] == 0 && c != n*n {
			m[i][j] = c
			c++
			j--
		}
		for i-1 != -1 && m[i-1][j] == 0 && c != n*n {
			m[i][j] = c
			c++
			i--
		}
	}
	m[i][j] = c
	return m
}

func main() {
	generateMatrix(4)
}
