// Generated by Fuzzlyn v1.1 on 2018-08-30 14:18:19
// Seed: 13437732165398478601
// Reduced from 77.9 KiB to 0.6 KiB in 00:02:30
// Debug: Outputs 0
// Release: Outputs 1
class C0
{
    public uint F0;
    public int F1;
    public C0(uint f0, int f1)
    {
        F0 = f0;
    }
}

struct S3
{
    public uint F1;
    public C0 F2;
    public S3(C0 f2): this()
    {
        F2 = f2;
    }
}

struct S5
{
    public S3 F1;
    public short F4;
    public S5(S3 f1): this()
    {
        F1 = f1;
    }
}

public class Program
{
    public static void Main()
    {
        var vr6 = new S5[]{new S5(new S3(new C0(1, 0)))};
        vr6[0].F1.F2 = new C0(vr6[0].F1.F1, vr6[0].F1.F2.F1);
        C0 vr8 = vr6[0].F1.F2;
        System.Console.WriteLine(vr8.F0);
    }
}
