// Generated by Fuzzlyn v1.1 on 2018-09-26 01:44:02
// Seed: 2670456101933299835
// Reduced from 207.9 KiB to 0.5 KiB in 00:09:33
// Debug: Outputs 0
// Release: Outputs 1
public class Program
{
    static uint s_38 = 1;
    public static void Main()
    {
        ulong vr67 = 1441721934U;
        var vr66 = (short)vr67;
        M55(vr66);
        short vr71 = (short)s_38;
        System.Console.WriteLine(vr71);
    }

    static void M55(short arg0)
    {
        short var0 = default(short);
        try
        {
            arg0 = (short)s_38;
            var0 = arg0;
            s_38 %= (uint)var0;
        }
        finally
        {
            var0 &= arg0;
        }
    }
}