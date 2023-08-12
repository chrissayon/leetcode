namespace LeetCode;

public class IndexOfFirstOccurenceInString
{
    /*
      This is pretty much cheating because you're using linq
    */
    public int IndexOfFirstOccurenceInStringLinq(string haystack, string needle)
    {
        int result = -1;

        if (haystack.Contains(needle))
        {
            result = haystack.IndexOf(needle);
        }

        return result;
    }

    public int IndexOfFirstOccurenceInStringSlidingWindow(string haystack, string needle)
    {
        int haystackLength = haystack.Length;
        int needleLength = needle.Length;
        int slidingPointerStart = 0;
        int slidingPointerEnd = 0;

        while (slidingPointerEnd < haystackLength)
        {
            for (int i = 0; i < needleLength; i++)
            {
                var slidingPointerIndex = slidingPointerStart + i;
                bool reachedEndofHaystack = slidingPointerIndex >= haystackLength;

                if (reachedEndofHaystack || haystack[slidingPointerIndex] != needle[i])
                {
                    break;
                }

                if (i + 1 == needleLength)
                {
                    return slidingPointerStart;
                }
            }

            slidingPointerStart++;
            slidingPointerEnd++;
        }

        return -1;
    }
}
