// Generated by Fuzzlyn v1.1 on 2018-09-26 06:12:50
// Seed: 1824040812196079631
// Reduced from 89.2 KiB to 0.3 KiB in 00:00:38
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public uint F3;
    public uint F4;
    public long F5;
}

public class Program
{
    static C0 s_2 = new C0();
    public static void Main()
    {
        ref C0 vr2 = ref s_2;
        if ((vr2.F5 > vr2.F5) & (vr2.F3 <= vr2.F3))
        {
            vr2.F4 = 0;
        }
    }
}