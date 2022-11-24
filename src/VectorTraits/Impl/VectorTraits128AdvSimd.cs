﻿using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.Text;

namespace Zyl.VectorTraits.Impl {
    using WStatics = WVectorTraits128AdvSimd.Statics;

    /// <summary>
    /// <see cref="Vector{T}"/> traits 128 - Avx2 .
    /// </summary>
    public sealed class VectorTraits128AdvSimd : VectorTraits128AdvSimdAbstract {
        private static readonly VectorTraits128AdvSimd _instance = new VectorTraits128AdvSimd(); // Default instance.

        /// <summary>Default instance. </summary>
        public static VectorTraits128AdvSimd Instance {
            get { return _instance; }
        }

#if NET5_0_OR_GREATER


#endif // NET5_0_OR_GREATER

        /// <summary>
        /// <see cref="Vector128{T}"/> traits.Statics - Avx2.
        /// </summary>
        public static class Statics {

            /// <inheritdoc cref="IBaseTraits.ByteCount"/>
            public static int ByteCount {
                get { return ByteCountValue; }
            }

            /// <inheritdoc cref="IBaseTraits.IsSupported"/>
            public static bool IsSupported {
                get {
                    return WStatics.IsSupported;
                }
            }

            /// <inheritdoc cref="IBaseTraits.ThrowForUnsupported"/>
            public static void ThrowForUnsupported() {
                WStatics.ThrowForUnsupported();
            }

#if NET5_0_OR_GREATER

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeft(Vector<short> value, int shiftCount) {
                Vector128<short> vtemp = WStatics.ShiftLeft(Vectors.AsVector128(value), shiftCount);
                return Vectors.AsVector(vtemp);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeft(Vector<int> value, int shiftCount) {
                Vector128<int> vtemp = WStatics.ShiftLeft(Vectors.AsVector128(value), shiftCount);
                return Vectors.AsVector(vtemp);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightArithmetic(Vector<int> value, int shiftCount) {
                Vector128<int> vtemp = WStatics.ShiftRightArithmetic(Vectors.AsVector128(value), shiftCount);
                return Vectors.AsVector(vtemp);
            }

#endif // NET5_0_OR_GREATER
        }

    }
}
