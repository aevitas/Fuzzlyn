// Generated by Fuzzlyn v1.1 on 2018-12-29 13:38:46
// Seed: 8494586006283551901
// Reduced from 327.9 KiB to 0.7 KiB in 00:04:50
// Debug: Outputs 1
// Release: Outputs 0
struct S0
{
    public short F0;
    public ulong F2;
    public long F7;
}

struct S1
{
    public uint F6;
    public S0 F7;
    public S1(uint f6): this()
    {
        F6 = f6;
    }
}

public class Program
{
    static S0 s_12;
    static sbyte s_17;
    static S1 s_55 = new S1(1);
    public static void Main()
    {
        S0 vr5 = default(S0);
        bool vr4 = 0 == M61(s_55, M43(vr5));
    }

    static ref S0 M43(S0 arg4)
    {
        var vr2 = new int[][]{new int[]{0}};
        return ref s_12;
    }

    static sbyte M61(S1 arg0, S0 arg1)
    {
        uint var1 = arg0.F6;
        System.Console.WriteLine(var1);
        return s_17;
    }
}