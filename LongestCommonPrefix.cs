public class Solution_7
{

    public string LongestCommonPrefix_BF(string[] strs)
    {
        string shortest = strs[0];
        // find the shortest string
        foreach (string s in strs)
        {
            if (s.Length > shortest.Length)
            {
                shortest = s;
            }

            // find prefix
            for (int i = 0; i < shortest.Length; i++)
            {
                char c = shortest[i];
                foreach (string sh in strs)
                {
                    if (sh[i] != c)
                        return shortest.Substring(0, i);
                }
            }
        }
        return shortest;
    }
    public string LongestCommonPrefix_Optimal(string[] strs)
    {
        string prefix = strs[0];
        for (int i = 1; i < strs.Length; i++)
        {
            while (!strs[i].StartsWith(prefix))
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
            }
        }
        return prefix;
    }
}