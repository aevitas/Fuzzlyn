// Generated by Fuzzlyn on 2018-07-24 20:42:24
// Seed: 18200732715593983815
// Reduced from 52.6 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
struct S0
{
    public bool F0;
    public sbyte F4;
}

struct S1
{
}

public class Program
{
    static S1 s_1;
    static S0[, ] s_3 = new S0[, ]{{new S0()}};
    public static void Main()
    {
        var vr15 = s_3[0, 0].F4 & 0;
        var vr16 = s_3[0, 0].F0;
        M4(vr15);
    }

    static short M4(int arg0)
    {
        s_1 = s_1;
        return 0;
    }
}
