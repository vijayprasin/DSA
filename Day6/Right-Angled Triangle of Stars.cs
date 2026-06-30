Given an integer n, build a right-angled triangle made of stars and return it as an array of strings, 
where each string is one row of the triangle.

The triangle has n rows. The first row holds a single star,
the second row holds two stars, and each row after that adds one more star than the row above it. 
The last row holds n stars. Every row is left-aligned, so there are no leading spaces.

n = 4

*
**
***
****


Example 1:
Input: n = 4

Output: ["*","**","***","****"]

Example 2:
Input: n = 3

Output: ["*","**","***"]

Constraints:
1 <= n <= 100.
n is a positive integer, so the result always contains at least one row.


public class Solution {
    public IList<string> RightAngledTriangle(int n) {

        List<string>result=new List<string>();

        for(int i=1;i<=n;i++)
        {
            result.Add(new string('*',i));
        }
        return result;

    }
}
  
