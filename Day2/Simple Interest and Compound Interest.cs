Given three numbers principal, rate, and time, return a two-element array [simpleInterest, compoundInterest].

The simple interest is the interest earned on the original principal only:

simpleInterest = principal * rate * time / 100

The compound interest is the interest earned when each year's interest is added back to the balance, so the next year earns interest on a larger amount. With interest compounded annually:

compoundInterest = principal * (1 + rate/100)^time - principal

Round each value to two decimal places.

Example 1:
Input: principal = 1000, rate = 5, time = 2

Output: [100,102.5]

Example 2:
Input: principal = 10000, rate = 12, time = 2

Output: [2400,2544]

Constraints:
principal > 0
rate >= 0
time >= 0 (integer number of years)



public class Solution {
    public double[] Interest(double principal, double rate, double time) {
        double SI=Math.Round((principal*rate*time)/100.0,2);
        double CI=Math.Round(principal*Math.Pow(1+rate/100.0,time)-principal,2);

        return new double[]{SI,CI};
    }
}
