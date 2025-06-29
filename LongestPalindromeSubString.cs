public class Solution_5
{
    public string LongestPalindrome(string s)
    {
        int maxLength = 0;
        string longest = "";
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = i; j < s.Length; j++)
            {
                string substr = s.Substring(i, j - i + 1);
                if (IsPalindrome(substr) && substr.Length > maxLength)
                {
                    longest = substr;
                    maxLength = substr.Length;
                }
            }

        }

        return longest;


    }

    public bool IsPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;
        while (left < right)
        {
            if (s[left] != s[right]) return false;
            left++;
            right--;
        }
        return true;
    }
}