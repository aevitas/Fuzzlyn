// Generated by Fuzzlyn v1.1 on 2018-12-31 11:55:59
// Seed: 6237714008458406872
// Reduced from 270.6 KiB to 0.8 KiB in 00:07:30
// Debug: Outputs 1
// Release: Outputs 0
struct S0
{
    public uint F1;
    public ushort F3;
    public int F7;
}

struct S1
{
    public int F0;
    public S0 F3;
    public sbyte F5;
    public S1(int f0): this()
    {
        F0 = f0;
    }
}

struct S5
{
    public ulong F1;
    public S0 F2;
}

class C1
{
    public S1 F0;
    public C1(S1 f0)
    {
        F0 = f0;
    }
}

public class Program
{
    static C1 s_19 = new C1(new S1(1));
    public static void Main()
    {
        var vr2 = s_19.F0;
        S5 vr4 = default(S5);
        M30(vr2, M15(ref s_19, vr4));
    }

    static ref S1 M15(ref C1 arg0, S5 arg7)
    {
        System.Console.WriteLine(arg0.F0.F0);
        return ref arg0.F0;
    }

    static void M30(S1 arg0, S1 arg1)
    {
        System.Console.WriteLine(arg0.F0);
    }
}