// Generated by Fuzzlyn v1.1 on 2018-08-21 21:39:38
// Seed: 13032094475069485303
// Reduced from 175.5 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static ushort[, ] s_37 = new ushort[, ]{{0}};
    public static void Main()
    {
        M1(ref s_37);
    }

    static short M1(ref ushort[, ] arg0)
    {
        byte var0 = (byte)(0 & arg0[0, 0]);
        arg0[0, 0] = var0;
        return 0;
    }
}
