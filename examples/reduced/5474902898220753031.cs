// Generated by Fuzzlyn v1.1 on 2018-08-09 19:50:44
// Seed: 5474902898220753031
// Reduced from 50.7 KiB to 1.3 KiB
// Debug: Outputs 223
// Release: Outputs 199
public class Program
{
    static short s_2;
    static byte s_3;
    static sbyte[][] s_5 = new sbyte[][]{new sbyte[]{-33}};
    static uint s_11;
    static int s_24;
    public static void Main()
    {
        ref uint vr76 = ref s_11;
        s_2 = (short)(4881963697208219716UL - vr76);
        byte vr53 = s_3;
        var vr54 = (uint)s_24;
        ref sbyte vr70 = ref s_5[0][0];
        var vr72 = M3(2806136065362589786L, vr53, (uint)M3(M3(-1632183072821275457L, 255, 0, ref s_5), s_3, (uint)M3(-9223372036854775807L, s_3, 0, ref s_5), ref s_5), ref s_5);
        var vr107 = (uint)M3(8219282916100859439L, vr53, (uint)M3(vr70, vr53, s_11, ref s_5), ref s_5);
        var vr73 = (byte)M3(1150862919773275625L, (byte)M3(0, (byte)M3(9223372036854775807L, (byte)(-25016 | M3(-5937155849073549447L, (byte)M3(M3(M3(M3(-8122131902757605452L, (byte)(0 ^ ((uint)M3(9223372036854775806L, vr53, vr107, ref s_5) % s_2)), 0, ref s_5), 0, s_11, ref s_5), vr53, s_11, ref s_5), (byte)M15(), 0, ref s_5), vr54, ref s_5)), 0, ref s_5), 0, ref s_5), 0, ref s_5);
        M3(vr72, vr73, 0, ref s_5);
    }

    static ref sbyte M3(long arg0, byte arg1, uint arg2, ref sbyte[][] arg3)
    {
        System.Console.WriteLine(arg1);
        return ref arg3[0][0];
    }

    static ref uint M15()
    {
        return ref s_11;
    }
}