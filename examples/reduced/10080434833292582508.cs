// Generated by Fuzzlyn v1.1 on 2018-11-25 22:49:52
// Seed: 10080434833292582508
// Reduced from 152.0 KiB to 0.6 KiB in 00:03:47
// Debug: Outputs -1
// Release: Outputs 255
public class Program
{
    static sbyte[] s_52 = new sbyte[]{0};
    static sbyte s_56 = -1;
    public static void Main()
    {
        byte vr8 = default(byte);
        var vr7 = (sbyte)vr8;
        M54(vr7);
    }

    static void M54(sbyte arg0)
    {
        try
        {
            byte[][] vr14 = new byte[][]{new byte[]{0}};
        }
        finally
        {
            s_52[0] = arg0;
        }

        arg0 = s_56;
        sbyte var5 = arg0;
        short vr15 = var5;
        System.Console.WriteLine(vr15);
        System.Console.WriteLine(var5);
    }
}