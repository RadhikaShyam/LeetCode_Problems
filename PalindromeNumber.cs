public class Solution_11 {
    
      public bool IsPalindrome_BF(int x) {
        if(x<0) return false;
        string s = x.ToString();
        string reverse = new string(s.Reverse().ToArray());
        return (reverse ==s);
    }
    public bool IsPalindrome_Optimal(int x)
    {
        if (x < 0) return false;
        int y = 0;
        int num = x;
        while (x != 0)
        {
            int digit = x % 10;
            y = y * 10 + digit;
            x = x / 10;
        }
        return (y == num);

    }
}