// Generated by Fuzzlyn v1.1 on 2018-12-22 20:53:11
// Seed: 10871847052777261481
// Reduced from 38.9 KiB to 0.5 KiB in 00:00:24
// Debug: Outputs 1
// Release: Outputs 0
struct S0
{
    public ulong F0;
    public long F1;
    public ulong F4;
    public S0(ulong f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S0 s_9;
    static S0 s_15;
    public static void Main()
    {
        var vr2 = new S0(1);
        var vr3 = new S0(0);
        M7(vr2, M7(vr3, s_15));
    }

    static ref S0 M7(S0 arg0, S0 arg1)
    {
        System.Console.WriteLine(arg0.F0);
        return ref s_9;
    }
}