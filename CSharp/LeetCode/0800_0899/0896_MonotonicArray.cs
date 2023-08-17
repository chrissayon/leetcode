namespace LeetCode;

class MonotonicArray
{
    public bool MonotonicArrayLinear(int[] nums)
    {
        bool? up = null;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1])
            {
                continue;
            }
            else if (up.HasValue == false)
            {
                up = nums[i] < nums[i + 1];
            }
            else
            {
                if (up.GetValueOrDefault() & nums[i] > nums[i + 1])
                {
                    return false;
                }
                else if (!up.GetValueOrDefault() & nums[i] < nums[i + 1])
                {
                    return false;
                }
            }
        }

        return true;
    }

    public bool MonotonicArrayDoubleLoop(int[] nums)
    {
        return Increasing(nums) || Decreasing(nums);
    }

    private bool Increasing(int[] nums)
    {
        int length = nums.Length;

        for (int i = 0; i < length - 1; i++)
        {
            if (nums[i] < nums[i + 1])
            {
                return false;
            }
        }

        return true;
    }

    private bool Decreasing(int[] nums)
    {
        int length = nums.Length;

        for (int i = 0; i < length - 1; i++)
        {
            if (nums[i] > nums[i + 1])
            {
                return false;
            }
        }

        return true;
    }
}
