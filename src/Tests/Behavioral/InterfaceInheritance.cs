// package main -- go2cs converted at 2018 June 07 01:54:02 UTC
// Original source: C:\Projects\go2cs\src\Tests\Behavioral\InterfaceInheritance.go

using fmt = go.fmt_package;

using static go.BuiltInFunctions;
using System.Collections.Generic;

namespace go
{
    public static unsafe partial class main_package
    {
        public partial struct T1
        {
            public string name;
        }



        public partial struct T2
        {
            public string name;
        }



        public partial interface I
        {
            public void M();
        }

        public partial interface V
        {
            public void N();
        }

        private static void Main() => func((defer, panic, recover) =>
        {
            m:=make(map[I]int)vari1I=T1{"foo"}vari2I=T2{"bar"}m[i1]=1m[i2]=2fmt.Println(m)n:=make(map[V]int)varv1V=T1{"foo"}varv2V=T2{"bar"}n[v1]=3n[v2]=4fmt.Println(n)
        });
    }
}