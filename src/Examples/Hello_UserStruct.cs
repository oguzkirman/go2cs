//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2018 August 10 20:17:56 UTC
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
        [GeneratedCode("go2cs", "0.1.1.0")]
        public partial struct User : EmptyInterface
        {
            // Constructors
            public User(NilType _)
            {
                this.Id = default;
                this.Name = default;
            }

            public User(@int Id, @string Name)
            {
                this.Id = Id;
                this.Name = Name;
            }

            // Enable comparisons between nil and User struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(User value, NilType nil) => value.Equals(default(User));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(User value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, User value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, User value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator User(NilType nil) => default(User);
        }

        [GeneratedCode("go2cs", "0.1.1.0")]
        public static User User_cast(dynamic value)
        {
            return new User(value.Id, value.Name);
        }
    }
}