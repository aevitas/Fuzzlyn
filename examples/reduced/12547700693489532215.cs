// Generated by Fuzzlyn v1.1 on 2018-11-24 02:15:20
// Seed: 12547700693489532215
// Reduced from 217.6 KiB to 0.6 KiB in 00:04:18
// Debug: Outputs -1
// Release: Outputs -23918
public class Program
{
    static bool[][][] s_37 = new bool[][][]{new bool[][]{new bool[]{true}}};
    static ulong s_51;
    public static void Main()
    {
        M63(0);
    }

    static void M63(short arg0)
    {
        try
        {
            bool vr3 = s_37[0][0][0];
        }
        finally
        {
            bool vr4 = s_37[0][0][0];
            if (vr4)
            {
                arg0 = (short)(s_51 - 1);
                arg0 %= 12779;
            }

            System.Console.WriteLine(arg0);
        }
    }
}
