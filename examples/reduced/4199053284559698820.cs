// Generated by Fuzzlyn v1.1 on 2018-10-04 04:38:06
// Seed: 4199053284559698820
// Reduced from 36.0 KiB to 0.7 KiB in 00:00:38
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public short F1;
    public int F7;
    public C0(short f1)
    {
        F1 = f1;
    }
}

class C1
{
    public byte F1;
    public C0 F3;
    public int F4;
    public int F6;
    public C1(byte f1, C0 f3, int f6)
    {
        F1 = f1;
        F3 = f3;
        F6 = f6;
    }
}

class C2
{
    public C1 F0;
}

public class Program
{
    public static void Main()
    {
        var vr2 = new C2[]{new C2()};
        bool vr3 = 0 >= M2(vr2);
    }

    static int M2(C2[] arg0)
    {
        arg0[0].F0 = new C1(0, new C0(1), 1);
        if ((arg0[0].F0.F1 * arg0[0].F0.F6) != arg0[0].F0.F3.F1)
        {
            arg0[0].F0.F3.F7 = arg0[0].F0.F4;
        }

        return 0;
    }
}
