// Generated by Fuzzlyn on 2018-07-05 07:09:29
// Seed: 14558859652369578488
// Reduced from 19.4 KiB to 0.2 KiB
// Debug: Outputs 65477
// Release: Outputs -59
public class Program
{
    static short s_2;
    static sbyte[, ] s_4;
    public static void Main()
    {
        s_4 = new sbyte[, ]{{-59}};
        char vr40 = (char)(s_4[0, 0] | s_2);
        System.Console.WriteLine((int)vr40);
    }
}
