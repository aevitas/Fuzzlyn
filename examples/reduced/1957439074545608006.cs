// Generated by Fuzzlyn v1.1 on 2018-08-06 21:02:36
// Seed: 1957439074545608006
// Reduced from 104.7 KiB to 0.4 KiB
// Debug: Throws 'System.OverflowException'
// Release: Runs successfully
public class Program
{
    static ulong s_1;
    static long s_2;
    static long[][] s_52 = new long[][]{new long[]{-9223372036854775807L}};
    public static void Main()
    {
        var vr14 = s_52[0][0];
        s_2 = vr14;
        long vr19 = s_2--;
        M16();
    }

    static int M16()
    {
        return (short)(s_1 | (byte)(0 & (s_2 % (-2 | 1))));
    }
}