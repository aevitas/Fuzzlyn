// Generated by Fuzzlyn v1.1 on 2018-12-31 00:27:24
// Seed: 10924754817584398793
// Reduced from 105.1 KiB to 0.4 KiB in 00:01:25
// Debug: Outputs 0
// Release: Outputs 1
struct S0
{
    public sbyte F1;
    public long F4;
    public short F5;
    public S0(sbyte f1): this()
    {
        F1 = f1;
    }
}

public class Program
{
    static S0 s_2;
    public static void Main()
    {
        var vr8 = new S0(1);
        M9(s_2, M9(vr8, s_2));
    }

    static ref S0 M9(S0 arg0, S0 arg1)
    {
        System.Console.WriteLine(arg0.F1);
        return ref s_2;
    }
}
