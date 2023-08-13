namespace LeetCode;

public class MoveZeroes
{
    public void MoveZeroesLinear(int[] nums)
    {
        int length = nums.Length;
        int[] newArray = new int[length];
        int newArrayPointer = 0;

        for (int i = 0; i < length; i++)
        {
            if (nums[i] != 0)
            {
                newArray[newArrayPointer] = nums[i];
                newArrayPointer++;
            }
        }

        for (int i = 0; i < length; i++)
        {
            nums[i] = newArray[i];
        }
    }

    public void MoveZeroesTwoPointer(int[] nums)
    {
        int length = nums.Length;
        int swapIndex = 0;

        for (int i = 0; i < length; i++)
        {
            if (nums[i] != 0)
            {
                (nums[swapIndex], nums[i]) = (nums[i], nums[swapIndex]);
                swapIndex++;
            }
        }
    }
}
