// Generated by Fuzzlyn v1.1 on 2018-09-07 16:08:42
// Seed: 17686721645937148368
// Reduced from 189.4 KiB to 0.6 KiB in 00:04:11
// Debug: Outputs 18446744073709551361
// Release: Outputs 65025
class C0
{
    public ulong F0;
}

public class Program
{
    static sbyte s_5;
    static C0 s_19 = new C0();
    public static void Main()
    {
        var vr5 = s_19.F0;
        M39(vr5, s_5);
    }

    static void M39(ulong arg0, sbyte arg1)
    {
        try
        {
            try
            {
            }
            finally
            {
                arg0 = arg0;
            }
        }
        finally
        {
            var vr3 = arg1--;
            arg0 = (ulong)(arg1 * 255);
        }

        System.Console.WriteLine(arg0);
    }
}
