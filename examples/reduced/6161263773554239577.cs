// Generated by Fuzzlyn v1.1 on 2018-08-22 14:26:32
// Seed: 6161263773554239577
// Reduced from 435.5 KiB to 0.5 KiB
// Debug: Outputs 65514
// Release: Outputs 4294967274
struct S0
{
    public ulong F0;
    public sbyte F5;
}

class C0
{
    public S0 F1;
}

public class Program
{
    static C0 s_3 = new C0();
    static S0[, ] s_21 = new S0[, ]{{new S0()}};
    public static void Main()
    {
        ref ulong vr25 = ref s_3.F1.F0;
        vr25 = 7936839781538275050UL;
        ref ulong vr26 = ref s_3.F1.F0;
        var vr27 = (ushort)((sbyte)vr26 ^ s_21[0, 0].F5);
        ulong vr28 = vr27;
        System.Console.WriteLine(vr28);
    }
}
