// Generated by Fuzzlyn v1.1 on 2018-09-04 13:42:35
// Seed: 8491442708941649780
// Reduced from 60.9 KiB to 0.5 KiB in 00:01:13
// Debug: Outputs 0
// Release: Outputs -128
public class Program
{
    static ushort s_29;
    static sbyte s_30 = -1;
    public static void Main()
    {
        bool vr8 = 0 <= M7(s_30);
    }

    static ushort M7(sbyte arg1)
    {
        try
        {
            M8();
        }
        finally
        {
            System.Console.WriteLine(arg1);
        }

        var vr3 = arg1++;
        var vr5 = arg1 / 2;
        System.Console.WriteLine(vr5);
        return s_29;
    }

    static bool M8()
    {
        return default(bool);
    }
}