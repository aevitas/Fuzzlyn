// Generated by Fuzzlyn v1.1 on 2018-12-28 11:24:13
// Seed: 11157689263633266123
// Reduced from 240.2 KiB to 10.7 KiB in 00:45:23
// Debug: Outputs 1
// Release: Outputs 0
struct S0
{
    public long F0;
    public long F1;
    public long F2;
    public long F3;
    public ushort F4;
    public sbyte F5;
    public byte F6;
    public short F7;
    public S0(long f0, long f1, long f2, long f3): this()
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
        F3 = f3;
    }
}

struct S1
{
    public int F0;
    public S0 F3;
    public long F5;
    public ulong F8;
    public S1(S0 f3, long f5, ulong f8): this()
    {
        F3 = f3;
        F5 = f5;
        F8 = f8;
    }
}

struct S2
{
    public S0 F1;
    public S0 F4;
    public ulong F5;
    public long F6;
    public S2(S0 f1, S0 f4, ulong f5, long f6): this()
    {
        F1 = f1;
        F4 = f4;
        F5 = f5;
        F6 = f6;
    }
}

class C0
{
    public S1 F2;
    public S2 F6;
    public S0 F7;
    public C0(S1 f2, S2 f6, S0 f7)
    {
        F2 = f2;
        F7 = f7;
    }
}

public class Program
{
    static S1 s_3;
    static C0[] s_10 = new C0[]{new C0(new S1(new S0(0, 0, 0, 0), 0, 0), new S2(new S0(0, 0, 0, 0), new S0(0, 0, 0, 0), 0, 0), new S0(0, 0, 0, 0))};
    static S2[] s_12 = new S2[]{new S2(new S0(0, 0, 0, 0), new S0(0, 0, 0, 0), 0, 0)};
    static C0 s_13 = new C0(new S1(new S0(0, 0, 0, 0), 0, 0), new S2(new S0(0, 0, 0, 0), new S0(0, 0, 0, 0), 0, 0), new S0(0, 0, 0, 0));
    static S2 s_14;
    static S0 s_19;
    static C0 s_28 = new C0(new S1(new S0(0, 0, 0, 0), 0, 0), new S2(new S0(0, 0, 0, 0), new S0(0, 0, 0, 0), 0, 0), new S0(0, 0, 0, 0));
    public static void Main()
    {
        M0();
    }

