Given a positive integer n, return the sum of all of its divisors, including 1 and n itself.

A divisor of n is any positive integer that divides n with no remainder. For example, the divisors of 12 are 1, 2, 3, 4, 6, 12, and their sum is 28.

Example 1:
Input: n = 12

Output: 28

Example 2:
Input: n = 6

Output: 12

Constraints:
1 <= n <= 10^6.
The sum fits in a 32-bit integer at this range, but use a 64-bit accumulator to stay safe against larger inputs.


public class Solution {
    public int SumOfDivisors(int n) {
        
        int sum=0;

        for(int i=1;i<=n;i++)
        {
            if(n%i==0)
            {
                sum +=i;
            }
        }
        return sum;
    }
}
