// Generated by Fuzzlyn v1.1 on 2018-11-10 05:26:20
// Seed: 3428476216859511074
// Reduced from 114.4 KiB to 0.8 KiB in 00:00:57
// Debug: Outputs -85
// Release: Outputs -72064
struct S0
{
    public short F2;
    public byte F3;
    public S0(byte f3): this()
    {
        F3 = f3;
    }
}

struct S1
{
    public S0 F0;
    public S1(S0 f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S1[][] s_6 = new S1[][]{new S1[]{new S1(new S0(0))}};
    static S1 s_12 = new S1(new S0(171));
    public static void Main()
    {
        var vr3 = new S0(0);
        var vr5 = vr3.F2;
        M3(vr5);
    }

    static void M3(short arg0)
    {
        try
        {
            byte vr10 = s_6[0][0].F0.F3;
        }
        finally
        {
            byte vr12 = s_12.F0.F3;
            arg0 = (short)(arg0 + (sbyte)vr12);
            var vr1 = arg0 % (23992 | 1);
            System.Console.WriteLine(vr1);
        }
    }
}
