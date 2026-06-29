Given an integer n and a string parity that is either "even" or "odd", return the sum of all numbers of that parity from 1 to n inclusive.

For example, when n is 10 and parity is "even", the numbers in range are 2, 4, 6, 8, and 10, which sum to 30. When parity is "odd", the numbers are 1, 3, 5, 7, and 9, which sum to 25. If there is no matching number in the range, return 0.

Example 1:
Input: n = 10, parity = "even"

Output: 30

The even numbers from 1 to 10 are 2, 4, 6, 8, and 10. They add up to 30.

Example 2:
Input: n = 9, parity = "odd"

Output: 25

The odd numbers from 1 to 9 are 1, 3, 5, 7, and 9, which sum to 25.

Constraints:
0 <= n <= 10000.
parity is always either "even" or "odd".
The sum fits comfortably in a 32-bit signed integer for the given range. For much larger values of n, switch to a 64-bit type to avoid overflow.


public class Solution {
    public int SumByParity(int n, string parity) {

        int sum=0;

        for(int i=0;i<=n;i++){
            if(parity=="even" && i%2==0){
                sum +=i;
            }
            else if(parity=="odd" && i%2!=0){
                sum +=i;
            }
        }
        return sum;
        
    }
}
