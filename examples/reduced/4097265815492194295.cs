// Generated by Fuzzlyn v1.1 on 2018-12-31 07:50:30
// Seed: 4097265815492194295
// Reduced from 274.1 KiB to 0.5 KiB in 00:05:55
// Debug: Outputs 0
// Release: Outputs 1
struct S1
{
    public ushort F0;
    public ulong F3;
    public uint F4;
}

struct S3
{
    public uint F0;
    public S1 F6;
    public S3(uint f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S3 s_6;
    public static void Main()
    {
        var vr6 = new S3(0);
        var vr7 = new S3(1);
        var vr8 = new S1();
        M35(vr6, M35(vr7, vr8));
    }

    static ref S1 M35(S3 arg0, S1 arg1)
    {
        System.Console.WriteLine(arg0.F0);
        return ref s_6.F6;
    }
}
