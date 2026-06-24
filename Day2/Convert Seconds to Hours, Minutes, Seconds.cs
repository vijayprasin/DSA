Given a non-negative integer totalSeconds, convert it into hours, minutes, and seconds.

Return the result as an array [hours, minutes, seconds], where hours is the number of whole hours, minutes is the number of whole minutes left over after the hours, and seconds is the number of seconds left over after the minutes.

Example 1:
Input: totalSeconds = 3661

Output: [1,1,1]

Example 2:
Input: totalSeconds = 86399

Output: [23,59,59]

Constraints:
totalSeconds is a non-negative integer.


public class Solution {
    public int[] SecondsToHMS(int totalSeconds) {
        int hours=totalSeconds/3600;
        int remaining=totalSeconds%3600;

        int minutes=remaining/60;
        int seconds=remaining%60;

        return new int[]
        {
            hours,minutes,seconds
        };
    }
}
