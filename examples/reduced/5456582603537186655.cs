// Generated by Fuzzlyn v1.1 on 2018-08-08 13:14:56
// Seed: 5456582603537186655
// Reduced from 21.1 KiB to 0.3 KiB
// Debug: Outputs 10
// Release: Outputs 0
public class Program
{
    static short s_1 = 32766;
    public static void Main()
    {
        M4(ref s_1);
    }

    static long M4(ref short arg0)
    {
        ushort var1 = (ushort)(10 % (ushort)(sbyte)(1U ^ arg0));
        System.Console.WriteLine(var1);
        return 0;
    }
}