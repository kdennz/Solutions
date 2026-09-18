public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LastFourDigits) Analyze(string phoneNumber)
    {
        bool isNewYork = phoneNumber.Substring(0, 3) == "212";
        bool isFake = phoneNumber.Substring(4, 3) == "555";
        string lastFourDigits = phoneNumber.Substring(phoneNumber.Length - 4);

        return (isNewYork, isFake, lastFourDigits);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LastFourDigits) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}