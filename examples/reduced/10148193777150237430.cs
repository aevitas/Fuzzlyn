// Generated by Fuzzlyn v1.1 on 2018-09-21 14:35:48
// Seed: 10148193777150237430
// Reduced from 175.6 KiB to 0.7 KiB in 00:02:14
// Debug: Outputs 1
// Release: Outputs 0
struct S0
{
    public bool F2;
    public ulong F3;
    public long F6;
    public S0(ulong f3): this()
    {
        F3 = f3;
    }
}

public class Program
{
    static S0 s_27;
    public static void Main()
    {
        var vr4 = new S0(1);
        var vr5 = new S0(0);
        bool vr6 = M1(vr4, M51(vr5));
    }

    static bool M1(S0 arg0, S0 arg1)
    {
        System.Console.WriteLine(arg0.F3);
        return arg0.F2;
    }

    static ref S0 M51(S0 arg1)
    {
        var vr3 = M54();
        M52(vr3);
        return ref s_27;
    }

    static void M52(long arg1)
    {
    }

    static sbyte M54()
    {
        return default(sbyte);
    }
}