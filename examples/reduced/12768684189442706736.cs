// Generated by Fuzzlyn v1.1 on 2018-12-06 06:27:23
// Seed: 12768684189442706736
// Reduced from 384.6 KiB to 0.8 KiB in 00:04:53
// Debug: Outputs 1
// Release: Outputs 0
struct S0
{
    public long F0;
    public bool F2;
    public ulong F4;
}

class C0
{
}

class C1
{
    public S0 F0;
}

struct S1
{
    public C0 F0;
    public C0 F1;
    public short F8;
}

struct S2
{
    public byte F0;
    public uint F2;
    public uint F3;
    public short F5;
    public int F6;
    public S2(byte f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S1 s_1;
    static C1[] s_31 = new C1[]{new C1()};
    public static void Main()
    {
        var vr3 = new S2(1);
        var vr4 = s_31[0].F0;
        M3(vr3, M4(vr4));
    }

    static void M3(S2 arg0, S1 arg1)
    {
        System.Console.WriteLine(arg0.F0);
    }

    static ref S1 M4(S0 arg0)
    {
        System.Console.WriteLine(arg0.F0);
        return ref s_1;
    }
}