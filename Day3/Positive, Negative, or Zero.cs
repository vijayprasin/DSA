Given an integer n, classify it as positive, negative, or zero.

Return "Positive" if n is greater than 0, "Negative" if n is less than 0, and "Zero" if n equals 0.

Example 1:
Input: n = 5

Output: "Positive"

Example 2:
Input: n = 0

Output: "Zero"

Constraints:
n is an integer that fits in a 32-bit signed range.
n can be negative, zero, or positive.


public class Solution {
    public string Classify(int n) {
        if(n>0)
            return "Positive";
        if(n<0)
            return "Negative";
        return "Zero";
    }
}