    static void M0()
    {
        long var3 = default(long);
        var vr6 = new C0(new S1(new S0(0, 0, -9223372036854775807L, 9223372036854775806L), -1210177167228429798L, 0), new S2(new S0(0, 0, 0, 0), new S0(0, 0, 0, 9223372036854775807L), 14918221529243195275UL, 0), new S0(6132019599666471832L, 6943571502397056192L, 0, 0));
        S1[] vr24 = new S1[]{new S1(new S0(0, 0, 0, 0), 0, 0)};
        S2[] vr25 = new S2[]{new S2(new S0(0, 0, 0, 0), new S0(0, 0, 0, 0), 0, 0)};
        uint vr29 = default(uint);
        var vr2 = 0 >= vr29;
        var vr8 = new ulong[][]{new ulong[]{0}};
        var vr7 = M11(vr8);
        var vr1 = M1(vr2, vr7);
        S2[] vr31 = new S2[]{new S2(new S0(0, -304720733071078920L, -5753613219277844757L, -2505516695526890996L), new S0(2783582131684839293L, 5546758906366488487L, 1201687202220850710L, -6110692756778283099L), 14128747334106469689UL, 7925962649334580475L), new S2(new S0(3007434409220089625L, 0, 0, 0), new S0(-9223372036854775808L, 0, 0, 9223372036854775806L), 4618477985279644977UL, 0), new S2(new S0(0, -9223372036854775808L, 9223372036854775807L, -9223372036854775808L), new S0(-2333196441480598643L, -4977641856114746304L, 1448245933539310150L, -1190358262487806563L), 14911904925640326318UL, 0), new S2(new S0(-9223372036854775808L, 0, 1590204320697195116L, 0), new S0(0, 0, 0, 8986356394274783071L), 0, 0)};
        uint vr32 = default(uint);
        if (1 > vr32)
        {
            var vr0 = new C0[]{new C0(new S1(new S0(5953414537840852307L, -2279735916440391287L, 0, 0), 0, 0), new S2(new S0(-8077562261850313535L, 6730707123490496562L, 0, 0), new S0(0, 3469829426772705531L, 0, 0), 0, -8780998940878116309L), new S0(2912998051338441118L, -9223372036854775808L, 0, 9223372036854775807L)), new C0(new S1(new S0(0, 1953165702035861156L, 9223372036854775807L, -1908937799758496839L), -8178449119287304349L, 2571080072027279135UL), new S2(new S0(0, 8943753991894851499L, 0, 0), new S0(4844869630052927654L, 0, 0, 0), 0, 0), new S0(-6392615372527894306L, 0, 0, 0)), new C0(new S1(new S0(-9223372036854775808L, -1853502823277312793L, -2793884085713121994L, -6186848370241809400L), 9223372036854775806L, 7507429942086133366UL), new S2(new S0(0, 4873360528541648555L, 8169714033816209521L, -7061302159809322767L), new S0(0, 9223372036854775807L, -7416775506854275552L, 0), 0, 9223372036854775806L), new S0(-9223372036854775808L, 6999110266667476556L, 0, -6179896751378696432L)), new C0(new S1(new S0(0, -270347769518502138L, 9223372036854775806L, -4187753212706713304L), 0, 0), new S2(new S0(9223372036854775807L, 9223372036854775806L, 0, 2156475569582061407L), new S0(-9223372036854775808L, 0, 0, 0), 0, -1007732993104889390L), new S0(1460017729698275096L, 1158644498624412828L, 7358702482601951906L, -6020185442804467243L))};
            C0[] vr35 = new C0[]{new C0(new S1(new S0(9223372036854775806L, 0, -9223372036854775807L, 0), 4161402577112018652L, 0), new S2(new S0(0, 7623168146771154170L, 7686877944061978488L, 0), new S0(6208238415199688919L, 7607254656678056597L, 1972718909534079933L, -3128129193516166622L), 0, -9223372036854775808L), new S0(0, 0, -7859344683082111782L, 0)), new C0(new S1(new S0(1406904331429571506L, 1010725227240732212L, 2796706464549725351L, 8168262061023719976L), 0, 7577019826375580057UL), new S2(new S0(9223372036854775806L, 49685917115019908L, -7834601661973878906L, 9223372036854775807L), new S0(0, 0, 8898658502857881216L, 0), 0, 4275088588400930091L), new S0(-8345065686088129182L, 1083540555299913745L, 9223372036854775806L, 9223372036854775807L)), new C0(new S1(new S0(0, 0, 0, 9223372036854775807L), 9223372036854775807L, 9276521566757488625UL), new S2(new S0(-9214318087445959091L, 0, 0, 3990703712254052517L), new S0(0, -9223372036854775808L, 0, 0), 0, 0), new S0(0, 0, 7576489906768940063L, 0)), new C0(new S1(new S0(0, 0, 0, -1430218846857506059L), 0, 0), new S2(new S0(-9223372036854775808L, 9223372036854775806L, 0, 9223372036854775806L), new S0(6099492591335699978L, 0, 9223372036854775807L, 6049940645513203917L), 0, -3899769992813226275L), new S0(9223372036854775807L, -1347273670041132134L, 7186029098416787189L, -7068093043261887618L)), new C0(new S1(new S0(0, 7189641470226815752L, -3219769451819506479L, 7766213311477515770L), 5635143427424116145L, 0), new S2(new S0(0, -3067173656410380282L, -1111456320897929240L, 0), new S0(0, 9223372036854775806L, -8329553360436128604L, -9223372036854775808L), 0, 0), new S0(-9223372036854775807L, -1316537307397097914L, 0, -9223372036854775807L))};
            ref S0 vr36 = ref vr35[0].F6.F4;
            var vr44 = new C0[]{new C0(new S1(new S0(2269957350844548545L, 0, 0, -1246346761983877501L), 0, 0), new S2(new S0(0, 0, 0, 9223372036854775806L), new S0(0, 0, 6968305599601093106L, -6964230302469822665L), 14344669876757585023UL, 0), new S0(-2549795176447070418L, -7850148059932512033L, 0, 3860073164746257267L)), new C0(new S1(new S0(9223372036854775806L, 0, 1909533052554602107L, 8748548427499091420L), -9223372036854775808L, 0), new S2(new S0(0, 5013774586491460393L, 0, 0), new S0(6865882170080658626L, 777629396851415832L, 87071537023215085L, 1291211181655930477L), 16928370710714959323UL, 0), new S0(-6276406692785751279L, 2928887981890850405L, 0, 0)), new C0(new S1(new S0(0, 0, -3922986107872796869L, 0), -6028219678815594099L, 0), new S2(new S0(9223372036854775807L, 0, 5965144561358635971L, 9223372036854775807L), new S0(214574843273703830L, 0, -968068077734221429L, -9223372036854775808L), 16964897090577291720UL, -9223372036854775807L), new S0(2483356517966191589L, 9223372036854775807L, 0, -1380718023553000377L))};
            var vr45 = new S1(new S0(-3310681244807991190L, 0, 0, 6282853275990236817L), 8663040213691081956L, 10749236501455353361UL);
            S0 vr49 = vr44[0].F6.F4;
            vr36 = vr49;
            var vr4 = new C0(new S1(new S0(0, 0, -6418462152996900782L, 2490756580916786076L), -8232919496584799151L, 0), new S2(new S0(8762822604615442417L, 9223372036854775807L, -4787056636330817079L, 0), new S0(4581786577885745732L, 3413133284717164354L, 0, 0), 3787335823426597947UL, -275044034704338901L), new S0(0, -8236481287205028938L, 0, 8031304644155785689L));
            var vr9 = s_10[0].F2.F3.F4;
            var vr11 = s_14.F1.F4;
            var vr12 = s_14.F1.F5;
            var vr13 = new C0(new S1(new S0(0, -9223372036854775807L, -9223372036854775808L, -7131088692147807308L), 0, 0), new S2(new S0(0, 6733778020495804524L, -1344827652738588698L, 3956761943361650446L), new S0(1752024916769671586L, 0, 3716788177741711019L, -6961918244432649204L), 9204221312491764922UL, -9223372036854775807L), new S0(2288270776890185261L, 2475398291873855352L, 0, 0));
            var vr10 = M13(vr11, vr12, vr13);
            C0 vr50 = vr4;
            ushort vr51 = vr9;
            C0 vr53 = new C0(new S1(new S0(0, 5865996847373511293L, -5393691739139889505L, 0), 0, 0), new S2(new S0(0, 0, -594434595725318124L, -4043378895247218086L), new S0(9223372036854775807L, 0, 0, -8489105319151404640L), 0, 0), new S0(-9223372036854775807L, 0, -2675930270066190766L, -1224049717411629630L));
            var vr14 = (ulong)s_13.F6.F4.F7;
            var vr16 = new sbyte[][]{new sbyte[]{1}};
            sbyte vr37 = default(sbyte);
            var vr15 = (ushort)vr37;
            var vr17 = (ushort)s_3.F0;
            var vr18 = new C0(new S1(new S0(-9223372036854775808L, 4237651609664987344L, -3154638052012391222L, 3890178699347485506L), 0, 7820971785311084127UL), new S2(new S0(-9223372036854775807L, 0, 9223372036854775806L, 0), new S0(0, 5085809474825778113L, -4844923958575026389L, 9223372036854775807L), 0, -75214359849798262L), new S0(2045479568670912081L, 0, -7116635294181247730L, 0));
            M12(ref s_13.F6.F4.F4, ref s_12[0].F4.F4, vr14, 0, new S2[, ]{{new S2(new S0(0, 0, 0, 0), new S0(-5446945433618359052L, -1001224569664030835L, 9223372036854775807L, 4634403208550455804L), 0, 9223372036854775807L)}, {new S2(new S0(0, 0, 0, 0), new S0(-9223372036854775808L, 0, 9223372036854775807L, 0), 0, 0)}, {new S2(new S0(1343345526649117219L, -2292542756803672942L, 9223372036854775807L, 0), new S0(0, -9223372036854775807L, 9223372036854775806L, 0), 0, 0)}}, vr15, vr17, vr18);
            s_19 = new S0(6004916355881955626L, 0, -9223372036854775808L, 0);
            System.Console.WriteLine(var3);
            byte vr38 = s_13.F6.F1.F6;
            long vr39 = s_13.F7.F1;
            byte vr40 = vr38;
            var vr20 = new S2(new S0(0, 0, 0, 0), new S0(0, 0, 0, 0), 1, 0);
            var vr21 = s_28.F6;
            var vr22 = new S0(0, 0, 0, 0);
            M7(vr20, M20((sbyte)M7(vr21, vr22)));
        }
    }

    static uint M1(bool arg1, S2[] arg2)
    {
        return default(uint);
    }

    static long M7(S2 arg0, S0 arg1)
    {
        ulong vr41 = arg0.F5;
        System.Console.WriteLine(vr41);
        return 0;
    }

    static S2[] M11(ulong[][] arg0)
    {
        arg0 = arg0;
        return s_12;
    }

    static void M12(ref ushort arg0, ref ushort arg1, ulong arg2, ulong arg3, S2[, ] arg4, ushort arg6, ushort arg8, C0 arg9)
    {
    }

    static short M13(ushort arg1, sbyte arg2, C0 arg3)
    {
        return default(short);
    }

    static ref S0 M20(sbyte arg0)
    {
        return ref s_13.F7;
    }
}