// Generated by Fuzzlyn v1.1 on 2018-09-04 09:08:46
// Seed: 1858033125052991833
// Reduced from 55.4 KiB to 0.7 KiB in 00:01:07
// Debug: Prints 0 line(s)
// Release: Prints 1 line(s)
struct S0
{
    public bool F0;
    public ulong F2;
    public ushort F3;
    public S0(ulong f2): this()
    {
        F2 = f2;
    }
}

struct S1
{
    public ushort F2;
    public S0 F3;
}

public class Program
{
    static S0 s_1;
    static S0 s_3 = new S0(1);
    static short s_8;
    public static void Main()
    {
        var vr8 = new S1();
        M10(vr8, M12(s_3));
    }

    static void M10(S1 arg0, S0 arg1)
    {
        if (arg0.F3.F0)
        {
            sbyte vr11 = (sbyte)s_8;
            System.Console.WriteLine(vr11);
        }
    }

    static ref S0 M12(S0 arg1)
    {
        byte[][] var0 = new byte[][]{new byte[]{0}};
        return ref s_1;
    }
}