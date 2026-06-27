Given an integer n, determine whether it is even or odd.

Return the string "Even" if n is divisible by 2, and "Odd" otherwise.

Example 1:
Input: n = 4

Output: "Even"

Example 2:
Input: n = -3

Output: "Odd"

Constraints:
n is an integer that fits in a 32-bit signed range.
n can be negative, zero, or positive.


public class Solution {
    public string EvenOrOdd(int n) {
        if(n%2==0)
            return "Even";

        return "Odd";
    }
}
