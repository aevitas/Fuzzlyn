// Generated by Fuzzlyn v1.1 on 2018-12-24 17:19:31
// Seed: 10059164568438843225
// Reduced from 21.4 KiB to 0.6 KiB in 00:00:26
// Debug: Outputs 0
// Release: Outputs 1
struct S0
{
    public long F0;
    public uint F2;
    public long F5;
    public S0(long f0): this()
    {
        F0 = f0;
    }
}

struct S2
{
    public sbyte F2;
    public uint F3;
    public sbyte F4;
    public uint F5;
    public ushort F7;
}

public class Program
{
    static S2 s_1;
    public static void Main()
    {
        var vr4 = new S0(0);
        var vr5 = new S0(1);
        var vr6 = new S2();
        M1(vr4, M1(vr5, vr6));
    }

    static ref S2 M1(S0 arg0, S2 arg1)
    {
        System.Console.WriteLine(arg0.F0);
        return ref s_1;
    }
}