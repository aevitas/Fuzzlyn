// Generated by Fuzzlyn v1.1 on 2018-08-02 16:26:38
// Seed: 8038083559755299034
// Reduced from 73.9 KiB to 0.5 KiB
// Debug: Outputs -1
// Release: Outputs 0
struct S0
{
    public long F0;
    public int F4;
    public S0(int f4): this()
    {
        F4 = f4;
    }
}

public class Program
{
    static bool s_18;
    static S0[] s_32 = new S0[]{new S0(-1)};
    static S0[] s_37 = new S0[]{new S0(0)};
    static S0 s_38;
    public static void Main()
    {
        M17() = s_37[0];
        System.Console.WriteLine(s_38.F4);
    }

    static ref S0 M17()
    {
        s_37 = s_32;
        bool var1 = s_18;
        return ref s_38;
    }
}