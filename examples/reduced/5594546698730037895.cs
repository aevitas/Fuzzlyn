// Generated by Fuzzlyn v1.1 on 2018-10-05 23:03:27
// Seed: 5594546698730037895
// Reduced from 127.2 KiB to 0.5 KiB in 00:02:32
// Debug: Outputs -2
// Release: Outputs 0
public class Program
{
    static ushort[] s_47 = new ushort[]{65534};
    static long s_57;
    public static void Main()
    {
        sbyte vr4 = default(sbyte);
        M13(vr4, ref s_57);
    }

    static void M13(sbyte arg0, ref long arg1)
    {
        try
        {
            arg1 = arg1;
        }
        finally
        {
            bool vr0 = (0 % (arg0 | 1)) == arg1;
        }

        arg0 = (sbyte)s_47[0];
        arg0 %= -127;
        System.Console.WriteLine(arg0);
    }
}
