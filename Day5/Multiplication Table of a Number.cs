Given an integer n, return its multiplication table from n × 1 to n × 10 as an array of 10 integers.

The first element holds n × 1, the second holds n × 2, and so on through n × 10 in the last position.

Example 1:
Input: n = 5

Output: [5,10,15,20,25,30,35,40,45,50]

Example 2:
Input: n = 7

Output: [7,14,21,28,35,42,49,56,63,70]

Constraints:
-1000 <= n <= 1000.
n can be negative, zero, or positive.



public class Solution {
    public int[] MultiplicationTable(int n) {

        int[] result = new int[10];

        for (int i = 1; i <= 10; i++)
        {
            result[i - 1] = n * i;
        }

        return result;
    }
}
