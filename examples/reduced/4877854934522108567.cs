// Generated by Fuzzlyn v1.1 on 2018-11-23 18:10:10
// Seed: 4877854934522108567
// Reduced from 284.0 KiB to 0.6 KiB in 00:07:28
// Debug: Outputs -329
// Release: Outputs 19422
public class Program
{
    static uint[] s_4 = new uint[]{0};
    static bool s_12;
    static int s_21;
    public static void Main()
    {
        var vr15 = (short)s_21;
        M27(vr15);
    }

    static void M27(short arg0)
    {
        try
        {
            arg0 = (short)M29(ref s_4);
            arg0 %= (3590 | 1);
        }
        finally
        {
            ++arg0;
        }

        System.Console.WriteLine(arg0);
    }

    static int M29(ref uint[] arg0)
    {
        bool vr5 = s_12;
        uint var0 = arg0[0];
        return -1030582658;
    }
}