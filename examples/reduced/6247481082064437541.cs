// Generated by Fuzzlyn v1.1 on 2018-09-11 19:22:39
// Seed: 6247481082064437541
// Reduced from 247.0 KiB to 0.9 KiB in 00:06:50
// Debug: Outputs -1
// Release: Outputs 1
public class Program
{
    static uint s_4;
    static ushort s_29;
    static sbyte s_43 = 126;
    static bool[] s_51 = new bool[]{true};
    public static void Main()
    {
        sbyte vr5 = default(sbyte);
        M48(vr5);
    }

    static byte M48(sbyte arg0)
    {
        arg0 = s_43;
        arg0++;
        var vr0 = arg0++;
        arg0 /= 126;
        System.Console.WriteLine(arg0);
        try
        {
            M49();
        }
        finally
        {
            if (s_51[0])
            {
                s_4 = s_29;
                short[] var13 = new short[]{1, 1};
                var13[0] = var13[0];
                System.Console.WriteLine(var13[0]);
            }

            byte var14 = 1;
            System.Console.WriteLine(var14);
        }

        return (byte)arg0;
    }

    static sbyte M49()
    {
        return default(sbyte);
    }
}
