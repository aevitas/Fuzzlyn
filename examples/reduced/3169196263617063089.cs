// Generated by Fuzzlyn on 2018-07-24 15:00:48
// Seed: 3169196263617063089
// Reduced from 87.0 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static int[][][, ] s_1 = new int[][][, ]{new int[][, ]{new int[, ]{{0}}}};
    static uint s_4;
    public static void Main()
    {
        sbyte vr7 = 0;
        vr7 <<= (byte)(0 % (((0 * s_4) * s_1[0][0][0, 0]) | 1));
        bool vr8 = 0 == s_1[0][0][0, 0];
    }
}
