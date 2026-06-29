Given an integer n, return an array of the integers from 1 to n in increasing order.

The first element of the array is 1, the last element is n, and every integer in between appears exactly once.

Example 1:
Input: n = 5

Output: [1,2,3,4,5]

Example 2:
Input: n = 3

Output: [1,2,3]

Constraints:
1 <= n <= 1000.
n is a positive integer, so the result always contains at least one element.



public class Solution {
    public int[] PrintNumbers(int n) {
        int[] result = new int[n];

        for(int i=0;i<n;i++){
            result[i]=i+1;
        }
        return result;
    }
}
