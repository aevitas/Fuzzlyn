// Generated by Fuzzlyn v1.1 on 2018-09-08 06:24:23
// Seed: 7958787698505761776
// Reduced from 227.5 KiB to 0.7 KiB in 00:03:33
// Debug: Outputs 1
// Release: Outputs 0
struct S0
{
    public byte F0;
    public ulong F3;
    public sbyte F8;
}

struct S2
{
    public sbyte F0;
    public long F1;
    public ulong F3;
    public S2(sbyte f0): this()
    {
        F0 = f0;
    }
}

class C2
{
    public S0 F7;
}

public class Program
{
    static S2 s_22;
    static C2 s_39 = new C2();
    public static void Main()
    {
        var vr3 = s_39.F7;
        var vr5 = new S2(1);
        M32(vr5, M15(vr3));
    }

    static ref S2 M15(S0 arg1)
    {
        var vr0 = arg1.F8--;
        return ref s_22;
    }

    static void M32(S2 arg0, S2 arg1)
    {
        System.Console.WriteLine(arg0.F0);
    }
}
