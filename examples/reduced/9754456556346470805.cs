// Generated by Fuzzlyn v1.1 on 2018-09-29 19:22:29
// Seed: 9754456556346470805
// Reduced from 212.5 KiB to 0.6 KiB in 00:03:21
// Debug: Outputs 0
// Release: Outputs 1
class C0
{
    public byte F6;
    public C0(byte f6)
    {
        F6 = f6;
    }
}

struct S0
{
    public C0 F1;
    public S0(C0 f1): this()
    {
        F1 = f1;
    }
}

struct S1
{
    public S0 F0;
    public S0 F4;
    public S1(S0 f4): this()
    {
        F4 = f4;
    }
}

public class Program
{
    static S1 s_26 = new S1(new S0(new C0(1)));
    public static void Main()
    {
        var vr1 = new S1[]{new S1(new S0(new C0(1)))};
        vr1[0].F4.F1.F6 = vr1[0].F4.F1.F6;
        vr1[0].F4.F1 = new C0(0);
        s_26.F4.F1.F6 = vr1[0].F4.F1.F6;
        System.Console.WriteLine(s_26.F4.F1.F6);
    }
}