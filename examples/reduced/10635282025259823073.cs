// Generated by Fuzzlyn v1.1 on 2018-11-30 10:15:39
// Seed: 10635282025259823073
// Reduced from 14.7 KiB to 0.6 KiB in 00:00:24
// Debug: Prints 0 line(s)
// Release: Prints 1 line(s)
public class Program
{
    static bool[, ] s_2 = new bool[, ]{{false}};
    public static void Main()
    {
        M0();
    }

    static void M0()
    {
        ushort[] var0 = new ushort[]{0};
        try
        {
            if (s_2[0, 0])
            {
                try
                {
                    return;
                }
                finally
                {
                    System.Console.WriteLine(1);
                }
            }
            else
            {
                return;
            }
        }
        finally
        {
            var0[0] = 0;
        }
    }
}
