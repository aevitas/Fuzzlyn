// Generated by Fuzzlyn v1.1 on 2018-08-31 23:52:35
// Seed: 8788509178554572875
// Reduced from 199.5 KiB to 0.3 KiB
// Debug: Outputs 2801795071
// Release: Outputs 65535
public class Program
{
    static ushort[] s_11 = new ushort[]{0};
    public static void Main()
    {
        ushort[] vr1 = s_11;
        vr1[0] = 65535;
        uint vr2 = (uint)(vr1[0] | 14840605082847747080UL);
        System.Console.WriteLine(vr2);
    }
}