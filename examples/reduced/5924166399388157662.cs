// Generated by Fuzzlyn v1.1 on 2018-11-28 17:46:40
// Seed: 5924166399388157662
// Reduced from 36.2 KiB to 1.1 KiB in 00:00:49
// Debug: Outputs 0
// Release: Outputs 125
public class Program
{
    static bool s_5 = true;
    static sbyte[] s_6 = new sbyte[]{0};
    static long[][] s_13 = new long[][]{new long[]{0}};
    public static void Main()
    {
        var vr4 = s_6[0];
        M11(vr4, 0);
    }

    static void M11(sbyte arg0, sbyte arg1)
    {
        sbyte var0 = default(sbyte);
        try
        {
            System.Console.WriteLine(var0);
        }
        finally
        {
            var vr1 = s_13[0][0];
            M13(s_5, s_5, new short[][]{new short[]{0}, new short[]{1}, new short[]{0}, new short[]{0}, new short[]{0}, new short[]{0}});
        }

        arg0 = arg1;
        arg1 = -1;
        if (s_5)
        {
            var vr0 = (uint)0;
            arg1 = (sbyte)M14(vr0);
            arg1 %= 127;
        }

        System.Console.WriteLine(arg1);
    }

    static ushort[] M13(bool arg0, bool arg5, short[][] arg6)
    {
        return new ushort[]{1};
    }

    static int M14(uint arg0)
    {
        System.Console.WriteLine(arg0);
        return 0;
    }
}
