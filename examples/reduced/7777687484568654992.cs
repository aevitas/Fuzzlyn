// Generated by Fuzzlyn on 2018-07-29 15:11:49
// Seed: 7777687484568654992
// Reduced from 25.5 KiB to 0.2 KiB
// Debug: Outputs 65535
// Release: Outputs 4294967295
public class Program
{
    static sbyte s_5 = -1;
    public static void Main()
    {
        uint vr3 = default(uint);
        long vr4 = (char)(vr3 ^ s_5);
        System.Console.WriteLine(vr4);
    }
}
