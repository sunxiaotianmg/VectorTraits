﻿using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.Text;
using Zyl.VectorTraits.Extensions;
using Zyl.VectorTraits.Impl.AVector256;

namespace Zyl.VectorTraits.Impl.AVector {
    using WStatics = WVectorTraits256Avx2.Statics;
    using BaseStatics = VectorTraitsBase.Statics;

    /// <summary>
    /// <see cref="Vector{T}"/> traits 256 - Avx2 .
    /// </summary>
    public sealed class VectorTraits256Avx2 : VectorTraits256Avx2Abstract {
        private static readonly VectorTraits256Avx2 _instance = new VectorTraits256Avx2(); // Default instance.

        /// <summary>Default instance. </summary>
        public static VectorTraits256Avx2 Instance {
            get { return _instance; }
        }

#if NETCOREAPP3_0_OR_GREATER


#endif // NETCOREAPP3_0_OR_GREATER

        /// <summary>
        /// <see cref="Vector256{T}"/> traits.Statics - Avx2.
        /// </summary>
        public static class Statics {

            /// <inheritdoc cref="IBaseTraits.ByteCount"/>
            public static int ByteCount {
                get { return ByteCountValue; }
            }

            /// <inheritdoc cref="IBaseTraits.IsSupported"/>
            public static bool IsSupported {
                get {
                    return GetIsSupported();
                }
            }

            /// <inheritdoc cref="IBaseTraits.GetIsSupported"/>
            public static bool GetIsSupported(bool noStrict = false) {
                bool rt = (Vector<byte>.Count == ByteCountValue) && WStatics.GetIsSupported(noStrict);
                return rt;
            }

            /// <inheritdoc cref="IBaseTraits.GetUnsupportedMessage"/>
            public static string GetUnsupportedMessage(bool noStrict = false) {
                string rt = WStatics.GetUnsupportedMessage(noStrict);
                VectorTraits256Abstract.GetUnsupportedMessage_VectorCount(ref rt);
                return rt;
            }

