Given an integer n, return a butterfly pattern made of * characters as an array of strings, where each string is one row.

The pattern has a total width of 2n and 2n - 1 rows. For an upper row numbered i from 1 to n, the row holds i stars, then 2 * (n - i) spaces, then i stars. 
The upper half runs from i = 1 down to the middle row i = n, and the lower half repeats the upper rows in reverse, from i = n - 1 back up to i = 1. 
The result resembles a butterfly with its wings spread.

*    *
**  **
******
**  **
*    *


Example 1:
Input: n = 3

Output: ["*    *","**  **","******","**  **","*    *"]

Example 2:
Input: n = 2

Output: ["*  *","****","*  *"]

Constraints:
1 <= n <= 100.
The output always has 2n - 1 rows, and every row is exactly 2n characters wide.

public class Solution {
    public IList<string> ButterflyPattern(int n) {
        List<string> result = new List<string>();

        for (int i = 1; i <= n; i++)
        {
            string row = "";

            for (int j = 1; j <= i; j++)
            {
                row += "*";
            }

            for (int j = 1; j <= 2 * (n - i); j++)
            {
                row += " ";
            }

            for (int j = 1; j <= i; j++)
            {
                row += "*";
            }

            result.Add(row);
        }
        for (int i = n - 1; i >= 1; i--)
        {
            string row = "";

            for (int j = 1; j <= i; j++)
            {
                row += "*";
            }

            for (int j = 1; j <= 2 * (n - i); j++)
            {
                row += " ";
            }

            for (int j = 1; j <= i; j++)
            {
                row += "*";
            }

            result.Add(row);
        }
        return result;
    
    }
        
}
