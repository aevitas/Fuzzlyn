// Generated by Fuzzlyn v1.1 on 2018-09-17 02:56:22
// Seed: 8730669451490049096
// Reduced from 326.6 KiB to 0.9 KiB in 00:07:51
// Debug: Outputs -10918
// Release: Outputs 31578
public class Program
{
    static bool[][] s_22 = new bool[][]{new bool[]{false}};
    static short s_55;
    static short s_64;
    public static void Main()
    {
        uint vr8 = 2271800757U;
        var vr6 = (sbyte)vr8;
        bool vr7 = M76(vr6);
    }

    static ref bool M76(sbyte arg0)
    {
        uint var0 = default(uint);
        try
        {
            System.Console.WriteLine(var0);
        }
        finally
        {
            if (14532329473524959348UL > (ushort)arg0)
            {
                arg0 = (sbyte)M79();
            }
        }

        var vr3 = arg0++;
        s_55 = (short)(arg0 * 54618);
        System.Console.WriteLine(s_55);
        return ref s_22[0][0];
    }

    static ushort M79()
    {
        System.Console.WriteLine(s_64);
        ulong vr13 = default(ulong);
        return (ushort)vr13;
    }
}