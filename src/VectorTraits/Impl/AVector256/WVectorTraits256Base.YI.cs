﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Collections;
using Zyl.VectorTraits.Impl.Util;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits.Impl.AVector256 {
    partial class WVectorTraits256Base {

        partial class Statics {

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YIsAllTrue_AcceleratedTypes"/>
            public static TypeCodeFlags YIsAllTrue_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsAllTrue{T}(Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAllTrue<T>(Vector256<T> value) where T : struct {
#if NET7_0_OR_GREATER
                return YIsAllTrue_Bcl(value);
#else
                return YIsAllTrue_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsAllTrue{T}(Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAllTrue_Basic<T>(Vector256<T> value) where T : struct {
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<T>, FixedArray4<long>>(ref value);
                long total = p.I0 & p.I1 & p.I2 & p.I3;
                return -1 == total;
            }

#if NET7_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits256.YIsAllTrue{T}(Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAllTrue_Bcl<T>(Vector256<T> value) where T : struct {
                Vector256<int> allBitsSet = Vector256<int>.AllBitsSet;
                return Vector256.EqualsAll(value.AsInt32(), allBitsSet);
            }
#endif // NET7_0_OR_GREATER


            /// <inheritdoc cref="IWVectorTraits256.YIsAnyTrue_AcceleratedTypes"/>
            public static TypeCodeFlags YIsAnyTrue_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsAnyTrue{T}(Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAnyTrue<T>(Vector256<T> value) where T : struct {
#if NET7_0_OR_GREATER
                return YIsAnyTrue_Bcl(value);
#else
                return YIsAnyTrue_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsAnyTrue{T}(Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAnyTrue_Basic<T>(Vector256<T> value) where T : struct {
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<T>, FixedArray4<long>>(ref value);
                long total = p.I0 | p.I1 | p.I2 | p.I3;
                return 0 != total;
            }

#if NET7_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits256.YIsAnyTrue{T}(Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAnyTrue_Bcl<T>(Vector256<T> value) where T : struct {
                Vector256<byte> allBitsSet = Vector256<byte>.AllBitsSet; // Must use byte.
                return Vector256.EqualsAny(value.AsByte(), allBitsSet);
            }
#endif // NET7_0_OR_GREATER


            /// <inheritdoc cref="IWVectorTraits256.YIsFinite_AcceleratedTypes"/>
            public static TypeCodeFlags YIsFinite_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if NET7_0_OR_GREATER
                    rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
#endif // NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsFinite(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsFinite(Vector256<float> value) {
#if NET7_0_OR_GREATER
                return YIsFinite_Bit(value);
#else
                return YIsFinite_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsFinite(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsFinite(Vector256<double> value) {
#if NET7_0_OR_GREATER
                return YIsFinite_Bit(value);
#else
                return YIsFinite_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsFinite(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsFinite_Basic(Vector256<float> value) {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<float> pvalue = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref value);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsFinite(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsFinite(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsFinite(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsFinite(pvalue.I3));
                p.I4 = BitMathCore.ToInt32Mask(MathINumberBase.IsFinite(pvalue.I4));
                p.I5 = BitMathCore.ToInt32Mask(MathINumberBase.IsFinite(pvalue.I5));
                p.I6 = BitMathCore.ToInt32Mask(MathINumberBase.IsFinite(pvalue.I6));
                p.I7 = BitMathCore.ToInt32Mask(MathINumberBase.IsFinite(pvalue.I7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsFinite(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsFinite_Basic(Vector256<double> value) {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<double> pvalue = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref value);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsFinite(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsFinite(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsFinite(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsFinite(pvalue.I3));
                return rt;
            }

#if NET7_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits256.YIsFinite(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsFinite_Bit(Vector256<float> value) {
                Vector256<int> exponentMask = Vector256Constants.Single_ExponentMask.AsInt32();
                Vector256<int> exponent = Vector256.BitwiseAnd(value.AsInt32(), exponentMask);
                Vector256<int> rt = Vector256.OnesComplement(Vector256.Equals(exponent, exponentMask));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsFinite(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsFinite_Bit(Vector256<double> value) {
                Vector256<long> exponentMask = Vector256Constants.Double_ExponentMask.AsInt64();
                Vector256<long> exponent = Vector256.BitwiseAnd(value.AsInt64(), exponentMask);
                Vector256<long> rt = Vector256.OnesComplement(Vector256.Equals(exponent, exponentMask));
                return rt;
            }
#endif // NET7_0_OR_GREATER


            /// <inheritdoc cref="IWVectorTraits256.YIsInfinity_AcceleratedTypes"/>
            public static TypeCodeFlags YIsInfinity_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if NET7_0_OR_GREATER
                    rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
#endif // NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInfinity(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsInfinity(Vector256<float> value) {
#if NET7_0_OR_GREATER
                return YIsInfinity_Bit(value);
#else
                return YIsInfinity_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInfinity(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsInfinity(Vector256<double> value) {
#if NET7_0_OR_GREATER
                return YIsInfinity_Bit(value);
#else
                return YIsInfinity_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInfinity(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsInfinity_Basic(Vector256<float> value) {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<float> pvalue = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref value);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinity(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinity(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinity(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinity(pvalue.I3));
                p.I4 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinity(pvalue.I4));
                p.I5 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinity(pvalue.I5));
                p.I6 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinity(pvalue.I6));
                p.I7 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinity(pvalue.I7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInfinity(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsInfinity_Basic(Vector256<double> value) {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<double> pvalue = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref value);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinity(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinity(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinity(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinity(pvalue.I3));
                return rt;
            }

#if NET7_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits256.YIsInfinity(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsInfinity_Bit(Vector256<float> value) {
                Vector256<int> nonSignMask = Vector256Constants.Single_NonSignMask.AsInt32();
                Vector256<int> exponentMask = Vector256Constants.Single_ExponentMask.AsInt32();
                Vector256<int> nonSign = Vector256.BitwiseAnd(value.AsInt32(), nonSignMask);
                Vector256<int> rt = Vector256.Equals(nonSign, exponentMask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInfinity(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsInfinity_Bit(Vector256<double> value) {
                Vector256<long> nonSignMask = Vector256Constants.Double_NonSignMask.AsInt64();
                Vector256<long> exponentMask = Vector256Constants.Double_ExponentMask.AsInt64();
                Vector256<long> nonSign = Vector256.BitwiseAnd(value.AsInt64(), nonSignMask);
                Vector256<long> rt = Vector256.Equals(nonSign, exponentMask);
                return rt;
            }
#endif // NET7_0_OR_GREATER


            /// <inheritdoc cref="IWVectorTraits256.YIsInfinityOrNaN_AcceleratedTypes"/>
            public static TypeCodeFlags YIsInfinityOrNaN_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if NET7_0_OR_GREATER
                    rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
#endif // NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInfinityOrNaN(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsInfinityOrNaN(Vector256<float> value) {
#if NET7_0_OR_GREATER
                return YIsInfinityOrNaN_Bit(value);
#else
                return YIsInfinityOrNaN_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInfinityOrNaN(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsInfinityOrNaN(Vector256<double> value) {
#if NET7_0_OR_GREATER
                return YIsInfinityOrNaN_Bit(value);
#else
                return YIsInfinityOrNaN_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInfinityOrNaN(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsInfinityOrNaN_Basic(Vector256<float> value) {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<float> pvalue = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref value);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinityOrNaN(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinityOrNaN(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinityOrNaN(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinityOrNaN(pvalue.I3));
                p.I4 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinityOrNaN(pvalue.I4));
                p.I5 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinityOrNaN(pvalue.I5));
                p.I6 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinityOrNaN(pvalue.I6));
                p.I7 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinityOrNaN(pvalue.I7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInfinityOrNaN(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsInfinityOrNaN_Basic(Vector256<double> value) {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<double> pvalue = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref value);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinityOrNaN(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinityOrNaN(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinityOrNaN(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinityOrNaN(pvalue.I3));
                return rt;
            }

#if NET7_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits256.YIsInfinityOrNaN(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsInfinityOrNaN_Bit(Vector256<float> value) {
                Vector256<int> exponentMask = Vector256Constants.Single_ExponentMask.AsInt32();
                Vector256<int> exponent = Vector256.BitwiseAnd(value.AsInt32(), exponentMask);
                Vector256<int> rt = Vector256.Equals(exponent, exponentMask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInfinityOrNaN(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsInfinityOrNaN_Bit(Vector256<double> value) {
                Vector256<long> exponentMask = Vector256Constants.Double_ExponentMask.AsInt64();
                Vector256<long> exponent = Vector256.BitwiseAnd(value.AsInt64(), exponentMask);
                Vector256<long> rt = Vector256.Equals(exponent, exponentMask);
                return rt;
            }
#endif // NET7_0_OR_GREATER


            /// <inheritdoc cref="IWVectorTraits256.YIsInteger_AcceleratedTypes"/>
            public static TypeCodeFlags YIsInteger_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if NET7_0_OR_GREATER
                    rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
#endif // NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInteger(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsInteger(Vector256<float> value) {
#if NET7_0_OR_GREATER
                return YIsInteger_Bit(value);
#else
                return YIsInteger_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInteger(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsInteger(Vector256<double> value) {
#if NET7_0_OR_GREATER
                return YIsInteger_Bit(value);
#else
                return YIsInteger_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInteger(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsInteger_Basic(Vector256<float> value) {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<float> pvalue = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref value);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsInteger(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsInteger(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsInteger(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsInteger(pvalue.I3));
                p.I4 = BitMathCore.ToInt32Mask(MathINumberBase.IsInteger(pvalue.I4));
                p.I5 = BitMathCore.ToInt32Mask(MathINumberBase.IsInteger(pvalue.I5));
                p.I6 = BitMathCore.ToInt32Mask(MathINumberBase.IsInteger(pvalue.I6));
                p.I7 = BitMathCore.ToInt32Mask(MathINumberBase.IsInteger(pvalue.I7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInteger(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsInteger_Basic(Vector256<double> value) {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<double> pvalue = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref value);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsInteger(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsInteger(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsInteger(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsInteger(pvalue.I3));
                return rt;
            }

#if NET7_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits256.YIsInteger(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsInteger_Bit(Vector256<float> value) {
                Vector256<float> valueTrun = Vector256.Floor(value);
                Vector256<int> maskFinite = YIsFinite(value);
                Vector256<int> maskEquals = Equals(value, valueTrun).AsInt32();
                Vector256<int> rt = Vector256.BitwiseAnd(maskFinite, maskEquals);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInteger(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsInteger_Bit(Vector256<double> value) {
                Vector256<double> valueTrun = Vector256.Floor(value);
                Vector256<long> maskFinite = YIsFinite(value);
                Vector256<long> maskEquals = Equals(value, valueTrun).AsInt64();
                Vector256<long> rt = Vector256.BitwiseAnd(maskFinite, maskEquals);
                return rt;
            }
#endif // NET7_0_OR_GREATER


            /// <inheritdoc cref="IWVectorTraits256.YIsNaN_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNaN_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if NET7_0_OR_GREATER
                    rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
#endif // NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNaN(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNaN(Vector256<float> value) {
#if NET7_0_OR_GREATER
                return YIsNaN_Bit(value);
#else
                return YIsNaN_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNaN(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNaN(Vector256<double> value) {
#if NET7_0_OR_GREATER
                return YIsNaN_Bit(value);
#else
                return YIsNaN_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNaN(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNaN_Basic(Vector256<float> value) {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<float> pvalue = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref value);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNaN(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNaN(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsNaN(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsNaN(pvalue.I3));
                p.I4 = BitMathCore.ToInt32Mask(MathINumberBase.IsNaN(pvalue.I4));
                p.I5 = BitMathCore.ToInt32Mask(MathINumberBase.IsNaN(pvalue.I5));
                p.I6 = BitMathCore.ToInt32Mask(MathINumberBase.IsNaN(pvalue.I6));
                p.I7 = BitMathCore.ToInt32Mask(MathINumberBase.IsNaN(pvalue.I7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNaN(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNaN_Basic(Vector256<double> value) {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<double> pvalue = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref value);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNaN(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNaN(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsNaN(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsNaN(pvalue.I3));
                return rt;
            }

#if NET7_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits256.YIsNaN(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNaN_Bit(Vector256<float> value) {
#pragma warning disable CS1718 // Comparison made to same variable; did you mean to compare something else?
                Vector256<int> rt = Vector256.OnesComplement(Vector256.Equals(value, value).AsInt32());
#pragma warning restore CS1718 // Comparison made to same variable; did you mean to compare something else?
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNaN(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNaN_Bit(Vector256<double> value) {
#pragma warning disable CS1718 // Comparison made to same variable; did you mean to compare something else?
                Vector256<long> rt = Vector256.OnesComplement(Vector256.Equals(value, value).AsInt64());
#pragma warning restore CS1718 // Comparison made to same variable; did you mean to compare something else?
                return rt;
            }
#endif // NET7_0_OR_GREATER


            /// <inheritdoc cref="IWVectorTraits256.YIsNegative_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNegative_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if NET7_0_OR_GREATER
                    rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
#endif // NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNegative(Vector256<float> value) {
#if NET7_0_OR_GREATER
                return YIsNegative_Bit(value);
#else
                return YIsNegative_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNegative(Vector256<double> value) {
#if NET7_0_OR_GREATER
                return YIsNegative_Bit(value);
#else
                return YIsNegative_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YIsNegative(Vector256<sbyte> value) {
#if NET7_0_OR_GREATER
                return YIsNegative_Bit(value);
#else
                return YIsNegative_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YIsNegative(Vector256<short> value) {
#if NET7_0_OR_GREATER
                return YIsNegative_Bit(value);
#else
                return YIsNegative_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNegative(Vector256<int> value) {
#if NET7_0_OR_GREATER
                return YIsNegative_Bit(value);
#else
                return YIsNegative_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNegative(Vector256<long> value) {
#if NET7_0_OR_GREATER
                return YIsNegative_Bit(value);
#else
                return YIsNegative_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNegative_Basic(Vector256<float> value) {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<float> pvalue = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref value);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I3));
                p.I4 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I4));
                p.I5 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I5));
                p.I6 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I6));
                p.I7 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNegative_Basic(Vector256<double> value) {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<double> pvalue = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref value);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I3));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YIsNegative_Basic(Vector256<sbyte> value) {
                UnsafeUtil.SkipInit(out Vector256<sbyte> rt);
                ref FixedArray32<sbyte> pvalue = ref Unsafe.As<Vector256<sbyte>, FixedArray32<sbyte>>(ref value);
                ref FixedArray32<sbyte> p = ref Unsafe.As<Vector256<sbyte>, FixedArray32<sbyte>>(ref rt);
                p.I0 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I0));
                p.I1 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I1));
                p.I2 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I2));
                p.I3 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I3));
                p.I4 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I4));
                p.I5 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I5));
                p.I6 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I6));
                p.I7 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I7));
                p.I8 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I8));
                p.I9 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I9));
                p.I10 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I10));
                p.I11 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I11));
                p.I12 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I12));
                p.I13 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I13));
                p.I14 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I14));
                p.I15 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I15));
                p.I16 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I16));
                p.I17 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I17));
                p.I18 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I18));
                p.I19 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I19));
                p.I20 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I20));
                p.I21 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I21));
                p.I22 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I22));
                p.I23 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I23));
                p.I24 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I24));
                p.I25 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I25));
                p.I26 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I26));
                p.I27 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I27));
                p.I28 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I28));
                p.I29 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I29));
                p.I30 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I30));
                p.I31 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I31));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YIsNegative_Basic(Vector256<short> value) {
                UnsafeUtil.SkipInit(out Vector256<short> rt);
                ref FixedArray16<short> pvalue = ref Unsafe.As<Vector256<short>, FixedArray16<short>>(ref value);
                ref FixedArray16<short> p = ref Unsafe.As<Vector256<short>, FixedArray16<short>>(ref rt);
                p.I0 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I0));
                p.I1 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I1));
                p.I2 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I2));
                p.I3 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I3));
                p.I4 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I4));
                p.I5 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I5));
                p.I6 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I6));
                p.I7 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I7));
                p.I8 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I8));
                p.I9 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I9));
                p.I10 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I10));
                p.I11 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I11));
                p.I12 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I12));
                p.I13 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I13));
                p.I14 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I14));
                p.I15 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I15));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNegative_Basic(Vector256<int> value) {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<int> pvalue = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref value);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I3));
                p.I4 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I4));
                p.I5 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I5));
                p.I6 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I6));
                p.I7 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNegative_Basic(Vector256<long> value) {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<long> pvalue = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref value);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I3));
                return rt;
            }
