// Generated by Fuzzlyn v1.1 on 2018-12-12 05:06:52
// Seed: 12995905739590348437
// Reduced from 201.0 KiB to 0.5 KiB in 00:03:21
// Debug: Outputs 0
// Release: Outputs 1
struct S0
{
}

struct S1
{
    public short F0;
    public S0 F5;
    public S1(short f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S1[] s_42 = new S1[]{new S1(0)};
    static S1 s_50;
    public static void Main()
    {
        var vr5 = new S1(1);
        var vr6 = new S1(0);
        M68(s_50, M68(vr5, vr6));
    }

    static ref S1 M68(S1 arg0, S1 arg1)
    {
        System.Console.WriteLine(arg0.F0);
        return ref s_42[0];
    }
}
