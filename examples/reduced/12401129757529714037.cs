// Generated by Fuzzlyn v1.1 on 2018-11-25 17:40:25
// Seed: 12401129757529714037
// Reduced from 277.5 KiB to 0.9 KiB in 00:06:00
// Debug: Outputs 1
// Release: Outputs 0
class C0
{
    public short F0;
}

struct S0
{
    public C0 F0;
    public S0(C0 f0): this()
    {
        F0 = f0;
    }
}

struct S1
{
    public bool F1;
    public long F2;
    public sbyte F4;
    public S1(bool f1): this()
    {
        F1 = f1;
    }
}

struct S2
{
    public S1 F5;
    public S0 F7;
    public S2(S0 f7): this()
    {
        F7 = f7;
    }
}

public class Program
{
    static S2 s_4 = new S2(new S0(new C0()));
    public static void Main()
    {
        var vr7 = new S1(true);
        var vr8 = new S1(false);
        var vr9 = new S1(true);
        M11(vr7, M11(vr8, vr9));
        var vr12 = s_4.F7;
        System.Console.WriteLine(vr12.F0.F0);
    }

    static ref S1 M11(S1 arg0, S1 arg1)
    {
        if (arg0.F1)
        {
            short var0 = s_4.F7.F0.F0++;
        }

        return ref s_4.F5;
    }
}