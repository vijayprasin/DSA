Given two numbers a and b, swap their values and return the result as a two-element array [b, a].

In other words, the value that started in a should appear in the second position, and the value that started in b should appear in the first position.

Example 1:
Input: a = 5, b = 7

Output: [7,5]

Example 2:
Input: a = -3, b = 9

Output: [9,-3]

Constraints:
Both a and b fit in the 32-bit signed integer range: -2^31 <= a, b <= 2^31 - 1.
The values may be negative, zero, or equal to each other.


public class Solution {
    public int[] Swap(int a, int b) {
         int temp =a;
         a=b;
         b=temp;
        return new int[] {a,b};
         
    }
}
