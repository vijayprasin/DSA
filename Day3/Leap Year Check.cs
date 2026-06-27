Given an integer year, determine whether it is a leap year.

Return true if year is a leap year and false otherwise.

A year is a leap year if it is divisible by 4, except for century years (those divisible by 100), which are leap years only when they are also divisible by 400.

Example 1:
Input: year = 2000

Output: true

Example 2:
Input: year = 1900

Output: false

Constraints:
year is a positive integer.

public class Solution {
    public bool IsLeapYear(int year) {
        if(year%400==0)
            return true;
        if(year%100==0)
            return false;
        if(year%4==0)
            return true;

        return false;
    }
}
