using System;

public static class EliudsEggs
{
    public static int EggCount(int number)
    {
        return Convert.ToString(number, 2).Replace("0", "").Length;
    }
}