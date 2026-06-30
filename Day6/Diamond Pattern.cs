Given an integer n, build a diamond of * characters that is 2n - 1 rows tall and 2n - 1 characters wide at its widest point. 
Return the diamond as an array of strings, one per row.

The diamond is made of two pyramids. 
The top half grows from a single star up to 2n - 1 stars across n rows, and the bottom half mirrors the top by repeating rows n - 1 down to 1. 
For a pyramid row k, counting from 1 to n, the line has n - k leading spaces followed by 2k - 1 stars, with no trailing spaces after the last star.

    *
   ***
  *****
 *******
  *****
   ***
    *

Example 1:
Input: n = 4

Output: ["   *","  ***"," *****","*******"," *****","  ***","   *"]

Example 2:
Input: n = 3

Output: ["  *"," ***","*****"," ***","  *"]

Constraints:
1 <= n <= 100.
n is a positive integer, so the result always contains at least one row.


public class Solution {
    public IList<string> DiamondPattern(int n) {

        List<string> result = new List<string>();

        for (int i = 1; i <= n; i++)
        {
            string row = "";

            for (int j = 1; j <= n - i; j++)
            {
                row += " ";
            }

            for (int j = 1; j <= 2 * i - 1; j++)
            {
                row += "*";
            }

            result.Add(row);
        }

        for (int i = n - 1; i >= 1; i--)
        {
            string row = "";

            for (int j = 1; j <= n - i; j++)
            {
                row += " ";
            }

            for (int j = 1; j <= 2 * i - 1; j++)
            {
                row += "*";
            }

            result.Add(row);
        }

        return result;
        
    }
}


