// Generated by Fuzzlyn v1.1 on 2018-09-23 21:29:56
// Seed: 6507663848642400237
// Reduced from 158.0 KiB to 0.7 KiB in 00:03:01
// Debug: Outputs 0
// Release: Outputs -12
public class Program
{
    static bool s_27 = true;
    static sbyte s_57;
    public static void Main()
    {
        M56(1);
    }

    static void M56(sbyte arg0)
    {
        short var16 = default(short);
        try
        {
            arg0 = s_57;
        }
        finally
        {
            if (s_27)
            {
                arg0 = -1;
                if (s_27)
                {
                    arg0 = (sbyte)M61(var16);
                    arg0 /= 20;
                }
            }

            System.Console.WriteLine(arg0);
        }
    }

    static ulong M61(short arg1)
    {
        System.Console.WriteLine(arg1);
        return 0;
    }
}