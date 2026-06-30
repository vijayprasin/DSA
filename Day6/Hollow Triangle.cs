Given an integer n, build a left-aligned right triangle with n rows where only the edges are drawn with the * character. 
Return the triangle as an array of n strings, one per row.

Row i, counting from 1 to n, contains i positions indexed j from 0 to i - 1. 
A position holds a * when it is the first column (j == 0), the last column of that row (j == i - 1), or anywhere on the final row (i == n). 
Every other position holds a space. The length of each row equals its row number i.

*
**
* *
*  *
*****


Example 1:
Input: n = 5

Output: ["*","**","* *","*  *","*****"]

Example 2:
Input: n = 4

Output: ["*","**","* *","****"]

Constraints:
1 <= n <= 100.
n is a positive integer, so the result always contains at least one row.


public class Solution {
    public IList<string> HollowTriangle(int n) {

        List<string> result = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string row = "";

            for (int j = 0; j <= i; j++)
            {
                if (j == 0 || j == i || i == n - 1)
                {
                    row += "*";
                }
                else
                {
                    row += " ";
                }
            }

            result.Add(row);
        }

        return result;
        
    }
}
