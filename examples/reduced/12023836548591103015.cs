// Generated by Fuzzlyn v1.1 on 2018-12-30 20:14:19
// Seed: 12023836548591103015
// Reduced from 70.2 KiB to 0.6 KiB in 00:01:00
// Debug: Outputs 1
// Release: Outputs 0
struct S0
{
    public long F0;
    public ushort F2;
    public bool F4;
    public short F5;
    public sbyte F6;
    public short F8;
    public S0(long f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S0[] s_9 = new S0[]{new S0(1)};
    public static void Main()
    {
        var vr6 = s_9[0];
        var vr7 = new S0(0);
        var vr8 = new S0(0);
        M13(vr6, M13(vr7, vr8));
    }

    static ref S0 M13(S0 arg0, S0 arg1)
    {
        System.Console.WriteLine(arg0.F0);
        return ref s_9[0];
    }
}
