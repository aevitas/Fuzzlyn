// Generated by Fuzzlyn on 2018-06-25 03:52:07
// Seed: 12758934952815489045
// Reduced from 150.1 KiB to 0.2 KiB
// Debug: Outputs 160
// Release: Outputs 65440
public class Program
{
    static sbyte s_1 = -96;
    public static void Main()
    {
        byte vr37 = (byte)(s_1 | 0U);
        ushort vr41 = vr37;
        System.Console.WriteLine(vr41);
    }
}
