// Generated by Fuzzlyn on 2018-06-26 10:01:23
// Seed: 230774123694233000
// Reduced from 15.2 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
struct S0
{
    public sbyte F0;
    public long F3;
    public S0(sbyte f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S0[, ] s_1 = new S0[, ]{{new S0(86)}};
    public static void Main()
    {
        sbyte vr0 = (sbyte)((0 & s_1[0, 0].F3) % s_1[0, 0].F0);
    }
}
