// Generated by Fuzzlyn v1.1 on 2018-09-19 18:27:00
// Seed: 10838890842513611343
// Reduced from 14.7 KiB to 0.4 KiB in 00:00:19
// Debug: Outputs 3473302
// Release: Outputs -4915050
public class Program
{
    static sbyte s_2;
    public static void Main()
    {
        M4(s_2, 150);
    }

    static void M4(sbyte arg2, ushort arg4)
    {
        arg2 = (sbyte)arg4;
        var vr0 = arg2 * -32767;
        System.Console.WriteLine(vr0);
        try
        {
            System.Console.WriteLine(0);
        }
        finally
        {
            arg2 = arg2++;
        }
    }
}
