namespace LeetCode;

class MergeStringsAlternately
{
    /*
    
    Two index approach. Create an index for each word. Create a while loop.

    Create a while loop, and as long as the index is less then the length of the word, we add the letter of the word to the result (word);

    Time Complexity: O(n^2)
    Space Complexity: O(1)

     */
    public string MergeAlternatelyIndexes(string word1, string word2)
    {
        string word = string.Empty;
        int length1 = word1.Length;
        int length2 = word2.Length;
        int index1 = 0;
        int index2 = 0;

        while (index1 < length1 || index2 < length2)
        {
            if (index1 < length1)
            {
                word += word1[index1];
                index1++;
            }

            if (index2 < length2)
            {
                word += word2[index2];
                index2++;
            }
        }

        return word;
    }
}
