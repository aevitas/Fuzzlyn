// Generated by Fuzzlyn v1.1 on 2018-12-20 07:07:03
// Seed: 6219287903481300415
// Reduced from 81.5 KiB to 0.8 KiB in 00:00:59
// Debug: Outputs 0
// Release: Outputs 3837291960
struct S0
{
    public int F0;
}

struct S1
{
    public uint F0;
    public long F1;
    public long F2;
}

public class Program
{
    static S0 s_2;
    static S0 s_3;
    static S1 s_4;
    static long s_14;
    public static void Main()
    {
        var vr8 = new S1();
        var vr9 = new sbyte[][][, ][]{new sbyte[][, ][]{new sbyte[, ][]{{new sbyte[]{0}}}}};
        var vr10 = new int[][]{new int[]{0}};
        M12(vr8, M8(ref s_3, 0, vr9, 0, ref s_2, s_14, vr10));
    }

    static ref S1 M8(ref S0 arg0, long arg1, sbyte[][][, ][] arg2, short arg3, ref S0 arg4, long arg5, int[][] arg6)
    {
        System.Console.WriteLine(arg0.F0);
        return ref s_4;
    }

    static void M12(S1 arg0, S1 arg1)
    {
        System.Console.WriteLine(arg0.F0);
    }
}