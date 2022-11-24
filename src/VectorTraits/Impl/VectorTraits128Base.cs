﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using System.Numerics;

namespace Zyl.VectorTraits.Impl {

    /// <summary>
    /// <see cref="Vector{T}"/> traits 128 - base.
    /// </summary>
    public sealed class VectorTraits128Base : VectorTraits128Abstract {
        private static readonly VectorTraits128Base _instance = new VectorTraits128Base(); // Default instance.

        /// <summary>Default instance. </summary>
        public static VectorTraits128Base Instance {
            get { return _instance; }
        }

        /// <summary>
        /// <see cref="Vector{T}"/> traits.Statics 128 - base.
        /// </summary>
        public static class Statics {

            /// <inheritdoc cref="IBaseTraits.ByteCount"/>
            public static int ByteCount {
                get { return ByteCountValue; }
            }

            /// <inheritdoc cref="IBaseTraits.IsSupported"/>
            public static bool IsSupported {
                get {
                    return Vector<byte>.Count == ByteCountValue;
                }
            }

            /// <inheritdoc cref="IBaseTraits.ThrowForUnsupported"/>
            public static void ThrowForUnsupported() {
                if (IsSupported) return;
                throw new NotSupportedException(string.Format("Vector count mismatch({0}!={1}) !", Vector<byte>.Count, ByteCountValue));
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{Int16}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<Int16> ShiftLeft(Vector<Int16> value, int shiftCount) {
                Vector<Int16> rt = value;
                Int16* p = (Int16*)&rt;
                p[0] <<= shiftCount;
                p[1] <<= shiftCount;
                p[2] <<= shiftCount;
                p[3] <<= shiftCount;
                p[4] <<= shiftCount;
                p[5] <<= shiftCount;
                p[6] <<= shiftCount;
                p[7] <<= shiftCount;
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{Int32}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<Int32> ShiftLeft(Vector<Int32> value, int shiftCount) {
                Vector<Int32> rt = value;
                Int32* p = (Int32*)&rt;
                p[0] <<= shiftCount;
                p[1] <<= shiftCount;
                p[2] <<= shiftCount;
                p[3] <<= shiftCount;
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{Int32}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<Int32> ShiftRightArithmetic(Vector<Int32> value, int shiftCount) {
                Vector<Int32> rt = value;
                Int32* p = (Int32*)&rt;
                p[0] >>= shiftCount;
                p[1] >>= shiftCount;
                p[2] >>= shiftCount;
                p[3] >>= shiftCount;
                return rt;
            }

        } // Statics
    }
}
