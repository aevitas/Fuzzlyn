// Generated by Fuzzlyn v1.1 on 2018-10-05 20:36:11
// Seed: 16017484019160934767
// Reduced from 141.7 KiB to 1.3 KiB in 00:03:04
// Debug: Outputs 0
// Release: Outputs 1
struct S0
{
    public short F0;
    public bool F1;
    public S0(bool f1): this()
    {
        F1 = f1;
    }
}

struct S1
{
    public S0 F0;
    public S1(S0 f0): this()
    {
        F0 = f0;
    }
}

class C0
{
    public ulong F0;
    public S0 F5;
}

struct S2
{
    public S1 F1;
    public int F2;
    public C0 F3;
    public S2(S1 f1, C0 f3): this()
    {
        F1 = f1;
        F3 = f3;
    }
}

public class Program
{
    static S2 s_3;
    static S2 s_6 = new S2(new S1(new S0(true)), new C0());
    public static void Main()
    {
        int vr15 = default(int);
        var vr17 = new S2(new S1(new S0(true)), new C0());
        var vr18 = s_6.F3;
        var vr19 = new S2(new S1(new S0(false)), new C0());
        ushort vr20 = (ushort)M22(vr17, M21(vr18, vr15, (ushort)M22(vr19, s_3)));
        System.Console.WriteLine(vr20);
    }

    static ref S2 M21(C0 arg0, int arg1, ushort arg2)
    {
        bool vr0 = arg0.F5.F0-- != arg1;
        return ref s_6;
    }

    static ulong M22(S2 arg0, S2 arg1)
    {
        if (arg0.F1.F0.F1)
        {
            try
            {
                return arg1.F3.F0;
            }
            finally
            {
                M23();
            }
        }

        return 1;
    }

    static void M23()
    {
    }
}