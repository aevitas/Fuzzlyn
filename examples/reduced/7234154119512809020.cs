// Generated by Fuzzlyn v1.1 on 2018-12-12 19:58:43
// Seed: 7234154119512809020
// Reduced from 487.7 KiB to 0.9 KiB in 00:18:40
// Debug: Prints 1 line(s)
// Release: Prints 0 line(s)
class C0
{
    public ushort F0;
}

struct S0
{
    public bool F1;
    public ulong F3;
    public byte F4;
    public S0(bool f1): this()
    {
        F1 = f1;
    }
}

struct S1
{
    public S0 F3;
    public S1(S0 f3): this()
    {
        F3 = f3;
    }
}

public class Program
{
    static S1 s_23 = new S1(new S0(true));
    static S1 s_28;
    static S1 s_62;
    public static void Main()
    {
        s_28 = s_23;
        var vr42 = s_28.F3;
        S1 vr45 = default(S1);
        bool vr44 = M35(vr42, M49(vr45));
        if (vr44)
        {
            C0 vr41 = new C0();
            System.Console.WriteLine(vr41.F0);
        }
    }

    static bool M35(S0 arg0, S1 arg1)
    {
        s_28 = s_23;
        return arg0.F1;
    }

    static ref S1 M49(S1 arg0)
    {
        sbyte[][] var0 = new sbyte[][]{new sbyte[]{0}};
        return ref s_62;
    }
}
