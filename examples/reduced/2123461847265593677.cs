// Generated by Fuzzlyn v1.1 on 2018-12-07 15:30:45
// Seed: 2123461847265593677
// Reduced from 135.8 KiB to 0.6 KiB in 00:02:58
// Debug: Outputs 0
// Release: Outputs 1
struct S0
{
    public sbyte F1;
    public ulong F2;
    public short F3;
    public S0(sbyte f1): this()
    {
        F1 = f1;
    }
}

public class Program
{
    static S0[] s_13 = new S0[]{new S0(0)};
    static long[][] s_34;
    public static void Main()
    {
        S0 vr11 = default(S0);
        var vr10 = new S0(1);
        M48(vr11, M51(ref s_13[0], vr10));
    }

    static void M48(S0 arg0, S0 arg1)
    {
        System.Console.WriteLine(arg0.F1);
    }

    static ref S0 M51(ref S0 arg0, S0 arg1)
    {
        s_34 = new long[][]{new long[]{0}};
        return ref arg0;
    }
}