// Generated by Fuzzlyn v1.1 on 2018-09-24 17:04:25
// Seed: 12362665957832140095
// Reduced from 294.7 KiB to 0.5 KiB in 00:08:20
// Debug: Outputs 1
// Release: Outputs 0
struct S0
{
    public ushort F0;
    public ulong F2;
    public byte F3;
    public sbyte F4;
}

struct S1
{
    public ushort F0;
    public S0 F1;
    public S1(ushort f0, S0 f1): this()
    {
        F0 = f0;
        F1 = f1;
    }
}

struct S3
{
    public S1 F0;
    public S3(S1 f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    public static void Main()
    {
        S3 vr4 = new S3(new S1(1, new S0()));
        ushort vr5 = vr4.F0.F0;
        System.Console.WriteLine(vr5);
    }
}
