// Generated by Fuzzlyn v1.1 on 2018-11-30 06:20:52
// Seed: 1271902346139176213
// Reduced from 208.7 KiB to 0.8 KiB in 00:06:39
// Debug: Outputs 0
// Release: Outputs -3
public class Program
{
    static short s_2;
    static short s_15;
    static uint s_19;
    static long[] s_20;
    static sbyte[] s_21;
    public static void Main()
    {
        s_20 = new long[]{-1};
        long vr11 = s_20[0];
        var vr10 = (short)vr11;
        M32(vr10);
        s_2 = s_15;
        System.Console.WriteLine(s_2);
    }

    static void M32(short arg1)
    {
        short var1 = default(short);
        try
        {
            System.Console.WriteLine(var1);
        }
        finally
        {
            arg1 = (short)(s_20[0] % 1);
            arg1 /= 30728;
            try
            {
                s_21 = new sbyte[]{0};
            }
            finally
            {
                System.Console.WriteLine(s_19);
            }

            s_15 = arg1;
        }
    }
}
