// Generated by Fuzzlyn v1.1 on 2018-12-05 04:23:24
// Seed: 14258415118013046385
// Reduced from 210.4 KiB to 0.7 KiB in 00:02:09
// Debug: Outputs 1
// Release: Outputs 0
struct S1
{
    public uint F0;
    public long F5;
    public S1(uint f0): this()
    {
        F0 = f0;
    }
}

struct S2
{
    public S1 F0;
    public ushort F4;
    public S2(S1 f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S2[] s_5 = new S2[]{new S2(new S1(0))};
    public static void Main()
    {
        var vr2 = new S2(new S1(1));
        S2 vr4 = default(S2);
        M13(vr2, M37(vr4));
    }

    static void M13(S2 arg0, S2 arg1)
    {
        System.Console.WriteLine(arg0.F0.F0);
    }

    static ref S2 M37(S2 arg1)
    {
        sbyte[][] var0 = new sbyte[][]{new sbyte[]{0}};
        return ref s_5[0];
    }
}