// Generated by Fuzzlyn v1.1 on 2018-08-27 07:19:17
// Seed: 17704513321805579735
// Reduced from 186.9 KiB to 0.4 KiB
// Debug: Outputs 4294967169
// Release: Outputs 129
public class Program
{
    static sbyte s_37 = -127;
    public static void Main()
    {
        var vr1 = new short[]{0};
        M30(vr1, (uint)M72()) = 0;
    }

    static ref short M30(short[] arg6, long arg10)
    {
        System.Console.WriteLine(arg10);
        return ref arg6[0];
    }

    static sbyte M72()
    {
        return s_37;
    }
}
