Given two integers dividend and divisor, return an array [quotient, remainder] where quotient is the result of integer division (dividend / divisor keeping only the whole part) and remainder is what is left over (dividend % divisor).

The two values always satisfy the relationship dividend = divisor * quotient + remainder.

Example 1:
Input: dividend = 17, divisor = 5

Output: [3,2]

Example 2:
Input: dividend = 3, divisor = 8

Output: [0,3]

Constraints:
divisor != 0
Both values fit in the 32-bit signed integer range: -2^31 <= dividend, divisor <= 2^31 - 1


public class Solution {
    public int[] Divide(int dividend, int divisor) {
        
        int quotient=dividend/divisor;
        int remainder=dividend%divisor;

        return new[]
        {
            quotient,remainder
        };
    }
}
