Given an integer n, return its absolute value without using any built-in absolute value function (such as Math.abs, abs, or fabs).

The absolute value of a number is its distance from zero, so it is always non-negative. 
For example, the absolute value of -5 is 5, and the absolute value of 5 is also 5.

Example 1:
Input: n = -5

Output: 5

Example 2:
Input: n = 42

Output: 42

Constraints:
-2^31 <= n <= 2^31 - 1
The input fits in a 32-bit signed integer.

public class Solution {
    public int AbsoluteValue(int n) {

        if(n<0)
            return -n;

        return n;
        
    }
}

