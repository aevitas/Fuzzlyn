// Generated by Fuzzlyn v1.1 on 2018-11-16 03:32:41
// Seed: 1458462863075489502
// Reduced from 312.0 KiB to 0.7 KiB in 00:14:51
// Debug: Outputs 1
// Release: Outputs 0
struct S0
{
    public short F0;
    public int F1;
    public ushort F2;
    public long F3;
    public S0(short f0): this()
    {
        F0 = f0;
    }
}

struct S1
{
    public S0 F2;
    public S1(S0 f2): this()
    {
        F2 = f2;
    }
}

public class Program
{
    static S0 s_4;
    static bool s_6;
    static S1 s_55 = new S1(new S0(1));
    public static void Main()
    {
        var vr38 = s_55.F2;
        S0 vr40 = default(S0);
        M84(vr38, M29(vr40));
    }

    static ref S0 M29(S0 arg5)
    {
        if (s_6)
        {
            int var1 = arg5.F1--;
        }

        return ref s_4;
    }

    static void M84(S0 arg0, S0 arg1)
    {
        System.Console.WriteLine(arg0.F0);
    }
}