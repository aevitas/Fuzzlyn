// Generated by Fuzzlyn v1.1 on 2018-12-03 01:32:25
// Seed: 8723159037195378221
// Reduced from 274.4 KiB to 0.5 KiB in 00:05:59
// Debug: Outputs 1
// Release: Outputs 0
struct S0
{
    public long F0;
}

struct S1
{
    public S0 F0;
    public S0 F2;
}

public class Program
{
    static S1 s_33;
    static S1[] s_40 = new S1[]{new S1()};
    public static void Main()
    {
        bool vr1 = M104();
    }

    static bool M104()
    {
        S1[] var7 = s_40;
        s_33.F0 = var7[0].F0;
        var7[0].F0.F0 = 1;
        var7[0].F2 = var7[0].F0;
        System.Console.WriteLine(var7[0].F2.F0);
        return false;
    }
}