Given a single alphabet letter ch, determine whether it is a vowel or a consonant.

Return "Vowel" if the letter is one of a, e, i, o, or u (in either case), and "Consonant" otherwise.

Example 1:
Input: ch = "a"

Output: "Vowel"

Example 2:
Input: ch = "Q"

Output: "Consonant"

Constraints:
ch is a single English alphabet letter, either uppercase or lowercase.



public class Solution {
    public string VowelOrConsonant(char ch) {

        ch = char.ToLowerInvariant(ch);

        if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
        {
            return "Vowel";
        }

        return "Consonant";
    }
}
