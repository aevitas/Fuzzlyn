// Generated by Fuzzlyn v1.1 on 2018-09-09 17:23:23
// Seed: 7313991167565506358
// Reduced from 207.4 KiB to 0.5 KiB in 00:05:20
// Debug: Outputs 0
// Release: Outputs 2
public class Program
{
    static long[] s_20;
    static short[, ] s_24 = new short[, ]{{0}};
    public static void Main()
    {
        M47(0);
        short vr12 = s_24[0, 0];
        System.Console.WriteLine(vr12);
    }

    static void M47(short arg0)
    {
        try
        {
            arg0 = (short)M48();
            arg0 /= 32767;
        }
        finally
        {
            s_24[0, 0] = arg0;
        }
    }

    static int M48()
    {
        s_20 = new long[]{0};
        return 2147483646;
    }
}
