// Generated by Fuzzlyn on 2018-07-20 02:02:36
// Seed: 14327927757344991677
// Reduced from 30.0 KiB to 0.3 KiB
// Debug: Throws 'System.OverflowException'
// Release: Runs successfully
public class Program
{
    static ushort s_1;
    public static void Main()
    {
        long vr10 = 0;
        s_1--;
        bool vr11 = (vr10 * (-9223372036854775808L / (sbyte)(255 / ((0 % s_1) | 1)))) <= 0;
        if (vr11)
        {
            vr10 = vr10--;
        }
    }
}
