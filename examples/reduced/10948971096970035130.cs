// Generated by Fuzzlyn v1.1 on 2018-11-21 22:38:12
// Seed: 10948971096970035130
// Reduced from 202.0 KiB to 0.7 KiB in 00:02:48
// Debug: Outputs 0
// Release: Outputs 1
struct S0
{
    public uint F0;
    public long F1;
    public byte F3;
}

class C0
{
}

public class Program
{
    static S0 s_5;
    static int[] s_24;
    static S0 s_26;
    static S0 s_29;
    static byte s_30;
    static ushort[] s_38 = new ushort[]{0};
    public static void Main()
    {
        C0 vr6 = default(C0);
        M26(s_5, M29(ref s_38[0], ref s_29, ref s_26, ref s_30, vr6, ref s_24, true));
    }

    static void M26(S0 arg0, S0 arg1)
    {
        System.Console.WriteLine(arg0.F0);
    }

    static ref S0 M29(ref ushort arg0, ref S0 arg3, ref S0 arg6, ref byte arg7, C0 arg8, ref int[] arg9, bool arg13)
    {
        System.Console.WriteLine(arg0);
        return ref arg3;
    }
}