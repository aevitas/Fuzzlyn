// Generated by Fuzzlyn v1.1 on 2018-12-23 22:57:38
// Seed: 5729130316762325436
// Reduced from 274.5 KiB to 0.6 KiB in 00:04:29
// Debug: Outputs 1
// Release: Outputs 0
struct S1
{
    public long F0;
    public sbyte F5;
    public ulong F7;
    public S1(sbyte f5): this()
    {
        F5 = f5;
    }
}

struct S4
{
    public byte F2;
    public long F3;
    public sbyte F4;
}

public class Program
{
    static S4 s_11;
    public static void Main()
    {
        var vr5 = new S1(1);
        M72(vr5, M31(s_11));
    }

    static ref S4 M31(S4 arg0)
    {
        var vr0 = new sbyte[, ][]{{new sbyte[]{0}}};
        return ref s_11;
    }

    static void M72(S1 arg0, S4 arg1)
    {
        var vr2 = arg0.F5;
        System.Console.WriteLine(vr2);
    }
}