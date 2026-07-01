Given an integer n, return an hourglass pattern made of * characters as an array of strings, where each string is one row.

The pattern has a total width of 2n - 1 and 2n - 1 rows. 
The top half is an inverted pyramid.
For a top row numbered i from 1 to n, the row holds i - 1 leading spaces followed by 2 * (n - i) + 1 stars, with no trailing spaces. 
The bottom half repeats rows i = n - 1 down to i = 1, forming an upward pyramid. 
Together, the two halves form an hourglass that is wide at the top and bottom and pinched to a single star in the middle.

*****
 ***
  *
 ***
*****

Example 1:
Input: n = 3

Output: ["*****"," ***","  *"," ***","*****"]

Example 2:
Input: n = 2

Output: ["***"," *","***"]

Constraints:
1 <= n <= 100.
The output always has 2n - 1 rows. Rows carry leading spaces but never trailing spaces, so a row is only as long as its last star.


public class Solution {
    public IList<string> HourglassPattern(int n) {

        List<string> result = new List<string>();

        for (int i = 1; i <= n; i++)
        {
            string row = "";

            for (int j = 1; j <= i - 1; j++)
            {
                row += " ";
            }

            for (int j = 1; j <= 2 * (n - i) + 1; j++)
            {
                row += "*";
            }

            result.Add(row);
        }

        for (int i = n - 1; i >= 1; i--)
        {
            string row = "";

            for (int j = 1; j <= i - 1; j++)
            {
                row += " ";
            }

            for (int j = 1; j <= 2 * (n - i) + 1; j++)
            {
                row += "*";
            }

            result.Add(row);
        }

        return result;
    }
}
