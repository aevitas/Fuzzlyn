// Generated by Fuzzlyn v1.1 on 2018-09-17 20:50:42
// Seed: 15348409686423443666
// Reduced from 374.4 KiB to 0.8 KiB in 00:11:14
// Debug: Outputs 0
// Release: Outputs -2
public class Program
{
    static ulong s_64;
    static sbyte s_76;
    static short s_173;
    public static void Main()
    {
        s_76 = -1;
        M163(s_76);
    }

    static void M163(sbyte arg0)
    {
        try
        {
            System.Console.WriteLine(s_173);
        }
        finally
        {
            M164();
            long var1 = 0;
            var vr1 = M164();
            arg0 = (sbyte)s_64;
            arg0 %= (-128 | 1);
            M164();
            System.Console.WriteLine(var1);
            bool[] var9 = new bool[]{false, true};
            System.Console.WriteLine(var9[0]);
        }

        System.Console.WriteLine(arg0);
    }

    static ref ulong M164()
    {
        return ref s_64;
    }
}