using System;

public class Kata
{
    public static int DontGiveMeFive(int start, int end)
    {
        int count = 0;
        for (int i = start; i <= end; i++)
        {
            if (!ContainsFive(i))
                count++;
        }
        return count;
    }

    private static bool ContainsFive(int number)
    {
        return number.ToString().Contains("5");
    }
}
