// Generated by Fuzzlyn on 2018-07-17 21:26:05
// Seed: 14733046364259051630
// Reduced from 356.9 KiB to 0.2 KiB
// Debug: Outputs 65408
// Release: Outputs -128
public class Program
{
    static sbyte s_111 = -128;
    static short[, ] s_128 = new short[, ]{{0}};
    public static void Main()
    {
        char vr4 = (char)(s_111 | s_128[0, 0]);
        System.Console.WriteLine((int)vr4);
    }
}
