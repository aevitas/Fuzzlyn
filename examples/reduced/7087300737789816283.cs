// Generated by Fuzzlyn on 2018-07-08 22:32:27
// Seed: 7087300737789816283
// Reduced from 65.7 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public ulong F0;
    public bool F3;
}

public class Program
{
    static C0[][, ] s_2 = new C0[][, ]{new C0[, ]{{new C0()}}};
    static ulong[][] s_3 = new ulong[][]{new ulong[]{0}};
    public static void Main()
    {
        s_3[0][0] = s_2[0][0, 0].F0 & 0;
        bool vr25 = s_2[0][0, 0].F3;
    }
}