            /// <inheritdoc cref="IBaseTraits.ThrowForUnsupported"/>
            public static void ThrowForUnsupported(bool noStrict = false) {
                if (GetIsSupported(noStrict)) return;
                throw new NotSupportedException(GetUnsupportedMessage(noStrict));
            }

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IVectorTraits.Ceiling_AcceleratedTypes"/>
            public static TypeCodeFlags Ceiling_AcceleratedTypes {
                get {
                    return WStatics.Ceiling_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Ceiling(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> Ceiling(Vector<float> value) {
                return WStatics.Ceiling(value.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Ceiling(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> Ceiling(Vector<double> value) {
                return WStatics.Ceiling(value.AsVector256()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.ConvertToDouble_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToDouble_AcceleratedTypes {
                get {
                    return WStatics.ConvertToDouble_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.ConvertToDouble(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> ConvertToDouble(Vector<long> value) {
                return WStatics.ConvertToDouble(value.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ConvertToDouble(Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> ConvertToDouble(Vector<ulong> value) {
                return WStatics.ConvertToDouble(value.AsVector256()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.ConvertToSingle_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToSingle_AcceleratedTypes {
                get {
                    return WStatics.ConvertToSingle_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.ConvertToSingle(Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> ConvertToSingle(Vector<int> value) {
                return WStatics.ConvertToSingle(value.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ConvertToSingle(Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> ConvertToSingle(Vector<uint> value) {
                return WStatics.ConvertToSingle(value.AsVector256()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits_AcceleratedTypes"/>
            public static TypeCodeFlags ExtractMostSignificantBits_AcceleratedTypes {
                get {
                    return WStatics.ExtractMostSignificantBits_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{float})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector<float> vector) {
                return WStatics.ExtractMostSignificantBits(vector.AsVector256());
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector<double> vector) {
                return WStatics.ExtractMostSignificantBits(vector.AsVector256());
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector<sbyte> vector) {
                return WStatics.ExtractMostSignificantBits(vector.AsVector256());
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{byte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector<byte> vector) {
                return WStatics.ExtractMostSignificantBits(vector.AsVector256());
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector<short> vector) {
                return WStatics.ExtractMostSignificantBits(vector.AsVector256());
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector<ushort> vector) {
                return WStatics.ExtractMostSignificantBits(vector.AsVector256());
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{int})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector<int> vector) {
                return WStatics.ExtractMostSignificantBits(vector.AsVector256());
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector<uint> vector) {
                return WStatics.ExtractMostSignificantBits(vector.AsVector256());
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{long})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector<long> vector) {
                return WStatics.ExtractMostSignificantBits(vector.AsVector256());
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector<ulong> vector) {
                return WStatics.ExtractMostSignificantBits(vector.AsVector256());
            }


            /// <inheritdoc cref="IVectorTraits.Floor_AcceleratedTypes"/>
            public static TypeCodeFlags Floor_AcceleratedTypes {
                get {
                    return WStatics.Floor_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Floor(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> Floor(Vector<float> value) {
                return WStatics.Floor(value.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Floor(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> Floor(Vector<double> value) {
                return WStatics.Floor(value.AsVector256()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.Multiply_AcceleratedTypes"/>
            public static TypeCodeFlags Multiply_AcceleratedTypes {
                get {
                    return WStatics.Multiply_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Multiply_FullAcceleratedTypes"/>
            public static TypeCodeFlags Multiply_FullAcceleratedTypes {
                get {
                    return WStatics.Multiply_FullAcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Multiply(Vector{float}, Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> Multiply(Vector<float> left, Vector<float> right) {
                return BaseStatics.Multiply(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Multiply(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> Multiply(Vector<double> left, Vector<double> right) {
                return BaseStatics.Multiply(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Multiply(Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> Multiply(Vector<sbyte> left, Vector<sbyte> right) {
                return WStatics.Multiply(left.AsVector256(), right.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Multiply(Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> Multiply(Vector<byte> left, Vector<byte> right) {
                return WStatics.Multiply(left.AsVector256(), right.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Multiply(Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> Multiply(Vector<short> left, Vector<short> right) {
                return BaseStatics.Multiply(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Multiply(Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> Multiply(Vector<ushort> left, Vector<ushort> right) {
                return BaseStatics.Multiply(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Multiply(Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> Multiply(Vector<int> left, Vector<int> right) {
                return BaseStatics.Multiply(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Multiply(Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> Multiply(Vector<uint> left, Vector<uint> right) {
                return BaseStatics.Multiply(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Multiply(Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> Multiply(Vector<long> left, Vector<long> right) {
                return WStatics.Multiply(left.AsVector256(), right.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Multiply(Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> Multiply(Vector<ulong> left, Vector<ulong> right) {
                return WStatics.Multiply(left.AsVector256(), right.AsVector256()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.Narrow_AcceleratedTypes"/>
            public static TypeCodeFlags Narrow_AcceleratedTypes {
                get {
                    return WStatics.Narrow_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{double}, Vector{double})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> Narrow(Vector<double> lower, Vector<double> upper) {
                return WStatics.Narrow(lower.AsVector256(), upper.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{short}, Vector{short})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> Narrow(Vector<short> lower, Vector<short> upper) {
                return WStatics.Narrow(lower.AsVector256(), upper.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{ushort}, Vector{ushort})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> Narrow(Vector<ushort> lower, Vector<ushort> upper) {
                return WStatics.Narrow(lower.AsVector256(), upper.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{int}, Vector{int})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> Narrow(Vector<int> lower, Vector<int> upper) {
                return WStatics.Narrow(lower.AsVector256(), upper.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{uint}, Vector{uint})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> Narrow(Vector<uint> lower, Vector<uint> upper) {
                return WStatics.Narrow(lower.AsVector256(), upper.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{long}, Vector{long})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> Narrow(Vector<long> lower, Vector<long> upper) {
                return WStatics.Narrow(lower.AsVector256(), upper.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{ulong}, Vector{ulong})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> Narrow(Vector<ulong> lower, Vector<ulong> upper) {
                return WStatics.Narrow(lower.AsVector256(), upper.AsVector256()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.ShiftLeft_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftLeft_AcceleratedTypes {
                get {
                    return WStatics.ShiftLeft_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftLeft(Vector<sbyte> value, int shiftAmount) {
                return WStatics.ShiftLeft(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftLeft(Vector<byte> value, int shiftAmount) {
                return WStatics.ShiftLeft(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeft(Vector<short> value, int shiftAmount) {
                return WStatics.ShiftLeft(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftLeft(Vector<ushort> value, int shiftAmount) {
                return WStatics.ShiftLeft(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeft(Vector<int> value, int shiftAmount) {
                return WStatics.ShiftLeft(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftLeft(Vector<uint> value, int shiftAmount) {
                return WStatics.ShiftLeft(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftLeft(Vector<long> value, int shiftAmount) {
                return WStatics.ShiftLeft(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftLeft(Vector<ulong> value, int shiftAmount) {
                return WStatics.ShiftLeft(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftLeftFast(Vector<sbyte> value, int shiftAmount) {
                return WStatics.ShiftLeftFast(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{byte}, int)"/>
            [CLSCompliant(false)][MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftLeftFast(Vector<byte> value, int shiftAmount) {
                return WStatics.ShiftLeftFast(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeftFast(Vector<short> value, int shiftAmount) {
                return WStatics.ShiftLeftFast(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftLeftFast(Vector<ushort> value, int shiftAmount) {
                return WStatics.ShiftLeftFast(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeftFast(Vector<int> value, int shiftAmount) {
                return WStatics.ShiftLeftFast(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftLeftFast(Vector<uint> value, int shiftAmount) {
                return WStatics.ShiftLeftFast(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftLeftFast(Vector<long> value, int shiftAmount) {
                return WStatics.ShiftLeftFast(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftLeftFast(Vector<ulong> value, int shiftAmount) {
                return WStatics.ShiftLeftFast(value.AsVector256(), shiftAmount).AsVector();
            }



            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftRightArithmetic_AcceleratedTypes {
                get {
                    return WStatics.ShiftRightArithmetic_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightArithmetic(Vector<sbyte> value, int shiftAmount) {
                return WStatics.ShiftRightArithmetic(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightArithmetic(Vector<short> value, int shiftAmount) {
                return WStatics.ShiftRightArithmetic(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightArithmetic(Vector<int> value, int shiftAmount) {
                return WStatics.ShiftRightArithmetic(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightArithmetic(Vector<long> value, int shiftAmount) {
                return WStatics.ShiftRightArithmetic(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightArithmeticFast(Vector<sbyte> value, int shiftAmount) {
                return WStatics.ShiftRightArithmeticFast(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightArithmeticFast(Vector<short> value, int shiftAmount) {
                return WStatics.ShiftRightArithmeticFast(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightArithmeticFast(Vector<int> value, int shiftAmount) {
                return WStatics.ShiftRightArithmeticFast(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightArithmeticFast(Vector<long> value, int shiftAmount) {
                return WStatics.ShiftRightArithmeticFast(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightArithmeticFast_Widen(Vector<sbyte> value, int shiftAmount) {
                return WStatics.ShiftRightArithmeticFast_Widen(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightArithmeticFast_Negative(Vector<sbyte> value, int shiftAmount) {
                return WStatics.ShiftRightArithmeticFast_Negative(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightArithmeticFast_Narrow(Vector<long> value, int shiftAmount) {
                return WStatics.ShiftRightArithmeticFast_Narrow(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightArithmeticFast_NarrowIfLess(Vector<long> value, int shiftAmount) {
                return WStatics.ShiftRightArithmeticFast_NarrowIfLess(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightArithmeticFast_Negative(Vector<long> value, int shiftAmount) {
                return WStatics.ShiftRightArithmeticFast_Negative(value.AsVector256(), shiftAmount).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftRightLogical_AcceleratedTypes {
                get {
                    return WStatics.ShiftRightLogical_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightLogical(Vector<sbyte> value, int shiftAmount) {
                return WStatics.ShiftRightLogical(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftRightLogical(Vector<byte> value, int shiftAmount) {
                return WStatics.ShiftRightLogical(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightLogical(Vector<short> value, int shiftAmount) {
                return WStatics.ShiftRightLogical(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftRightLogical(Vector<ushort> value, int shiftAmount) {
                return WStatics.ShiftRightLogical(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightLogical(Vector<int> value, int shiftAmount) {
                return WStatics.ShiftRightLogical(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftRightLogical(Vector<uint> value, int shiftAmount) {
                return WStatics.ShiftRightLogical(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightLogical(Vector<long> value, int shiftAmount) {
                return WStatics.ShiftRightLogical(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftRightLogical(Vector<ulong> value, int shiftAmount) {
                return WStatics.ShiftRightLogical(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightLogicalFast(Vector<sbyte> value, int shiftAmount) {
                return WStatics.ShiftRightLogicalFast(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{byte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftRightLogicalFast(Vector<byte> value, int shiftAmount) {
                return WStatics.ShiftRightLogicalFast(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{byte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftRightLogicalFast_FirstAnd(Vector<byte> value, int shiftAmount) {
                return WStatics.ShiftRightLogicalFast_FirstAnd(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{byte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftRightLogicalFast_FirstShift(Vector<byte> value, int shiftAmount) {
                return WStatics.ShiftRightLogicalFast_FirstShift(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightLogicalFast(Vector<short> value, int shiftAmount) {
                return WStatics.ShiftRightLogicalFast(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftRightLogicalFast(Vector<ushort> value, int shiftAmount) {
                return WStatics.ShiftRightLogicalFast(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightLogicalFast(Vector<int> value, int shiftAmount) {
                return WStatics.ShiftRightLogicalFast(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftRightLogicalFast(Vector<uint> value, int shiftAmount) {
                return WStatics.ShiftRightLogicalFast(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightLogicalFast(Vector<long> value, int shiftAmount) {
                return WStatics.ShiftRightLogicalFast(value.AsVector256(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftRightLogicalFast(Vector<ulong> value, int shiftAmount) {
                return WStatics.ShiftRightLogicalFast(value.AsVector256(), shiftAmount).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.Shuffle_AcceleratedTypes"/>
            public static TypeCodeFlags Shuffle_AcceleratedTypes {
                get {
                    return WStatics.Shuffle_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> Shuffle(Vector<float> vector, Vector<int> indices) {
                return WStatics.Shuffle(vector.AsVector256(), indices.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> Shuffle(Vector<double> vector, Vector<long> indices) {
                return WStatics.Shuffle(vector.AsVector256(), indices.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> Shuffle(Vector<sbyte> vector, Vector<sbyte> indices) {
                return WStatics.Shuffle(vector.AsVector256(), indices.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> Shuffle(Vector<byte> vector, Vector<byte> indices) {
                return WStatics.Shuffle(vector.AsVector256(), indices.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> Shuffle(Vector<short> vector, Vector<short> indices) {
                return WStatics.Shuffle(vector.AsVector256(), indices.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> Shuffle(Vector<ushort> vector, Vector<ushort> indices) {
                return WStatics.Shuffle(vector.AsVector256(), indices.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> Shuffle(Vector<int> vector, Vector<int> indices) {
                return WStatics.Shuffle(vector.AsVector256(), indices.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> Shuffle(Vector<uint> vector, Vector<uint> indices) {
                return WStatics.Shuffle(vector.AsVector256(), indices.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> Shuffle(Vector<long> vector, Vector<long> indices) {
                return WStatics.Shuffle(vector.AsVector256(), indices.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> Shuffle(Vector<ulong> vector, Vector<ulong> indices) {
                return WStatics.Shuffle(vector.AsVector256(), indices.AsVector256()).AsVector();
            }


            /// <inheritdoc cref="IWVectorTraits.Sum_AcceleratedTypes"/>
            public static TypeCodeFlags Sum_AcceleratedTypes {
                get {
                    return WStatics.Sum_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits.Sum(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float Sum(Vector<float> value) {
                return WStatics.Sum(value.AsVector256());
            }

            /// <inheritdoc cref="IWVectorTraits.Sum(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static double Sum(Vector<double> value) {
                return WStatics.Sum(value.AsVector256());
            }

            /// <inheritdoc cref="IWVectorTraits.Sum(Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static sbyte Sum(Vector<sbyte> value) {
                return WStatics.Sum(value.AsVector256());
            }

            /// <inheritdoc cref="IWVectorTraits.Sum(Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static byte Sum(Vector<byte> value) {
                return WStatics.Sum(value.AsVector256());
            }

            /// <inheritdoc cref="IWVectorTraits.Sum(Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static short Sum(Vector<short> value) {
                return WStatics.Sum(value.AsVector256());
            }

            /// <inheritdoc cref="IWVectorTraits.Sum(Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ushort Sum(Vector<ushort> value) {
                return WStatics.Sum(value.AsVector256());
            }

            /// <inheritdoc cref="IWVectorTraits.Sum(Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static int Sum(Vector<int> value) {
                return WStatics.Sum(value.AsVector256());
            }

            /// <inheritdoc cref="IWVectorTraits.Sum(Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint Sum(Vector<uint> value) {
                return WStatics.Sum(value.AsVector256());
            }

            /// <inheritdoc cref="IWVectorTraits.Sum(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static long Sum(Vector<long> value) {
                return WStatics.Sum(value.AsVector256());
            }

            /// <inheritdoc cref="IWVectorTraits.Sum(Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong Sum(Vector<ulong> value) {
                return WStatics.Sum(value.AsVector256());
            }


            /// <inheritdoc cref="IVectorTraits.Widen_AcceleratedTypes"/>
            public static TypeCodeFlags Widen_AcceleratedTypes {
                get {
                    return WStatics.Widen_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{float}, out Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector<float> source, out Vector<double> lower, out Vector<double> upper) {
                WStatics.Widen(source.AsVector256(), out var a, out var b);
                lower = a.AsVector();
                upper = b.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{sbyte}, out Vector{short}, out Vector{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector<sbyte> source, out Vector<short> lower, out Vector<short> upper) {
                WStatics.Widen(source.AsVector256(), out var a, out var b);
                lower = a.AsVector();
                upper = b.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{byte}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector<byte> source, out Vector<ushort> lower, out Vector<ushort> upper) {
                WStatics.Widen(source.AsVector256(), out var a, out var b);
                lower = a.AsVector();
                upper = b.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{short}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector<short> source, out Vector<int> lower, out Vector<int> upper) {
                WStatics.Widen(source.AsVector256(), out var a, out var b);
                lower = a.AsVector();
                upper = b.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{ushort}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector<ushort> source, out Vector<uint> lower, out Vector<uint> upper) {
                WStatics.Widen(source.AsVector256(), out var a, out var b);
                lower = a.AsVector();
                upper = b.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{int}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector<int> source, out Vector<long> lower, out Vector<long> upper) {
                WStatics.Widen(source.AsVector256(), out var a, out var b);
                lower = a.AsVector();
                upper = b.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{uint}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector<uint> source, out Vector<ulong> lower, out Vector<ulong> upper) {
                WStatics.Widen(source.AsVector256(), out var a, out var b);
                lower = a.AsVector();
                upper = b.AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YNarrowSaturate_AcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturate_AcceleratedTypes {
                get {
                    return WStatics.YNarrowSaturate_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturate_FullAcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturate_FullAcceleratedTypes {
                get {
                    return WStatics.YNarrowSaturate_FullAcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{short}, Vector{short})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YNarrowSaturate(Vector<short> lower, Vector<short> upper) {
                return WStatics.YNarrowSaturate(lower.AsVector256(), upper.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{ushort}, Vector{ushort})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YNarrowSaturate(Vector<ushort> lower, Vector<ushort> upper) {
                return WStatics.YNarrowSaturate(lower.AsVector256(), upper.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{int}, Vector{int})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YNarrowSaturate(Vector<int> lower, Vector<int> upper) {
                return WStatics.YNarrowSaturate(lower.AsVector256(), upper.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{uint}, Vector{uint})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YNarrowSaturate(Vector<uint> lower, Vector<uint> upper) {
                return WStatics.YNarrowSaturate(lower.AsVector256(), upper.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{long}, Vector{long})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YNarrowSaturate(Vector<long> lower, Vector<long> upper) {
                return WStatics.YNarrowSaturate(lower.AsVector256(), upper.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{ulong}, Vector{ulong})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YNarrowSaturate(Vector<ulong> lower, Vector<ulong> upper) {
                return WStatics.YNarrowSaturate(lower.AsVector256(), upper.AsVector256()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned_AcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturateUnsigned_AcceleratedTypes {
                get {
                    return WStatics.YNarrowSaturateUnsigned_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned_FullAcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturateUnsigned_FullAcceleratedTypes {
                get {
                    return WStatics.YNarrowSaturateUnsigned_FullAcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned(Vector{short}, Vector{short})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YNarrowSaturateUnsigned(Vector<short> lower, Vector<short> upper) {
                return WStatics.YNarrowSaturateUnsigned(lower.AsVector256(), upper.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned(Vector{int}, Vector{int})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YNarrowSaturateUnsigned(Vector<int> lower, Vector<int> upper) {
                return WStatics.YNarrowSaturateUnsigned(lower.AsVector256(), upper.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned(Vector{long}, Vector{long})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YNarrowSaturateUnsigned(Vector<long> lower, Vector<long> upper) {
                return WStatics.YNarrowSaturateUnsigned(lower.AsVector256(), upper.AsVector256()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleInsert_AcceleratedTypes {
                get {
                    return WStatics.YShuffleInsert_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleInsert(Vector<float> back, Vector<float> vector, Vector<int> indices) {
                return WStatics.YShuffleInsert(back.AsVector256(), vector.AsVector256(), indices.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleInsert(Vector<double> back, Vector<double> vector, Vector<long> indices) {
                return WStatics.YShuffleInsert(back.AsVector256(), vector.AsVector256(), indices.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleInsert(Vector<sbyte> back, Vector<sbyte> vector, Vector<sbyte> indices) {
                return WStatics.YShuffleInsert(back.AsVector256(), vector.AsVector256(), indices.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleInsert(Vector<byte> back, Vector<byte> vector, Vector<byte> indices) {
                return WStatics.YShuffleInsert(back.AsVector256(), vector.AsVector256(), indices.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleInsert(Vector<short> back, Vector<short> vector, Vector<short> indices) {
                return WStatics.YShuffleInsert(back.AsVector256(), vector.AsVector256(), indices.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleInsert(Vector<ushort> back, Vector<ushort> vector, Vector<ushort> indices) {
                return WStatics.YShuffleInsert(back.AsVector256(), vector.AsVector256(), indices.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleInsert(Vector<int> back, Vector<int> vector, Vector<int> indices) {
                return WStatics.YShuffleInsert(back.AsVector256(), vector.AsVector256(), indices.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleInsert(Vector<uint> back, Vector<uint> vector, Vector<uint> indices) {
                return WStatics.YShuffleInsert(back.AsVector256(), vector.AsVector256(), indices.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleInsert(Vector<long> back, Vector<long> vector, Vector<long> indices) {
                return WStatics.YShuffleInsert(back.AsVector256(), vector.AsVector256(), indices.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleInsert(Vector<ulong> back, Vector<ulong> vector, Vector<ulong> indices) {
                return WStatics.YShuffleInsert(back.AsVector256(), vector.AsVector256(), indices.AsVector256()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleKernel_AcceleratedTypes {
                get {
                    return WStatics.YShuffleKernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleKernel(Vector<float> vector, Vector<int> indices) {
                return WStatics.YShuffleKernel(vector.AsVector256(), indices.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleKernel(Vector<double> vector, Vector<long> indices) {
                return WStatics.YShuffleKernel(vector.AsVector256(), indices.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleKernel(Vector<sbyte> vector, Vector<sbyte> indices) {
                return WStatics.YShuffleKernel(vector.AsVector256(), indices.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleKernel(Vector<byte> vector, Vector<byte> indices) {
                return WStatics.YShuffleKernel(vector.AsVector256(), indices.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleKernel(Vector<short> vector, Vector<short> indices) {
                return WStatics.YShuffleKernel(vector.AsVector256(), indices.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleKernel(Vector<ushort> vector, Vector<ushort> indices) {
                return WStatics.YShuffleKernel(vector.AsVector256(), indices.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleKernel(Vector<int> vector, Vector<int> indices) {
                return WStatics.YShuffleKernel(vector.AsVector256(), indices.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleKernel(Vector<uint> vector, Vector<uint> indices) {
                return WStatics.YShuffleKernel(vector.AsVector256(), indices.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleKernel(Vector<long> vector, Vector<long> indices) {
                return WStatics.YShuffleKernel(vector.AsVector256(), indices.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleKernel(Vector<ulong> vector, Vector<ulong> indices) {
                return WStatics.YShuffleKernel(vector.AsVector256(), indices.AsVector256()).AsVector();
            }


#endif // NETCOREAPP3_0_OR_GREATER
        }

    }
}
