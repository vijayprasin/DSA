Given an integer n, build an n × n square where the border is drawn with the * character and the inside is left empty. 
Return the square as an array of n strings, one per row.

A cell holds a * when it sits on the outer frame, which means the top row, the bottom row, the leftmost column, or the rightmost column. 
Every cell strictly inside the frame holds a space. Each row string therefore has a length of exactly n.

****
*  *
*  *
****


Example 1:
Input: n = 4

Output: ["****","*  *","*  *","****"]

Example 2:
Input: n = 3

Output: ["***","* *","***"]

Constraints:
1 <= n <= 100.
n is a positive integer, so the result always contains at least one row.


public class Solution {
    public IList<string> HollowSquare(int n) {

        List<string> result = new List <string>();

        for(int i = 0; i < n; i++)
        {
            string row= "";

            for(int j = 0; j < n; j++)
            {
                if(i == 0 || i == n-1 || j == 0 || j == n-1)
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



