// Generated by Fuzzlyn v1.1 on 2018-09-12 19:58:19
// Seed: 13161352015165064498
// Reduced from 202.1 KiB to 0.6 KiB in 00:05:19
// Debug: Outputs 1
// Release: Outputs 256
public class Program
{
    static byte s_13;
    static long[][] s_27 = new long[][]{new long[]{0}};
    static sbyte s_80;
    public static void Main()
    {
        var vr12 = s_27[0];
        M81(s_13, -1, ref vr12[0]);
    }

    static void M81(byte arg1, sbyte arg3, ref long arg4)
    {
        try
        {
            arg4 = arg4;
        }
        finally
        {
            arg1 = 4;
            s_80 = arg3;
        }

        arg3 = (sbyte)(arg3 * arg3);
        var vr0 = arg3 % (arg1 | 1);
        System.Console.WriteLine(vr0);
    }
}
