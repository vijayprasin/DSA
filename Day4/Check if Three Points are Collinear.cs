Given three points (x1, y1), (x2, y2), and (x3, y3) with integer coordinates, determine whether they all lie on a single straight line.

Return true if the three points are collinear and false otherwise.

Example 1:
Input: x1 = 1, y1 = 1, x2 = 2, y2 = 2, x3 = 3, y3 = 3

Output: true

Example 2:
Input: x1 = 1, y1 = 1, x2 = 2, y2 = 2, x3 = 3, y3 = 5

Output: false

Constraints:
All coordinates are integers within a 32-bit signed range.

public class Solution {
    public bool AreCollinear(int x1, int y1, int x2, int y2, int x3, int y3) {
        
        return (y2-y1)*(x3-x1)==(y3-y1)*(x2-x1);
    }
}
