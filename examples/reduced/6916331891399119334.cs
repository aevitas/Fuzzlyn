// Generated by Fuzzlyn on 2018-07-17 10:01:54
// Seed: 6916331891399119334
// Reduced from 8.7 KiB to 0.2 KiB
// Debug: Outputs 65535
// Release: Outputs -1
public class Program
{
    static sbyte s_1 = -1;
    static int s_6;
    public static void Main()
    {
        char vr1 = (char)(s_1 ^ 0U);
        s_6 = vr1;
        System.Console.WriteLine(s_6);
    }
}
