// Generated by Fuzzlyn v1.1 on 2018-09-27 03:04:05
// Seed: 15325509998736166192
// Reduced from 153.9 KiB to 0.3 KiB in 00:02:48
// Debug: Outputs 0
// Release: Outputs -6553
public class Program
{
    static uint s_12;
    public static void Main()
    {
        M16(0);
    }

    static void M16(short arg0)
    {
        try
        {
            s_12 = 0;
        }
        finally
        {
            arg0--;
            arg0 /= -10;
        }

        System.Console.WriteLine(arg0);
    }
}