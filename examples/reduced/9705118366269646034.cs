// Generated by Fuzzlyn on 2018-07-07 17:38:46
// Seed: 9705118366269646034
// Reduced from 74.5 KiB to 0.3 KiB
// Debug: Outputs 65446
// Release: Outputs -90
class C0
{
    public sbyte F7;
    public C0(sbyte f7)
    {
        F7 = f7;
    }
}

public class Program
{
    static sbyte s_3;
    public static void Main()
    {
        var vr29 = new C0[, ]{{new C0(-90)}};
        char vr31 = (char)(s_3 | vr29[0, 0].F7);
        System.Console.WriteLine((int)vr31);
    }
}
