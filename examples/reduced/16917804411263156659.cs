// Generated by Fuzzlyn on 2018-07-31 00:45:10
// Seed: 16917804411263156659
// Reduced from 448.8 KiB to 0.4 KiB
// Debug: Outputs 4294967269
// Release: Outputs 229
public class Program
{
    static sbyte s_8;
    static int[] s_22;
    static sbyte s_36 = -27;
    public static void Main()
    {
        ushort vr35 = 0;
        var vr30 = (0 + vr35) ^ (uint)M54();
        System.Console.WriteLine(vr30);
    }

    static sbyte M54()
    {
        M55();
        return s_8;
    }

    static int[] M55()
    {
        s_8 = s_36;
        return s_22;
    }
}