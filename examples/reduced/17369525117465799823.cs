// Generated by Fuzzlyn v1.1 on 2018-12-17 13:55:36
// Seed: 17369525117465799823
// Reduced from 45.7 KiB to 0.8 KiB in 00:00:33
// Debug: Outputs 0
// Release: Outputs 1
struct S0
{
    public byte F0;
    public long F3;
    public ushort F7;
}

class C0
{
    public sbyte F2;
}

struct S1
{
}

public class Program
{
    static S0 s_1;
    static byte[] s_2;
    static S1 s_4;
    public static void Main()
    {
        C0[] vr3 = new C0[]{new C0()};
        var vr4 = new S0();
        var vr5 = new uint[][]{new uint[]{0}};
        var vr6 = new short[]{0};
        M4(vr4, M2(0, ref s_2, ref vr3[0].F2, vr5, vr6, ref s_4, 1));
    }

    static ref S0 M2(long arg0, ref byte[] arg5, ref sbyte arg6, uint[][] arg7, short[] arg8, ref S1 arg10, ushort arg12)
    {
        System.Console.WriteLine(arg0);
        return ref s_1;
    }

    static void M4(S0 arg0, S0 arg1)
    {
        System.Console.WriteLine(arg0.F0);
    }
}