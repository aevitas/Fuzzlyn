// Generated by Fuzzlyn on 2018-06-19 17:44:31
// Seed: 1636897977138872103
// Reduced from 36.5 KiB to 0.3 KiB
// Debug: Outputs 33324
// Release: Outputs 44
public class Program
{
    public static void Main()
    {
        ushort[] vr7 = new ushort[]{0};
        vr7[0] = 33324;
        var vr8 = (sbyte)vr7[0];
        var vr9 = vr7[0];
        short vr10 = vr8;
        System.Console.WriteLine(vr9);
    }
}
