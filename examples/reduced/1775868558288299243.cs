// Generated by Fuzzlyn on 2018-06-20 17:48:57
// Seed: 1775868558288299243
// Reduced from 1.7 KiB to 0.2 KiB
// Debug: Outputs 8255614512881729469
// Release: Outputs 8255614513773019069
public class Program
{
    static ulong s_1;
    public static void Main()
    {
        s_1 = 8255614512881724349UL;
        s_1 |= (char)(sbyte)(0 ^ s_1);
        System.Console.WriteLine(s_1);
    }
}
