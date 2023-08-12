namespace LeetCode;

public class _001_TwoSum
{
    /*
    My initial thought was two use a two index approach where you add the values of what the indexes are pointing two then check if it matches the target.
    
    You create the first index to start at position 0, you create the second index 2 to start at position 1 in the array.

    We will create a while loop that is conditional on both the indexes not exceeding the length of the array.

    The values at that index are grabbed and added together. If they match the target then you return those indexes.

    Otherwise you increment the second pointer and repeat the while loop.

    Once the second index has reached the length, it means that it's reached the end of the array. Hence, you will want to move the first index one position forward
    and have the second index start one position after that and repeat the process.

    Time Complexity: O(n^2) as we loop through it for both pointers
    Space Complexity: O(1) as the length, indexes, and output always stay the same size no matter how large "num" is
     */
    public int[] TwoSumBruteForce(int[] nums, int target)
    {
        int length = nums.Length;
        int index1 = 0;
        int index2 = 1;
        int[] output = { index1, index2 };

        while (index1 < length || index2 < length)
        {
            int result = nums[index1] + nums[index2];

            if (result == target)
            {
                output[0] = index1;
                output[1] = index2;
                return output;
            }

            index2++;
            if (index2 >= length)
            {
                index1++;
                index2 = index1 + 1;
            }
        }

        return output;
    }

    /*
    The other solution would be to use a hash table.

    You build your hash table that contains a
    - Key which is the value of the nums
    - Value which is the index of the nums

    Let's assume first that we just want to build the hash table normally and we didn't care about returning anything.
    We would just be adding the key-value pair into the dictionary which we would be able to navigate and tell us which value is at what index.

    You perform target - nums[i] to get the complement (the value that you need to get the target number).

    Now that you have the dictionary, you can check if the complementing value is inside there. If it is, you can grab it out and place it in the output.

    Time Complexity: O(n)
    Space Complexity: O(n)
     */
    public int[] TwoSumHashTable(int[] nums, int target)
    {
        var dictionary = new Dictionary<int, int>();
        int length = nums.Length;
        int[] output = { 0, 0 };

        for (int i = 0; i < length; i++)
        {
            int complement = target - nums[i];

            if (dictionary.ContainsKey(complement))
            {
                output[0] = dictionary[complement];
                output[1] = i;
                return output;
            }
            else if (!dictionary.ContainsKey(nums[i]))
            {
                dictionary.Add(nums[i], i);
            }
        }

        return output;
    }
}
