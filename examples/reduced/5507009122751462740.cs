// Generated by Fuzzlyn v1.1 on 2018-11-24 23:23:56
// Seed: 5507009122751462740
// Reduced from 239.3 KiB to 0.9 KiB in 00:05:38
// Debug: Prints 1 line(s)
// Release: Prints 2 line(s)
class C0
{
    public int F2;
    public ulong F3;
}

public class Program
{
    static C0 s_4 = new C0();
    static uint s_16;
    static C0 s_49 = new C0();
    static C0 s_51 = new C0();
    static int s_63;
    public static void Main()
    {
        uint vr5 = 4294967294U;
        var vr3 = (short)vr5;
        M72(vr3);
    }

    static sbyte M72(short arg0)
    {
        try
        {
            s_49.F3 = s_16;
        }
        finally
        {
            arg0 = (short)s_49.F3;
            short var0 = arg0;
            if (var0 < 0)
            {
                s_63 = s_4.F2;
                bool[] var2 = new bool[]{true, false, false, false, true, false};
                System.Console.WriteLine(var2[0]);
            }

            s_51.F2 = 0;
            System.Console.WriteLine(var0);
        }

        return (sbyte)arg0;
    }
}
