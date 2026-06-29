Given an integer n, return the number of digits in n.

Count the digits of the absolute value, so the sign of a negative number does not count. The number 0 has 1 digit.

Example 1:
Input: n = 12345

Output: 5

Example 2:
Input: n = -789

Output: 3

Constraints:
-2^31 <= n <= 2^31 - 1
n may be negative, zero, or positive.

public class Solution {
    public int CountDigits(int n) {
        
    }
}



public class Solution {
    public int CountDigits(int n) {

        if(n==0)
            return 1;

        n=Math.Abs(n);

        int count=0;
        while(n>0)
        {
            count++;
            n=n/10;
        }
        return count;
        
    }
}
