Given three positive numbers a, b, and c representing side lengths, determine whether they can form a valid triangle.

Return true if the three lengths form a triangle and false otherwise.

Example 1:
Input: a = 3, b = 4, c = 5

Output: true

Example 2:
Input: a = 1, b = 1, c = 2

Output: false

Constraints:
a, b, and c are positive numbers.

public class Solution {
    public bool IsValidTriangle(double a, double b, double c) {
        
        return (a+b>c && a+c>b && b+c>a);
    }
}
