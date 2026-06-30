Given an integer n, build a centered pyramid of stars and return it as an array of strings, where each string is one row.

The pyramid has n rows and a total width of 2n - 1 characters.
Each row is a block of stars centered over that width, padded on the left with spaces.
Row number i has n - i leading spaces followed by 2i - 1 stars. 
The top row has a single star, and each row below adds two more stars while losing one space, so the stars stay centered. 
There are no trailing spaces.


n = 3

  *
 ***
*****


Example 1:
Input: n = 3

Output: ["  *"," ***","*****"]

Example 2:
Input: n = 4

Output: ["   *","  ***"," *****","*******"]

Constraints:
1 <= n <= 100.
n is a positive integer, so the result always contains at least one row.

public class Solution {
    public IList<string> PyramidOfStars(int n) {
        
        List<string> result = new List<string>();

        for (int i = 1; i <= n; i++)
        {
            string row = "";

            for (int j = 1; j <= n - i; j++)
            {
                row += " ";
            }

            for (int j = 1; j <= (2 * i - 1); j++)
            {
                row += "*";
            }

            result.Add(row);
        }

        return result;
        
    }
}