#if NET7_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNegative_Bit(Vector256<float> value) {
                return YIsNegative_Bit(value.AsInt32());
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNegative_Bit(Vector256<double> value) {
                return YIsNegative_Bit(value.AsInt64());
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YIsNegative_Bit(Vector256<sbyte> value) {
                Vector256<sbyte> rt = Vector256.LessThan(value, Vector256<sbyte>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YIsNegative_Bit(Vector256<short> value) {
                Vector256<short> rt = Vector256.LessThan(value, Vector256<short>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNegative_Bit(Vector256<int> value) {
                Vector256<int> rt = Vector256.LessThan(value, Vector256<int>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNegative_Bit(Vector256<long> value) {
                Vector256<long> rt = Vector256.LessThan(value, Vector256<long>.Zero);
                return rt;
            }
#endif // NET7_0_OR_GREATER


            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeInfinity_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNegativeInfinity_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if NET7_0_OR_GREATER
                    rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
#endif // NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeInfinity(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNegativeInfinity(Vector256<float> value) {
#if NET7_0_OR_GREATER
                return YIsNegativeInfinity_Bit(value);
#else
                return YIsNegativeInfinity_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeInfinity(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNegativeInfinity(Vector256<double> value) {
#if NET7_0_OR_GREATER
                return YIsNegativeInfinity_Bit(value);
#else
                return YIsNegativeInfinity_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeInfinity(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNegativeInfinity_Basic(Vector256<float> value) {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<float> pvalue = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref value);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeInfinity(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeInfinity(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeInfinity(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeInfinity(pvalue.I3));
                p.I4 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeInfinity(pvalue.I4));
                p.I5 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeInfinity(pvalue.I5));
                p.I6 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeInfinity(pvalue.I6));
                p.I7 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeInfinity(pvalue.I7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeInfinity(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNegativeInfinity_Basic(Vector256<double> value) {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<double> pvalue = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref value);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeInfinity(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeInfinity(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeInfinity(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeInfinity(pvalue.I3));
                return rt;
            }

#if NET7_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeInfinity(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNegativeInfinity_Bit(Vector256<float> value) {
                Vector256<float> sample = Vector256.Create(float.NegativeInfinity);
                Vector256<int> rt = Vector256.Equals(value, sample).AsInt32();
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeInfinity(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNegativeInfinity_Bit(Vector256<double> value) {
                Vector256<double> sample = Vector256.Create(double.NegativeInfinity);
                Vector256<long> rt = Vector256.Equals(value, sample).AsInt64();
                return rt;
            }
#endif // NET7_0_OR_GREATER


            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeZero_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNegativeZero_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if NET7_0_OR_GREATER
                    rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
#endif // NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeZero(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNegativeZero(Vector256<float> value) {
#if NET7_0_OR_GREATER
                return YIsNegativeZero_Bit(value);
#else
                return YIsNegativeZero_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeZero(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNegativeZero(Vector256<double> value) {
#if NET7_0_OR_GREATER
                return YIsNegativeZero_Bit(value);
#else
                return YIsNegativeZero_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeZero(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNegativeZero_Basic(Vector256<float> value) {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<float> pvalue = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref value);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeZero(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeZero(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeZero(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeZero(pvalue.I3));
                p.I4 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeZero(pvalue.I4));
                p.I5 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeZero(pvalue.I5));
                p.I6 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeZero(pvalue.I6));
                p.I7 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeZero(pvalue.I7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeZero(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNegativeZero_Basic(Vector256<double> value) {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<double> pvalue = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref value);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeZero(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeZero(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeZero(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeZero(pvalue.I3));
                return rt;
            }

#if NET7_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeZero(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNegativeZero_Bit(Vector256<float> value) {
                Vector256<int> signMask = Vector256Constants.Single_SignMask.AsInt32();
                Vector256<int> rt = Vector256.Equals(value.AsInt32(), signMask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeZero(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNegativeZero_Bit(Vector256<double> value) {
                Vector256<long> signMask = Vector256Constants.Double_SignMask.AsInt64();
                Vector256<long> rt = Vector256.Equals(value.AsInt64(), signMask);
                return rt;
            }
#endif // NET7_0_OR_GREATER

#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
