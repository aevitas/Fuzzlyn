// Generated by Fuzzlyn v1.1 on 2018-09-19 14:27:47
// Seed: 12364623494633052362
// Reduced from 302.1 KiB to 1.1 KiB in 00:11:59
// Debug: Outputs 0
// Release: Outputs 23
class C0
{
    public short F3;
    public uint F8;
}

public class Program
{
    static short s_1 = 1;
    static int[][] s_3;
    static C0[, ][] s_5 = new C0[, ][]{{new C0[]{new C0()}}};
    static sbyte[] s_6 = new sbyte[]{0};
    static bool s_9;
    static sbyte s_15;
    public static void Main()
    {
        s_5[0, 0][0].F3 = s_1;
        var vr12 = new uint[]{0};
        s_9 = 1 != vr12[0];
        M32(0);
    }

    static void M32(short arg0)
    {
        arg0 = -1;
        if (s_9)
        {
            arg0 = s_5[0, 0][0].F3;
        }

        try
        {
            arg0 = (short)(arg0-- * (arg0 / -2827));
        }
        finally
        {
            uint var1 = s_5[0, 0][0].F8;
            var vr3 = s_6[0]--;
            var vr6 = (ushort)(var1 | var1++);
            M33(vr3, vr6);
            var vr8 = s_15--;
            M33(vr8, 0);
            System.Console.WriteLine(var1);
        }

        System.Console.WriteLine(arg0);
    }

    static ref int[][] M33(sbyte arg0, ushort arg1)
    {
        return ref s_3;
    }
}
