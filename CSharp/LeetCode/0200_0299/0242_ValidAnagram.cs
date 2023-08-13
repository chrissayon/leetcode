namespace LeetCode;

public class ValidAnagram
{
    public bool ValidAnagramDoubleHashTable(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<string, int> sDict = new();
        Dictionary<string, int> tDict = new();
        int length = s.Length;

        for (int i = 0; i < length; i++)
        {
            var sLetter = s[i].ToString();
            var tLetter = t[i].ToString();

            if (!sDict.ContainsKey(sLetter))
            {
                sDict[sLetter] = 1;
            }
            else
            {
                sDict[sLetter]++;
            }

            if (!tDict.ContainsKey(tLetter))
            {
                tDict[tLetter] = 1;
            }
            else
            {
                tDict[tLetter]++;
            }
        }

        foreach (var key in sDict.Keys)
        {
            if (!tDict.ContainsKey(key) || sDict[key] != tDict[key])
            {
                return false;
            }
        }

        return true;
    }

    public bool ValidAnagramSingleHashTable(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> dict = new();
        int length = s.Length;

        for (int i = 0; i < length; i++)
        {
            dict.TryAdd(s[i], 0);
            dict.TryAdd(t[i], 0);

            dict[s[i]]++;
            dict[t[i]]--;
        }

        return dict.Values.All(value => value == 0);
    }
}
