/*
Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:

    Each row must contain the digits 1-9 without repetition.
    Each column must contain the digits 1-9 without repetition.
    Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.

Note:

    A Sudoku board (partially filled) could be valid but is not necessarily solvable.
    Only the filled cells need to be validated according to the mentioned rules.
*/

public class Solution
{
    public static void Main()
    {
        char[][] arr = new char[][]
        {
            new char[] { '.', '.', '.', '.', '5', '.', '.', '1', '.' },
            new char[] { '.', '4', '.', '3', '.', '.', '.', '.', '.' },
            new char[] { '.', '.', '.', '.', '.', '3', '.', '.', '1' },
            new char[] { '8', '.', '.', '.', '.', '.', '.', '2', '.' },
            new char[] { '.', '.', '2', '.', '7', '.', '.', '.', '.' },
            new char[] { '.', '1', '5', '.', '.', '.', '.', '.', '.' },
            new char[] { '.', '.', '.', '.', '.', '2', '.', '.', '.' },
            new char[] { '.', '2', '.', '9', '.', '.', '.', '.', '.' },
            new char[] { '.', '.', '4', '.', '.', '.', '.', '.', '.' }
        };
        IsValidSudoku(arr);
    }


    public static bool IsValidSudoku(char[][] board)
    {
        bool isRep = true;
        for (int i = 0; i < board.Length; i++)
        {
            if (!isRep)
                return false;
            HashSet<int> repRow = new HashSet<int>();
            HashSet<int> repCol = new HashSet<int>();

            for (int j = 0; j < board[i].Length; j++)
            {
                if (repRow.Contains(board[i][j]) && board[i][j] != '.')
                {
                    isRep = false;
                    break;
                }

                if (repCol.Contains(board[j][i]) && board[j][i] != '.')
                {
                    isRep = false;
                    break;
                }

                repRow.Add(board[i][j]);
                repCol.Add(board[j][i]);
            }
        }

        if (!isRep)
            return false;
        for (int sqRow = 0; sqRow < 3; sqRow++)
        {
            for (int sqCol = 0; sqCol < 3; sqCol++)
            {
                HashSet<char> rep = new HashSet<char>();
                for (int row = sqRow * 3; row < 9 - (6 - sqRow * 3); row++)
                {
                    for (int col = sqCol * 3; col < 9 - (6 - sqCol * 3); col++)
                    {
                        if (board[col][row] == '.')
                            continue;
                        if (rep.Contains(board[row][col]))
                            return false;
                        char a = board[col][row];
                        if (a == '.' || a == 46)
                            continue;
                        rep.Add(board[row][col]);
                    }
                }
            }
        }

        return true;
    }
}