// Generated by Fuzzlyn on 2018-07-30 09:05:18
// Seed: 7915308571298172908
// Reduced from 39.6 KiB to 0.3 KiB
// Debug: Outputs 65492
// Release: Outputs -44
public class Program
{
    static byte[][] s_1;
    public static void Main()
    {
        s_1 = new byte[][]{new byte[]{212}};
        char vr4 = (char)M5();
        System.Console.WriteLine((int)vr4);
    }

    static ushort M5()
    {
        return (ushort)(sbyte)(s_1[0][0] | s_1[0][0]);
    }
}
