// Generated by Fuzzlyn on 2018-07-09 16:46:42
// Seed: 9652943880841305550
// Reduced from 16.4 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static sbyte[][, ] s_1 = new sbyte[][, ]{new sbyte[, ]{{0}}};
    public static void Main()
    {
        int vr3 = s_1[0][0, 0] & 0;
        s_1[0][0, 0] = s_1[0][0, 0];
        System.Console.WriteLine(vr3);
    }
}
