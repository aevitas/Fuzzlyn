// Generated by Fuzzlyn v1.1 on 2018-12-21 20:06:41
// Seed: 17623591389700227133
// Reduced from 423.8 KiB to 0.8 KiB in 00:07:24
// Debug: Outputs 1
// Release: Outputs 0
struct S0
{
    public ushort F3;
    public sbyte F4;
    public ulong F6;
    public S0(ulong f6): this()
    {
        F6 = f6;
    }
}

struct S1
{
    public S0 F1;
    public S0 F3;
    public S1(S0 f1): this()
    {
        F1 = f1;
    }
}

public class Program
{
    static S1 s_1;
    static S1 s_9;
    static S1 s_45;
    static S1[] s_94 = new S1[]{new S1(new S0(1))};
    public static void Main()
    {
        var vr4 = s_94[0];
        var vr5 = new S1(new S0(0));
        M82(vr4, M78(M82(vr5, s_45)));
    }

    static ref S1 M78(ulong arg1)
    {
        var vr0 = s_45.F3.F4;
        return ref s_9;
    }

    static ref ushort M82(S1 arg0, S1 arg2)
    {
        ulong var8 = arg0.F1.F6;
        System.Console.WriteLine(var8);
        return ref s_1.F1.F3;
    }
}
