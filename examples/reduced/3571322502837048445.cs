// Generated by Fuzzlyn v1.1 on 2018-09-19 20:02:41
// Seed: 3571322502837048445
// Reduced from 65.9 KiB to 0.9 KiB in 00:01:08
// Debug: Outputs 0
// Release: Outputs -3
class C0
{
    public byte F5;
}

public class Program
{
    static sbyte s_1;
    static C0 s_11 = new C0();
    static short[][] s_18 = new short[][]{new short[]{-1}};
    public static void Main()
    {
        short vr6 = s_18[0][0];
        var vr4 = (sbyte)vr6;
        var vr5 = M13(ref s_18, vr4);
    }

    static bool M13(ref short[][] arg1, sbyte arg2)
    {
        short var29 = default(short);
        uint var39 = default(uint);
        try
        {
            arg2 = arg2++;
        }
        finally
        {
            System.Console.WriteLine(var29);
            arg1[0] = arg1[0];
            arg2 = s_1;
            arg2 /= 79;
            uint[, ] var40 = new uint[, ]{{0, 1}};
            System.Console.WriteLine(var39);
            System.Console.WriteLine(var40[0, 0]);
        }

        System.Console.WriteLine(arg2);
        return 0 == s_11.F5;
    }
}