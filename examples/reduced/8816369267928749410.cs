// Generated by Fuzzlyn v1.1 on 2018-09-15 16:09:07
// Seed: 8816369267928749410
// Reduced from 213.1 KiB to 0.4 KiB in 00:03:45
// Debug: Outputs 0
// Release: Outputs 13
public class Program
{
    static sbyte[] s_9 = new sbyte[]{-1};
    static byte s_48;
    public static void Main()
    {
        M63(0);
    }

    static void M63(sbyte arg0)
    {
        arg0 = s_9[0];
        arg0 /= 19;
        try
        {
            byte var4 = s_48++;
        }
        finally
        {
            System.Console.WriteLine(arg0);
        }
    }
}