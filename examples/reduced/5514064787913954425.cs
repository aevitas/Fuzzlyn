// Generated by Fuzzlyn v1.1 on 2018-09-06 08:07:18
// Seed: 5514064787913954425
// Reduced from 83.7 KiB to 0.6 KiB in 00:01:32
// Debug: Outputs 0
// Release: Outputs 8
public class Program
{
    static byte s_2;
    static short s_5;
    public static void Main()
    {
        var vr5 = new bool[]{true};
        M3(s_5, vr5);
        System.Console.WriteLine(s_2);
    }

    static void M3(short arg1, bool[] arg2)
    {
        try
        {
            M4();
        }
        finally
        {
            try
            {
                arg2[0] = arg2[0];
            }
            finally
            {
                M4();
            }
        }

        var vr3 = arg1--;
        s_2 = (byte)(arg1 / 126);
    }

    static ref byte M4()
    {
        return ref s_2;
    }
}
