/*

A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.

Given a string s, return true if it is a palindrome, or false otherwise.

Input: s = "A man, a plan, a canal: Panama"
Output: true
Explanation: "amanaplanacanalpanama" is a palindrome.

Input: s = "race a car"
Output: false
Explanation: "raceacar" is not a palindrome.

Input: s = " "
Output: true
Explanation: s is an empty string "" after removing non-alphanumeric characters.
Since an empty string reads the same forward and backward, it is a palindrome.

Constraints:

1 <= s.length <= 2 * 10^5
s consists only of printable ASCII characters.

*/

// _0125_ValidPalindrome

#include <string>

using std::string;

// 2-pointer solution

class _0125_ValidPalindrome {
public:
    bool isPalindrome(string s) {
        int i = 0;
        int j = s.size() - 1;

        while (i < j) {
            while (!isalnum(s[i]) && i < j) { // checks if character is alphanumeric
                i++;
            }
            while (!isalnum(s[j]) && i < j) {
                j--;
            }
            if (tolower(s[i]) != tolower(s[j])) {
                return false;
            }
            i++;
            j--;
        }

        return true;
    }
};