﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Impl.AVector256 {
    using Statics = WVectorTraits256Base.Statics;

    /// <summary>
    /// <see cref="Vector256{T}"/> traits - abstract.
    /// </summary>
    public abstract partial class WVectorTraits256Abstract : IWVectorTraits256, IBaseTraits {

        /// <summary>
        /// Get best instance.
        /// </summary>
        /// <returns>Returns best instance.</returns>
        [CLSCompliant(false)]
        public static IWVectorTraits256 GetBestInstance() {
            if (WVectorTraits256Avx2.Instance.IsSupported) return WVectorTraits256Avx2.Instance;
            return WVectorTraits256Base.Instance;
        }

        /// <summary>ByteCount value</summary>
        public const int ByteCountValue = 32;

        /// <inheritdoc cref="IBaseTraits.ByteCount"/>
        public int ByteCount {
            get {
                return Statics.ByteCount;
            }
        }

        /// <inheritdoc cref="IBaseTraits.IsSupported"/>
        public virtual bool IsSupported {
            get {
                return Statics.IsSupported;
            }
        }

        /// <inheritdoc cref="IBaseTraits.GetIsSupported"/>
        public virtual bool GetIsSupported(bool noStrict = false) {
            return Statics.GetIsSupported(noStrict);
        }

        /// <inheritdoc cref="IBaseTraits.GetUnsupportedMessage"/>
        public virtual string GetUnsupportedMessage(bool noStrict = false) {
            return Statics.GetUnsupportedMessage(noStrict);
        }

        /// <inheritdoc cref="IBaseTraits.ThrowForUnsupported"/>
        public virtual void ThrowForUnsupported(bool noStrict = false) {
            Statics.ThrowForUnsupported(noStrict);
        }

#if NETCOREAPP3_0_OR_GREATER

        /// <inheritdoc cref="IWVectorTraits256.Ceiling_AcceleratedTypes"/>
        public virtual TypeCodeFlags Ceiling_AcceleratedTypes {
            get {
                return Statics.Ceiling_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Ceiling(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> Ceiling(Vector256<float> value) {
            return Statics.Ceiling(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.Ceiling(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> Ceiling(Vector256<double> value) {
            return Statics.Ceiling(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.ConvertToDouble_AcceleratedTypes"/>
        public virtual TypeCodeFlags ConvertToDouble_AcceleratedTypes {
            get {
                return Statics.ConvertToDouble_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ConvertToDouble(Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> ConvertToDouble(Vector256<long> value) {
            return Statics.ConvertToDouble(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.ConvertToDouble(Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> ConvertToDouble(Vector256<ulong> value) {
            return Statics.ConvertToDouble(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.ConvertToInt32_AcceleratedTypes"/>
        public virtual TypeCodeFlags ConvertToInt32_AcceleratedTypes {
            get {
                return Statics.ConvertToInt32_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ConvertToInt32(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> ConvertToInt32(Vector256<float> value) {
            return Statics.ConvertToInt32(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.ConvertToInt64_AcceleratedTypes"/>
        public virtual TypeCodeFlags ConvertToInt64_AcceleratedTypes {
            get {
                return Statics.ConvertToInt64_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ConvertToInt64(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> ConvertToInt64(Vector256<double> value) {
            return Statics.ConvertToInt64(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.ConvertToSingle_AcceleratedTypes"/>
        public virtual TypeCodeFlags ConvertToSingle_AcceleratedTypes {
            get {
                return Statics.ConvertToSingle_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ConvertToSingle(Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> ConvertToSingle(Vector256<int> value) {
            return Statics.ConvertToSingle(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.ConvertToSingle(Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> ConvertToSingle(Vector256<uint> value) {
            return Statics.ConvertToSingle(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.ConvertToUInt32_AcceleratedTypes"/>
        public virtual TypeCodeFlags ConvertToUInt32_AcceleratedTypes {
            get {
                return Statics.ConvertToUInt32_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ConvertToUInt32(Vector256{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> ConvertToUInt32(Vector256<float> value) {
            return Statics.ConvertToUInt32(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.ConvertToUInt64_AcceleratedTypes"/>
        public virtual TypeCodeFlags ConvertToUInt64_AcceleratedTypes {
            get {
                return Statics.ConvertToUInt64_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ConvertToUInt64(Vector256{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> ConvertToUInt64(Vector256<double> value) {
            return Statics.ConvertToUInt64(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits_AcceleratedTypes"/>
        public virtual TypeCodeFlags ExtractMostSignificantBits_AcceleratedTypes {
            get {
                return Statics.ExtractMostSignificantBits_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual uint ExtractMostSignificantBits(Vector256<float> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual uint ExtractMostSignificantBits(Vector256<double> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual uint ExtractMostSignificantBits(Vector256<sbyte> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual uint ExtractMostSignificantBits(Vector256<byte> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual uint ExtractMostSignificantBits(Vector256<short> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual uint ExtractMostSignificantBits(Vector256<ushort> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual uint ExtractMostSignificantBits(Vector256<int> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual uint ExtractMostSignificantBits(Vector256<uint> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual uint ExtractMostSignificantBits(Vector256<long> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual uint ExtractMostSignificantBits(Vector256<ulong> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }


        /// <inheritdoc cref="IWVectorTraits256.Floor_AcceleratedTypes"/>
        public virtual TypeCodeFlags Floor_AcceleratedTypes {
            get {
                return Statics.Floor_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Floor(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> Floor(Vector256<float> value) {
            return Statics.Floor(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.Floor(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> Floor(Vector256<double> value) {
            return Statics.Floor(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.Narrow_AcceleratedTypes"/>
        public virtual TypeCodeFlags Narrow_AcceleratedTypes {
            get {
                return Statics.Narrow_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{double}, Vector256{double})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> Narrow(Vector256<double> lower, Vector256<double> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{short}, Vector256{short})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> Narrow(Vector256<short> lower, Vector256<short> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{ushort}, Vector256{ushort})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> Narrow(Vector256<ushort> lower, Vector256<ushort> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{int}, Vector256{int})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> Narrow(Vector256<int> lower, Vector256<int> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{uint}, Vector256{uint})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> Narrow(Vector256<uint> lower, Vector256<uint> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{long}, Vector256{long})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> Narrow(Vector256<long> lower, Vector256<long> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{ulong}, Vector256{ulong})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> Narrow(Vector256<ulong> lower, Vector256<ulong> upper) {
            return Statics.Narrow(lower, upper);
        }


        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_AcceleratedTypes"/>
        public virtual TypeCodeFlags ShiftLeft_AcceleratedTypes {
            get {
                return Statics.ShiftLeft_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> ShiftLeft(Vector256<sbyte> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> ShiftLeft(Vector256<byte> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> ShiftLeft(Vector256<short> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> ShiftLeft(Vector256<ushort> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> ShiftLeft(Vector256<int> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> ShiftLeft(Vector256<uint> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> ShiftLeft(Vector256<long> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> ShiftLeft(Vector256<ulong> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> ShiftLeftFast(Vector256<sbyte> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> ShiftLeftFast(Vector256<byte> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> ShiftLeftFast(Vector256<short> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> ShiftLeftFast(Vector256<ushort> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> ShiftLeftFast(Vector256<int> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> ShiftLeftFast(Vector256<uint> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> ShiftLeftFast(Vector256<long> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> ShiftLeftFast(Vector256<ulong> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }


        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_AcceleratedTypes"/>
        public virtual TypeCodeFlags ShiftRightArithmetic_AcceleratedTypes {
            get {
                return Statics.ShiftRightArithmetic_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> ShiftRightArithmetic(Vector256<sbyte> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> ShiftRightArithmetic(Vector256<short> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> ShiftRightArithmetic(Vector256<int> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> ShiftRightArithmetic(Vector256<long> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> ShiftRightArithmeticFast(Vector256<sbyte> value, int shiftAmount) {
            return Statics.ShiftRightArithmeticFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> ShiftRightArithmeticFast(Vector256<short> value, int shiftAmount) {
            return Statics.ShiftRightArithmeticFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> ShiftRightArithmeticFast(Vector256<int> value, int shiftAmount) {
            return Statics.ShiftRightArithmeticFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> ShiftRightArithmeticFast(Vector256<long> value, int shiftAmount) {
            return Statics.ShiftRightArithmeticFast(value, shiftAmount);
        }


        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_AcceleratedTypes"/>
        public virtual TypeCodeFlags ShiftRightLogical_AcceleratedTypes {
            get {
                return Statics.ShiftRightLogical_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> ShiftRightLogical(Vector256<sbyte> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> ShiftRightLogical(Vector256<byte> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> ShiftRightLogical(Vector256<short> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> ShiftRightLogical(Vector256<ushort> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> ShiftRightLogical(Vector256<int> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> ShiftRightLogical(Vector256<uint> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> ShiftRightLogical(Vector256<long> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> ShiftRightLogical(Vector256<ulong> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> ShiftRightLogicalFast(Vector256<sbyte> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> ShiftRightLogicalFast(Vector256<byte> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> ShiftRightLogicalFast(Vector256<short> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> ShiftRightLogicalFast(Vector256<ushort> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> ShiftRightLogicalFast(Vector256<int> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> ShiftRightLogicalFast(Vector256<uint> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> ShiftRightLogicalFast(Vector256<long> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> ShiftRightLogicalFast(Vector256<ulong> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }


        /// <inheritdoc cref="IWVectorTraits256.Shuffle_AcceleratedTypes"/>
        public virtual TypeCodeFlags Shuffle_AcceleratedTypes {
            get {
                return Statics.Shuffle_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{float}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> Shuffle(Vector256<float> vector, Vector256<int> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{double}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> Shuffle(Vector256<double> vector, Vector256<long> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> Shuffle(Vector256<sbyte> vector, Vector256<sbyte> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> Shuffle(Vector256<byte> vector, Vector256<byte> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> Shuffle(Vector256<short> vector, Vector256<short> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> Shuffle(Vector256<ushort> vector, Vector256<ushort> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> Shuffle(Vector256<int> vector, Vector256<int> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> Shuffle(Vector256<uint> vector, Vector256<uint> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> Shuffle(Vector256<long> vector, Vector256<long> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> Shuffle(Vector256<ulong> vector, Vector256<ulong> indices) {
            return Statics.Shuffle(vector, indices);
        }


        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void Shuffle_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void Shuffle_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void Shuffle_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void Shuffle_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void Shuffle_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void Shuffle_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void Shuffle_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void Shuffle_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }


        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{float}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> Shuffle_Core(Vector256<float> vector, Vector256<int> args0, Vector256<int> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{double}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> Shuffle_Core(Vector256<double> vector, Vector256<long> args0, Vector256<long> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> Shuffle_Core(Vector256<sbyte> vector, Vector256<sbyte> args0, Vector256<sbyte> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> Shuffle_Core(Vector256<byte> vector, Vector256<byte> args0, Vector256<byte> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> Shuffle_Core(Vector256<short> vector, Vector256<short> args0, Vector256<short> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> Shuffle_Core(Vector256<ushort> vector, Vector256<ushort> args0, Vector256<ushort> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> Shuffle_Core(Vector256<int> vector, Vector256<int> args0, Vector256<int> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> Shuffle_Core(Vector256<uint> vector, Vector256<uint> args0, Vector256<uint> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> Shuffle_Core(Vector256<long> vector, Vector256<long> args0, Vector256<long> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> Shuffle_Core(Vector256<ulong> vector, Vector256<ulong> args0, Vector256<ulong> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }


        /// <inheritdoc cref="IWVectorTraits256.Sum_AcceleratedTypes"/>
        public virtual TypeCodeFlags Sum_AcceleratedTypes {
            get {
                return Statics.Sum_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual float Sum(Vector256<float> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual double Sum(Vector256<double> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual sbyte Sum(Vector256<sbyte> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual byte Sum(Vector256<byte> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual short Sum(Vector256<short> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual ushort Sum(Vector256<ushort> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual int Sum(Vector256<int> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual uint Sum(Vector256<uint> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual long Sum(Vector256<long> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual ulong Sum(Vector256<ulong> value) {
            return Statics.Sum(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.Widen_AcceleratedTypes"/>
        public virtual TypeCodeFlags Widen_AcceleratedTypes {
            get {
                return Statics.Widen_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{float}, out Vector256{double}, out Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void Widen(Vector256<float> source, out Vector256<double> lower, out Vector256<double> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{sbyte}, out Vector256{short}, out Vector256{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void Widen(Vector256<sbyte> source, out Vector256<short> lower, out Vector256<short> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{byte}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void Widen(Vector256<byte> source, out Vector256<ushort> lower, out Vector256<ushort> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{short}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void Widen(Vector256<short> source, out Vector256<int> lower, out Vector256<int> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{ushort}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void Widen(Vector256<ushort> source, out Vector256<uint> lower, out Vector256<uint> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{int}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void Widen(Vector256<int> source, out Vector256<long> lower, out Vector256<long> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{uint}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void Widen(Vector256<uint> source, out Vector256<ulong> lower, out Vector256<ulong> upper) {
            Statics.Widen(source, out lower, out upper);
        }

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
