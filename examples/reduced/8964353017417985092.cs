// Generated by Fuzzlyn v1.1 on 2018-08-28 00:19:37
// Seed: 8964353017417985092
// Reduced from 22.8 KiB to 0.6 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public short F5;
}

class C1
{
    public C0 F2;
    public C1(C0 f2)
    {
        F2 = f2;
    }
}

struct S0
{
    public ulong F7;
    public C0 F8;
    public S0(C0 f8): this()
    {
        F8 = f8;
    }
}

public class Program
{
    static S0[][, ] s_1 = new S0[][, ]{new S0[, ]{{new S0(new C0())}}};
    public static void Main()
    {
        C1 vr19 = new C1(new C0());
        bool vr21 = (0 & s_1[0][0, 0].F7) >= 5560738292675101459UL;
        if (vr21)
        {
        }
        else
        {
            vr19.F2.F5 = s_1[0][0, 0].F8.F5;
        }
    }
}