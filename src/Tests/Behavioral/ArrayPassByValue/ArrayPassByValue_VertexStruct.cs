//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2019 November 18 03:23:10 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "1.0.0.0")]
        public partial struct Vertex : EmptyInterface
        {
            // Constructors
            public Vertex(NilType _)
            {
                this.X = default;
                this.Y = default;
            }

            public Vertex(@int X = default, @int Y = default)
            {
                this.X = X;
                this.Y = Y;
            }

            // Enable comparisons between nil and Vertex struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Vertex value, NilType nil) => value.Equals(default(Vertex));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Vertex value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Vertex value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Vertex value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Vertex(NilType nil) => default(Vertex);
        }

        [GeneratedCode("go2cs", "1.0.0.0")]
        public static Vertex Vertex_cast(dynamic value)
        {
            return new Vertex(value.X, value.Y);
        }
    }
}