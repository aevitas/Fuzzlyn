// Generated by Fuzzlyn on 2018-07-01 05:02:03
// Seed: 10568034765343229766
// Reduced from 228.0 KiB to 0.2 KiB
// Debug: Outputs 235
// Release: Outputs 65515
public class Program
{
    static sbyte s_5 = -21;
    public static void Main()
    {
        ushort vr10 = (byte)(1L | s_5);
        System.Console.WriteLine(vr10);
    }
}
