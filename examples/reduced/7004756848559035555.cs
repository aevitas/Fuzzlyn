// Generated by Fuzzlyn v1.1 on 2018-09-18 22:17:47
// Seed: 7004756848559035555
// Reduced from 338.0 KiB to 0.5 KiB in 00:06:44
// Debug: Outputs 0
// Release: Outputs 1
struct S0
{
    public long F1;
    public ulong F2;
    public int F5;
}

struct S4
{
    public short F0;
    public S0 F3;
    public S4(short f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S4 s_11;
    public static void Main()
    {
        var vr10 = new S4(0);
        var vr11 = new S4(1);
        S0 vr14 = default(S0);
        M70(vr10, M70(vr11, vr14));
    }

    static ref S0 M70(S4 arg0, S0 arg1)
    {
        System.Console.WriteLine(arg0.F0);
        return ref s_11.F3;
    }
}
