namespace LeetCode;

class RepeatedSubstringPattern
{
    public bool RepeatedSubstringPatternCheck(string s)
    {
        for (int len = s.Length / 2; len >= 1; len--)
        {
            if (s.Length % len == 0)
            {
                string pattern = s.Substring(0, len);
                if (string.Concat(Enumerable.Repeat(pattern, s.Length / len)) == s)
                {
                    return true;
                }
            }
        }

        return false;
    }
}
