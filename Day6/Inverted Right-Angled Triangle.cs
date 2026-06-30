Given an integer n, build an inverted right-angled triangle made of stars and return it as an array of strings, where each string is one row.

The triangle has n rows, but it starts wide and shrinks.
The first row holds n stars, the next row holds one fewer, and the count keeps dropping by one until the last row holds a single star.
Row number i holds n - i + 1 stars. Every row is left-aligned, so there are no leading spaces.

n = 4

****
***
**
*

Example 1:
Input: n = 4

Output: ["****","***","**","*"]

Example 2:
Input: n = 3

Output: ["***","**","*"]

Constraints:
1 <= n <= 100.
n is a positive integer, so the result always contains at least one row.


public class Solution {
    public IList<string> InvertedTriangle(int n) {

        List<string>result=new List<string>();

        for(int i=n;i>=1;i--)
        {
            result.Add(new string('*',i));
        }
        return result;
    }
}
