// Generated by Fuzzlyn v1.1 on 2018-11-24 17:29:22
// Seed: 17251359349616687125
// Reduced from 330.6 KiB to 1.2 KiB in 00:18:15
// Debug: Outputs True
// Release: Outputs False
struct S0
{
    public byte F1;
    public sbyte F4;
    public S0(sbyte f4): this()
    {
        F4 = f4;
    }
}

public class Program
{
    static int[] s_7 = new int[]{0};
    static int s_33;
    static bool s_34;
    static S0[] s_66 = new S0[]{new S0(0)};
    public static void Main()
    {
        var vr9 = s_66[0].F4;
        var vr10 = new S0(-1);
        M81(vr9, vr10);
    }

    static void M81(sbyte arg0, S0 arg1)
    {
        int[, ] var0 = new int[, ]{{0}};
        try
        {
            System.Console.WriteLine(594058834);
        }
        finally
        {
            var0[0, 0] = s_7[0]--;
            S0 var6 = arg1;
            var vr2 = s_33++;
            M82();
            M82();
            System.Console.WriteLine(var6.F1);
            System.Console.WriteLine(var6.F4);
        }

        if (!s_34)
        {
            arg0 = arg1.F4;
            sbyte var20 = arg0;
            bool var21 = var20 < 1;
            System.Console.WriteLine(var20);
            System.Console.WriteLine(var21);
        }

        System.Console.WriteLine(arg0);
    }

    static uint M82()
    {
        return default(uint);
    }
}
