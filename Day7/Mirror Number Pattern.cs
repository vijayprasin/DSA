Given an integer n, build a mirror number pattern and return its rows as strings. 
Row i (counting from 1) counts up from 1 to i and then back down from i - 1 to 1, written next to each other with no spaces.

So row 1 is "1", row 2 is "121", row 3 is "12321", and each row reads the same forwards and backwards.

n = 3

Row 1:  1
Row 2:  121
Row 3:  12321

Example 1:
Input: n = 3

Output: ["1","121","12321"]

Example 2:
Input: n = 5

Output: ["1","121","12321","1234321","123454321"]

Constraints:
1 <= n <= 9.
Keeping n at most 9 means every value from 1 to n is a single digit, so the row stays a clean numeric palindrome with no ambiguity about where one digit ends and the next begins.


public class Solution {
    public IList<string> MirrorNumberPattern(int n) {
        List <string>result = new List<string>();

        for(int i = 1; i <= n; i++)
        {
            string row = "";
        
            for(int j = 1; j <= i; j++)
            {
            row += j;
            }  
        for(int j = i-1; j >= 1; j--)
        {
            row += j;
        } 
            result.Add(row);
        }
        return result;
    }
}
