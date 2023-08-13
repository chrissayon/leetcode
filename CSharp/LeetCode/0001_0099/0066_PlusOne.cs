namespace LeetCode;

public class PlusOne
{
    public int[] PlusOneSimple(int[] digits)
    {
        // We create a new array because the digits parameters is pass by reference
        // We don't want to mess with the original array
        int[] newArray = digits.ToArray();
        int length = digits.Length;

        for (int i = length - 1; i >= 0; i--)
        {
            if (digits[i] != 9)
            {
                newArray[i]++;
                return newArray;
            }
            else
            {
                newArray[i] = 0;
            }
        }

        // We only reach this point if we the 1 is carried all the way to the beginning, like having a 99 or 999 input
        int[] carriedAllTheWayArray = new int[length + 1];
        carriedAllTheWayArray[0] = 1;

        return carriedAllTheWayArray;
    }
}
