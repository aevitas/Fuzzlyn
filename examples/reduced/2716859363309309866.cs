// Generated by Fuzzlyn on 2018-07-03 06:42:45
// Seed: 2716859363309309866
// Reduced from 8.2 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.IndexOutOfRangeException'
public class Program
{
    static char[, ] s_2;
    public static void Main()
    {
        var vr10 = new int[][, ]{new int[, ]{{0}}};
        M5(vr10, 0);
    }

    static byte M5(int[][, ] arg0, uint arg2)
    {
        byte var0 = (byte)(0 & (arg2 ^ arg0[0][0, 0]));
        s_2 = s_2;
        System.Console.WriteLine(arg0[0][0, 0]);
        return (byte)(var0 ^ arg0[0][0, 0]);
    }
}