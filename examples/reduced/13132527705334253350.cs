// Generated by Fuzzlyn v1.1 on 2018-09-05 01:36:51
// Seed: 13132527705334253350
// Reduced from 298.8 KiB to 0.7 KiB in 00:13:47
// Debug: Outputs -127
// Release: Outputs 32385
public class Program
{
    static short[] s_16 = new short[]{0};
    static sbyte s_39 = -1;
    static int s_42;
    public static void Main()
    {
        uint vr6 = default(uint);
        var vr5 = (sbyte)vr6;
        M40(vr5);
    }

    static void M40(sbyte arg0)
    {
        try
        {
            s_42 = s_16[0];
        }
        finally
        {
            arg0 = s_39;
            short var10 = (short)(arg0 * 127);
            var vr2 = new byte[][]{new byte[]{1}, new byte[]{1}, new byte[]{0}, new byte[]{1}, new byte[]{1}, new byte[]{1}};
            System.Console.WriteLine(var10);
        }

        System.Console.WriteLine(arg0);
    }
}