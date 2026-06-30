Given an integer n, build Floyd's Triangle and return its rows. 
Floyd's Triangle fills consecutive integers starting at 1, one row at a time, from left to right. 
Row i (counting from 1) holds exactly i numbers.

Return the triangle as a list of rows, where each row is a list of the integers placed in it.

n = 3

Row 1:  1
Row 2:  2  3
Row 3:  4  5  6

Example 1:
Input: n = 3

Output: [[1],[2,3],[4,5,6]]

Example 2:
Input: n = 5

Output: [[1],[2,3],[4,5,6],[7,8,9,10],[11,12,13,14,15]]

Constraints:
1 <= n <= 100.
The triangle holds n × (n + 1) / 2 numbers in total, and even at n = 100 the largest value fits in a 32-bit int.

public class Solution {
    public int[][] FloydsTriangle(int n) {
        
        int[][] result = new int[n][];

        int num = 1;

        for(int i = 0; i < n; i++)
        {
            result[i] = new int[i+1];

            for(int j = 0; j <= i; j++)
            {
                result[i][j] = num;
                num++;
            }
        }
        return result;
    }
}
