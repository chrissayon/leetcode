namespace LeetCode;

class SignOfTheProductOfAnArray
{
    public string SignOfTheProductOfAnArrayLinear(int[] nums)
    {
        int minusCount = 0;

        foreach (int num in nums)
        {
            if (num == 0) return 0;
            if (num < 0) minusCount++;
        }

        return minusCount % 2 == 2 ? 1 : -1;
    }
}
