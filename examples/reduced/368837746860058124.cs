// Generated by Fuzzlyn v1.1 on 2018-08-29 17:52:14
// Seed: 368837746860058124
// Reduced from 203.0 KiB to 0.4 KiB
// Debug: Outputs 0
// Release: Outputs 65535
public class Program
{
    static int s_3;
    static ushort[] s_9 = new ushort[]{0};
    public static void Main()
    {
        var vr21 = new byte[]{0};
        vr21[0] = 247;
        bool vr23 = s_3 <= (sbyte)vr21[0];
        if (vr23)
        {
            long vr24 = s_9[0]--;
        }
        else
        {
        }

        System.Console.WriteLine(s_9[0]);
    }
}
