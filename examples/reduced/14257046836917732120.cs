// Generated by Fuzzlyn on 2018-07-03 08:51:29
// Seed: 14257046836917732120
// Reduced from 76.8 KiB to 0.4 KiB
// Debug: Outputs 65514
// Release: Outputs 4294967274
public class Program
{
    static sbyte s_3;
    static byte s_4;
    public static void Main()
    {
        byte vr51 = 0;
        s_3 = (sbyte)(vr51 | 2240122858U);
        var vr54 = M31();
        uint vr55 = vr54;
        System.Console.WriteLine(vr55);
    }

    static char M31()
    {
        char var0 = (char)(s_4 ^ s_3);
        return var0;
    }
}
