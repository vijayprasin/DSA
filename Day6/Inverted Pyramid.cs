Given an integer n, build an inverted pyramid of stars and return it as an array of strings, where each string is one row.

The inverted pyramid has n rows and a total width of 2n - 1 characters. 
It is the centered pyramid flipped upside down, so the widest row sits at the top and the single star ends up at the bottom. 
Row number i has i - 1 leading spaces followed by 2(n - i) + 1 stars.
As you move down, each row loses two stars and gains one leading space, which keeps the stars centered. There are no trailing spaces.


n = 3

*****
 ***
  *

Example 1:
Input: n = 3

Output: ["*****"," ***","  *"]

Example 2:
Input: n = 4

Output: ["*******"," *****","  ***","   *"]

Constraints:
1 <= n <= 100.
n is a positive integer, so the result always contains at least one row.


public class Solution {
    public IList<string> InvertedPyramid(int n) {
        
        List<string> result = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string row = "";

            for (int j = 0; j < i; j++)
            {
                row += " ";
            }

            for (int j = 0; j < (2 * (n - i) - 1); j++)
            {
                row += "*";
            }

            result.Add(row);
        }

        return result;
    }
}
