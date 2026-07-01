Given an integer n, fill an n x n grid with the numbers 1 through n^2 placed in a clockwise spiral, starting at the top-left corner. Return the grid as a list of rows.

The spiral fills the top row left to right, then the right column top to bottom, then the bottom row right to left, then the left column bottom to top, winding inward until every cell is filled.

1 2 3
8 9 4
7 6 5


Example 1:
Input: n = 3

Output: [[1,2,3],[8,9,4],[7,6,5]]

Example 2:
Input: n = 4

Output: [[1,2,3,4],[12,13,14,5],[11,16,15,6],[10,9,8,7]]

Constraints:
1 <= n <= 50.
The grid is always square with n rows and n columns, holding n^2 numbers in total from 1 up to n^2.

public class Solution {
    public int[][] SpiralNumberPattern(int n) {

        int[][] result = new int[n][];

        for (int i = 0; i < n; i++)
            result[i] = new int[n];

        int top = 0;
        int bottom = n - 1;
        int left = 0;
        int right = n - 1;

        int num = 1;

        while (top <= bottom && left <= right)
        {
            for (int i = left; i <= right; i++)
                result[top][i] = num++;

            top++;

            for (int i = top; i <= bottom; i++)
                result[i][right] = num++;

            right--;

            if (top <= bottom)
            {
                for (int i = right; i >= left; i--)
                    result[bottom][i] = num++;

                bottom--;
            }

            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                    result[i][left] = num++;

                left++;
            }
        }

        return result;
    }
}
