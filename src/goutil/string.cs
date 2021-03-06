﻿//******************************************************************************************************
//  string.cs - Gbtc
//
//  Copyright © 2018, Grid Protection Alliance.  All Rights Reserved.
//
//  Licensed to the Grid Protection Alliance (GPA) under one or more contributor license agreements. See
//  the NOTICE file distributed with this work for additional information regarding copyright ownership.
//  The GPA licenses this file to you under the MIT License (MIT), the "License"; you may not use this
//  file except in compliance with the License. You may obtain a copy of the License at:
//
//      http://opensource.org/licenses/MIT
//
//  Unless agreed to in writing, the subject software distributed under the License is distributed on an
//  "AS-IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. Refer to the
//  License for the specific language governing permissions and limitations.
//
//  Code Modification History:
//  ----------------------------------------------------------------------------------------------------
//  06/28/2018 - J. Ritchie Carroll
//       Generated original version of source code.
//
//******************************************************************************************************
// ReSharper disable CheckNamespace
// ReSharper disable SpecifyACultureInStringConversionExplicitly

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace go
{
    /// <summary>
    /// Represents a structure that behaves like a Go string.
    /// </summary>
    public readonly struct @string : EmptyInterface, IReadOnlyList<@byte>, IEnumerable<rune>, IEnumerable<(int index, rune rune)>, IEnumerable<byte>, IEnumerable<char>, IConvertible, ICloneable
    {
        private readonly byte[] m_value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public @string(@byte[] value)
        {
            if ((object)value == null)
            {
                m_value = new byte[0];
            }
            else
            {
                m_value = new byte[value.Length];
                Array.Copy(value, m_value, value.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public @string(byte[] value)
        {
            if ((object)value == null)
            {
                m_value = new byte[0];
            }
            else
            {
                m_value = new byte[value.Length];
                Array.Copy(value, m_value, value.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public @string(char[] value) : this(new string(value)) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public @string(rune[] value) : this(new string(value.Select(item => (char)item).ToArray())) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public @string(slice<@byte> value) : this(value.ToArray()) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public @string(slice<byte> value) : this(value.ToArray()) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public @string(slice<char> value) : this(value.ToArray()) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public @string(slice<rune> value) : this(value.ToArray()) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public @string(string value) => m_value = Encoding.UTF8.GetBytes(value ?? "");

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public @string(@string value) : this(value.m_value) { }
        
        private byte[] Value
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => m_value ?? new byte[0];
        }

        public int Length
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Value.Length;
        }

        public @byte this[int index] => Value[index];

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => Encoding.UTF8.GetString(Value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(@string other) => BytesAreEqual(Value, other.Value);

        public override bool Equals(object obj)
        {
            switch (obj)
            {
                case null:
                    return false;
                case @string gostr:
                    return Equals(gostr);
                case string str:
                    return Equals(str);
            }

            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => ToString().GetHashCode();

        public string ToString(IFormatProvider provider) => ToString().ToString(provider);

        public TypeCode GetTypeCode() => TypeCode.String;

        public @string Clone() => new @string(this);

        object ICloneable.Clone() => Clone();

        int IReadOnlyCollection<@byte>.Count => Length;

        bool IConvertible.ToBoolean(IFormatProvider provider) => ((IConvertible)ToString()).ToBoolean(provider);

        char IConvertible.ToChar(IFormatProvider provider) => ((IConvertible)ToString()).ToChar(provider);

        sbyte IConvertible.ToSByte(IFormatProvider provider) => ((IConvertible)ToString()).ToSByte(provider);

        byte IConvertible.ToByte(IFormatProvider provider) => ((IConvertible)ToString()).ToByte(provider);

        short IConvertible.ToInt16(IFormatProvider provider) => ((IConvertible)ToString()).ToInt16(provider);

        ushort IConvertible.ToUInt16(IFormatProvider provider) => ((IConvertible)ToString()).ToUInt16(provider);

        int IConvertible.ToInt32(IFormatProvider provider) => ((IConvertible)ToString()).ToInt32(provider);

        uint IConvertible.ToUInt32(IFormatProvider provider) => ((IConvertible)ToString()).ToUInt32(provider);

        long IConvertible.ToInt64(IFormatProvider provider) => ((IConvertible)ToString()).ToInt64(provider);

        ulong IConvertible.ToUInt64(IFormatProvider provider) => ((IConvertible)ToString()).ToUInt64(provider);

        float IConvertible.ToSingle(IFormatProvider provider) => ((IConvertible)ToString()).ToSingle(provider);

        double IConvertible.ToDouble(IFormatProvider provider) => ((IConvertible)ToString()).ToDouble(provider);

        decimal IConvertible.ToDecimal(IFormatProvider provider) => ((IConvertible)ToString()).ToDecimal(provider);

        DateTime IConvertible.ToDateTime(IFormatProvider provider) => ((IConvertible)ToString()).ToDateTime(provider);

        object IConvertible.ToType(Type conversionType, IFormatProvider provider) => ((IConvertible)ToString()).ToType(conversionType, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        IEnumerator IEnumerable.GetEnumerator() => Value.GetEnumerator();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        IEnumerator<byte> IEnumerable<byte>.GetEnumerator() => ((IEnumerable<byte>)Value).GetEnumerator();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        IEnumerator<@byte> IEnumerable<@byte>.GetEnumerator()
        {
            foreach (byte item in Value)
                yield return item;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        IEnumerator<rune> IEnumerable<rune>.GetEnumerator()
        {
            foreach (char item in ToString())
                yield return item;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        IEnumerator<char> IEnumerable<char>.GetEnumerator() => ToString().GetEnumerator();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public IEnumerator<(int index, rune rune)> GetEnumerator()
        {
            Decoder decoder = Encoding.UTF8.GetDecoder();
            byte[] value = Value;
            char[] rune = new char[1];
            int byteCount;

            for (int index = 0; index < value.Length; index += byteCount)
            {
                byteCount = 1;
                bool completed = Decode(decoder, value, index, byteCount, rune);

                if (!completed)
                {
                    byteCount = 2;
                    completed = Decode(decoder, value, index, byteCount, rune);
                }

                if (completed)
                    yield return (index, rune[0]);
                else
                    yield return (index, '\uFFFD');
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private unsafe bool Decode(Decoder decoder, byte[] value, int index, int byteCount, char[] rune)
        {
            bool completed;

            fixed (byte* bytes = &value[index])
            fixed (char* chars = rune)
            {
                decoder.Convert(bytes, byteCount, chars, 1, true, out _, out _, out completed);
            }

            return completed;
        }

        public static @string Default { get; } = new @string("");

        // Enable implicit conversions between string and @string struct
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator @string(string value) => new @string(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator string(@string value) => value.ToString();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator @string(slice<byte> value) => new @string(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator slice<byte>(@string value) => new slice<byte>(value.m_value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator @string(slice<@byte> value) => new @string(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator slice<@byte>(@string value) => new slice<@byte>(value.m_value.Select(item => (@byte)item).ToArray());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator @string(slice<rune> value) => new @string(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator slice<rune>(@string value) =>  new slice<rune>(((IEnumerable<rune>)value).ToArray());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator @string(slice<char> value) => new @string(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator slice<char>(@string value) => new slice<char>(((IEnumerable<char>)value).ToArray());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte[](@string value) => value.m_value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator @string(byte[] value) => new @string(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator @byte[](@string value) => value.m_value.Select(item => (@byte)item).ToArray();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator @string(@byte[] value) => new @string(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator rune[](@string value) => ((IEnumerable<rune>)value).ToArray();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator @string(rune[] value) => new @string(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator char[](@string value) => ((IEnumerable<char>)value).ToArray();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator @string(char[] value) => new @string(value);

        // Enable comparisons between nil and @string struct
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(@string value, NilType nil) => value.Equals(default);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(@string value, NilType nil) => !(value == nil);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(NilType nil, @string value) => value == nil;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(NilType nil, @string value) => value != nil;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator @string(NilType nil) => Default;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool BytesAreEqual(byte[] data1, byte[] data2)
        {
            if (data1 == data2)
                return true;

            if (data1.Length != data2.Length)
                return false;

            if (data1.Length == 0)
                return true;

            fixed (byte* bytes1 = data1, bytes2 = data2)
            {
                int len = data1.Length;
                int rem = len % (sizeof(long) * 16);
                long* b1 = (long*)bytes1;
                long* b2 = (long*)bytes2;
                long* e1 = (long*)(bytes1 + len - rem);

                while (b1 < e1)
                {
                    if (*(b1) != *(b2) || *(b1 + 1) != *(b2 + 1) ||
                        *(b1 + 2) != *(b2 + 2) || *(b1 + 3) != *(b2 + 3) ||
                        *(b1 + 4) != *(b2 + 4) || *(b1 + 5) != *(b2 + 5) ||
                        *(b1 + 6) != *(b2 + 6) || *(b1 + 7) != *(b2 + 7) ||
                        *(b1 + 8) != *(b2 + 8) || *(b1 + 9) != *(b2 + 9) ||
                        *(b1 + 10) != *(b2 + 10) || *(b1 + 11) != *(b2 + 11) ||
                        *(b1 + 12) != *(b2 + 12) || *(b1 + 13) != *(b2 + 13) ||
                        *(b1 + 14) != *(b2 + 14) || *(b1 + 15) != *(b2 + 15))
                        return false;
                    b1 += 16;
                    b2 += 16;
                }

                for (int i = 0; i < rem; i++)
                    if (data1[len - 1 - i] != data2[len - 1 - i])
                        return false;

                return true;
            }
        }
    }
}