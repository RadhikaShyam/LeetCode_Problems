public class Solution_12
{
    public int Reverse_BF(int x)
    {
        string s = x.ToString();
        string reversed = new string(s.Reverse().ToArray());

        if (reversed.EndsWith("-"))
        {
            reversed = "-" + reversed.Substring(0, reversed.Length - 1);
        }

        if (!long.TryParse(reversed, out long num) || num < int.MinValue || num > int.MaxValue)
            return 0;

        return (int)num;

    }

    public int Reverse_Optimal(int x)
    {
        long rev = 0;
        while (x != 0)
        {
            int digit = x % 10;
            rev = rev * 10 + digit;
            x = x / 10;
        }

        if (rev > int.MaxValue || rev < int.MinValue)
            return 0;

        return (int)rev;
    }
}