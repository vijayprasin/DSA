Given a temperature temp and a scale scale, convert the temperature to the other scale.

If scale is "C", then temp is in Celsius and you return the equivalent Fahrenheit value using F = temp * 9 / 5 + 32.

If scale is "F", then temp is in Fahrenheit and you return the equivalent Celsius value using C = (temp - 32) * 5 / 9.

Round the result to 2 decimal places.

Example 1:
Input: temp = 100, scale = "C"

Output: 212.00

Example 2:
Input: temp = 32, scale = "F"

Output: 0.00
Constraints:
temp is a real number within a reasonable range.
scale is either "C" or "F".


public class Solution {
    public double Convert(double temp, string scale) {
        if(scale=="C")
            return Math.Round((temp*9/5)+32,2);

        return Math.Round((temp-32)*5/9,2);
    }
}
