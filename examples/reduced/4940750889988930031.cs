// Generated by Fuzzlyn v1.1 on 2018-12-31 18:36:58
// Seed: 4940750889988930031
// Reduced from 260.2 KiB to 0.6 KiB in 00:03:57
// Debug: Outputs 1
// Release: Outputs 0
struct S1
{
    public ulong F0;
    public S1(ulong f0): this()
    {
        F0 = f0;
    }
}

class C0
{
}

struct S3
{
}

struct S5
{
    public S1 F0;
    public byte F2;
    public C0 F6;
    public S5(S1 f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S3 s_22;
    public static void Main()
    {
        var vr3 = new S5(new S1(1));
        var vr4 = new S5(new S1(0));
        M34(vr3, M34(vr4, s_22));
    }

    static ref S3 M34(S5 arg0, S3 arg1)
    {
        System.Console.WriteLine(arg0.F0.F0);
        return ref s_22;
    }
}