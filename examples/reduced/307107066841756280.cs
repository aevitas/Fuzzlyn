// Generated by Fuzzlyn on 2018-07-23 06:39:26
// Seed: 307107066841756280
// Reduced from 22.5 KiB to 0.3 KiB
// Debug: Outputs 65535
// Release: Outputs 0
public class Program
{
    static ushort s_2;
    static uint s_14;
    public static void Main()
    {
        long vr9 = 0 % (((0 & (0 % (M1() | 1))) * s_2) | 1);
        ushort vr10 = s_2;
        System.Console.WriteLine(vr10);
    }

    static uint M1()
    {
        ushort vr5 = s_2--;
        return s_14;
    }
}
