// Generated by Fuzzlyn v1.1 on 2018-12-08 19:02:07
// Seed: 9252368253661589290
// Reduced from 473.9 KiB to 0.5 KiB in 00:10:25
// Debug: Outputs 0
// Release: Outputs -1
struct S0
{
    public sbyte F1;
    public long F5;
    public short F6;
    public S0(sbyte f1): this()
    {
        F1 = f1;
    }
}

public class Program
{
    static S0 s_7;
    static S0[] s_24 = new S0[]{new S0(1)};
    public static void Main()
    {
        var vr7 = new S0(0);
        var vr8 = new S0(-1);
        var vr9 = M53(vr7, M53(vr8, s_7));
    }

    static ref S0 M53(S0 arg0, S0 arg1)
    {
        System.Console.WriteLine(arg0.F1);
        return ref s_24[0];
    }
}