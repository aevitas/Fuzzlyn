// Generated by Fuzzlyn v1.1 on 2018-10-04 21:02:15
// Seed: 2468474207426398797
// Reduced from 42.7 KiB to 0.6 KiB in 00:00:32
// Debug: Outputs 0
// Release: Outputs 65536
public class Program
{
    static int s_3 = -1;
    public static void Main()
    {
        bool vr3 = 0 >= M2(-1);
    }

    static ulong M2(short arg1)
    {
        try
        {
            sbyte[] var2 = new sbyte[]{0};
        }
        finally
        {
            M3(arg1);
        }

        arg1 = (short)(-1 ^ s_3);
        short var6 = arg1;
        var vr1 = 0 - var6;
        System.Console.WriteLine(vr1);
        return 0;
    }

    static void M3(short arg1)
    {
        var vr2 = new ushort[][]{new ushort[]{0}};
    }
}