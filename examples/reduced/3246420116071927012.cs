// Generated by Fuzzlyn on 2018-07-03 11:20:40
// Seed: 3246420116071927012
// Reduced from 62.6 KiB to 0.2 KiB
// Debug: Outputs 32768
// Release: Outputs -32768
public class Program
{
    public static void Main()
    {
        short[][] vr9 = new short[][]{new short[]{-32768}};
        char vr10 = (char)(vr9[0][0] | 0L);
        System.Console.WriteLine((int)vr10);
    }
}
