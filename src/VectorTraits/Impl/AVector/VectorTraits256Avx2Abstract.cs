﻿using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.Impl.AVector {
    using Statics = VectorTraits256Avx2.Statics;

    /// <summary>
    /// <see cref="Vector{T}"/> traits 256 - Avx2 abstract.
    /// </summary>
    public abstract class VectorTraits256Avx2Abstract : VectorTraits256Abstract {
        
        /// <inheritdoc cref="IBaseTraits.IsSupported"/>
        public override bool IsSupported {
            get {
                return Statics.IsSupported;
            }
        }

        /// <inheritdoc cref="IBaseTraits.GetIsSupported"/>
        public override bool GetIsSupported(bool noStrict = false) {
            return Statics.GetIsSupported(noStrict);
        }

        /// <inheritdoc cref="IBaseTraits.GetUnsupportedMessage"/>
        public override string GetUnsupportedMessage(bool noStrict = false) {
            return Statics.GetUnsupportedMessage(noStrict);
        }

        /// <inheritdoc cref="IBaseTraits.ThrowForUnsupported"/>
        public override void ThrowForUnsupported(bool noStrict = false) {
            Statics.ThrowForUnsupported(noStrict);
        }

#if NETCOREAPP3_0_OR_GREATER

        /// <inheritdoc cref="IVectorTraits.Ceiling_AcceleratedTypes"/>
        public override TypeCodeFlags Ceiling_AcceleratedTypes {
            get {
                return Statics.Ceiling_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.Ceiling(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> Ceiling(Vector<float> value) {
            return Statics.Ceiling(value);
        }

        /// <inheritdoc cref="IVectorTraits.Ceiling(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> Ceiling(Vector<double> value) {
            return Statics.Ceiling(value);
        }


        /// <inheritdoc cref="IVectorTraits.ConvertToDouble_AcceleratedTypes"/>
        public override TypeCodeFlags ConvertToDouble_AcceleratedTypes {
            get {
                return Statics.ConvertToDouble_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.ConvertToDouble(Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> ConvertToDouble(Vector<long> value) {
            return Statics.ConvertToDouble(value);
        }

        /// <inheritdoc cref="IVectorTraits.ConvertToDouble(Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> ConvertToDouble(Vector<ulong> value) {
            return Statics.ConvertToDouble(value);
        }


        /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits_AcceleratedTypes"/>
        public override TypeCodeFlags ExtractMostSignificantBits_AcceleratedTypes {
            get {
                return Statics.ExtractMostSignificantBits_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ulong ExtractMostSignificantBits(Vector<float> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ulong ExtractMostSignificantBits(Vector<double> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ulong ExtractMostSignificantBits(Vector<sbyte> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ulong ExtractMostSignificantBits(Vector<byte> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ulong ExtractMostSignificantBits(Vector<short> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ulong ExtractMostSignificantBits(Vector<ushort> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ulong ExtractMostSignificantBits(Vector<int> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ulong ExtractMostSignificantBits(Vector<uint> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ulong ExtractMostSignificantBits(Vector<long> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ulong ExtractMostSignificantBits(Vector<ulong> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }


        /// <inheritdoc cref="IVectorTraits.Floor_AcceleratedTypes"/>
        public override TypeCodeFlags Floor_AcceleratedTypes {
            get {
                return Statics.Floor_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.Floor(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> Floor(Vector<float> value) {
            return Statics.Floor(value);
        }

        /// <inheritdoc cref="IVectorTraits.Floor(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> Floor(Vector<double> value) {
            return Statics.Floor(value);
        }


        /// <inheritdoc cref="IVectorTraits.Multiply_AcceleratedTypes"/>
        public override TypeCodeFlags Multiply_AcceleratedTypes {
            get {
                return Statics.Multiply_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.Multiply_FullAcceleratedTypes"/>
        public override TypeCodeFlags Multiply_FullAcceleratedTypes {
            get {
                return Statics.Multiply_FullAcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> Multiply(Vector<float> left, Vector<float> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{double}, Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> Multiply(Vector<double> left, Vector<double> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> Multiply(Vector<sbyte> left, Vector<sbyte> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> Multiply(Vector<byte> left, Vector<byte> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> Multiply(Vector<short> left, Vector<short> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> Multiply(Vector<ushort> left, Vector<ushort> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> Multiply(Vector<int> left, Vector<int> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> Multiply(Vector<uint> left, Vector<uint> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> Multiply(Vector<long> left, Vector<long> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> Multiply(Vector<ulong> left, Vector<ulong> right) {
            return Statics.Multiply(left, right);
        }


        /// <inheritdoc cref="IVectorTraits.Narrow_AcceleratedTypes"/>
        public override TypeCodeFlags Narrow_AcceleratedTypes {
            get {
                return Statics.Narrow_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.Narrow(Vector{double}, Vector{double})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> Narrow(Vector<double> lower, Vector<double> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.Narrow(Vector{short}, Vector{short})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> Narrow(Vector<short> lower, Vector<short> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.Narrow(Vector{ushort}, Vector{ushort})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> Narrow(Vector<ushort> lower, Vector<ushort> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.Narrow(Vector{int}, Vector{int})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> Narrow(Vector<int> lower, Vector<int> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.Narrow(Vector{uint}, Vector{uint})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> Narrow(Vector<uint> lower, Vector<uint> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.Narrow(Vector{long}, Vector{long})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> Narrow(Vector<long> lower, Vector<long> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.Narrow(Vector{ulong}, Vector{ulong})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> Narrow(Vector<ulong> lower, Vector<ulong> upper) {
            return Statics.Narrow(lower, upper);
        }


        /// <inheritdoc cref="IVectorTraits.ShiftLeft_AcceleratedTypes"/>
        public override TypeCodeFlags ShiftLeft_AcceleratedTypes {
            get {
                return Statics.ShiftLeft_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> ShiftLeft(Vector<sbyte> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> ShiftLeft(Vector<byte> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> ShiftLeft(Vector<short> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> ShiftLeft(Vector<ushort> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> ShiftLeft(Vector<int> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> ShiftLeft(Vector<uint> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> ShiftLeft(Vector<long> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> ShiftLeft(Vector<ulong> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> ShiftLeftFast(Vector<sbyte> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> ShiftLeftFast(Vector<byte> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> ShiftLeftFast(Vector<short> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> ShiftLeftFast(Vector<ushort> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> ShiftLeftFast(Vector<int> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> ShiftLeftFast(Vector<uint> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> ShiftLeftFast(Vector<long> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> ShiftLeftFast(Vector<ulong> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }


        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_AcceleratedTypes"/>
        public override TypeCodeFlags ShiftRightArithmetic_AcceleratedTypes {
            get {
                return Statics.ShiftRightArithmetic_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> ShiftRightArithmetic(Vector<sbyte> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> ShiftRightArithmetic(Vector<short> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> ShiftRightArithmetic(Vector<int> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> ShiftRightArithmetic(Vector<long> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> ShiftRightArithmeticFast(Vector<sbyte> value, int shiftAmount) {
            return Statics.ShiftRightArithmeticFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> ShiftRightArithmeticFast(Vector<short> value, int shiftAmount) {
            return Statics.ShiftRightArithmeticFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> ShiftRightArithmeticFast(Vector<int> value, int shiftAmount) {
            return Statics.ShiftRightArithmeticFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> ShiftRightArithmeticFast(Vector<long> value, int shiftAmount) {
            return Statics.ShiftRightArithmeticFast(value, shiftAmount);
        }


        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_AcceleratedTypes"/>
        public override TypeCodeFlags ShiftRightLogical_AcceleratedTypes {
            get {
                return Statics.ShiftRightLogical_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> ShiftRightLogical(Vector<sbyte> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> ShiftRightLogical(Vector<byte> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> ShiftRightLogical(Vector<short> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> ShiftRightLogical(Vector<ushort> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> ShiftRightLogical(Vector<int> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> ShiftRightLogical(Vector<uint> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> ShiftRightLogical(Vector<long> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> ShiftRightLogical(Vector<ulong> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> ShiftRightLogicalFast(Vector<sbyte> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> ShiftRightLogicalFast(Vector<byte> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> ShiftRightLogicalFast(Vector<short> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> ShiftRightLogicalFast(Vector<ushort> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> ShiftRightLogicalFast(Vector<int> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> ShiftRightLogicalFast(Vector<uint> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> ShiftRightLogicalFast(Vector<long> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> ShiftRightLogicalFast(Vector<ulong> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }


        /// <inheritdoc cref="IVectorTraits.Shuffle_AcceleratedTypes"/>
        public override TypeCodeFlags Shuffle_AcceleratedTypes {
            get {
                return Statics.Shuffle_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{float}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> Shuffle(Vector<float> vector, Vector<int> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{double}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> Shuffle(Vector<double> vector, Vector<long> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> Shuffle(Vector<sbyte> vector, Vector<sbyte> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> Shuffle(Vector<byte> vector, Vector<byte> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> Shuffle(Vector<short> vector, Vector<short> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> Shuffle(Vector<ushort> vector, Vector<ushort> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> Shuffle(Vector<int> vector, Vector<int> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> Shuffle(Vector<uint> vector, Vector<uint> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> Shuffle(Vector<long> vector, Vector<long> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> Shuffle(Vector<ulong> vector, Vector<ulong> indices) {
            return Statics.Shuffle(vector, indices);
        }


        /// <inheritdoc cref="IVectorTraits.Sum_AcceleratedTypes"/>
        public override TypeCodeFlags Sum_AcceleratedTypes {
            get {
                return Statics.Sum_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.Sum(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override float Sum(Vector<float> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IVectorTraits.Sum(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override double Sum(Vector<double> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IVectorTraits.Sum(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override sbyte Sum(Vector<sbyte> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IVectorTraits.Sum(Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override byte Sum(Vector<byte> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IVectorTraits.Sum(Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override short Sum(Vector<short> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IVectorTraits.Sum(Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ushort Sum(Vector<ushort> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IVectorTraits.Sum(Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int Sum(Vector<int> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IVectorTraits.Sum(Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint Sum(Vector<uint> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IVectorTraits.Sum(Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override long Sum(Vector<long> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IVectorTraits.Sum(Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ulong Sum(Vector<ulong> value) {
            return Statics.Sum(value);
        }


        /// <inheritdoc cref="IVectorTraits.Widen_AcceleratedTypes"/>
        public override TypeCodeFlags Widen_AcceleratedTypes {
            get {
                return Statics.Widen_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.Widen(Vector{float}, out Vector{double}, out Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector<float> source, out Vector<double> lower, out Vector<double> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IVectorTraits.Widen(Vector{sbyte}, out Vector{short}, out Vector{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector<sbyte> source, out Vector<short> lower, out Vector<short> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IVectorTraits.Widen(Vector{byte}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector<byte> source, out Vector<ushort> lower, out Vector<ushort> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IVectorTraits.Widen(Vector{short}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector<short> source, out Vector<int> lower, out Vector<int> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IVectorTraits.Widen(Vector{ushort}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector<ushort> source, out Vector<uint> lower, out Vector<uint> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IVectorTraits.Widen(Vector{int}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector<int> source, out Vector<long> lower, out Vector<long> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IVectorTraits.Widen(Vector{uint}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector<uint> source, out Vector<ulong> lower, out Vector<ulong> upper) {
            Statics.Widen(source, out lower, out upper);
        }


        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate_AcceleratedTypes"/>
        public override TypeCodeFlags YNarrowSaturate_AcceleratedTypes {
            get {
                return Statics.YNarrowSaturate_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate_FullAcceleratedTypes"/>
        public override TypeCodeFlags YNarrowSaturate_FullAcceleratedTypes {
            get {
                return Statics.YNarrowSaturate_FullAcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{short}, Vector{short})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YNarrowSaturate(Vector<short> lower, Vector<short> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{ushort}, Vector{ushort})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YNarrowSaturate(Vector<ushort> lower, Vector<ushort> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{int}, Vector{int})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YNarrowSaturate(Vector<int> lower, Vector<int> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{uint}, Vector{uint})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YNarrowSaturate(Vector<uint> lower, Vector<uint> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{long}, Vector{long})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YNarrowSaturate(Vector<long> lower, Vector<long> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{ulong}, Vector{ulong})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YNarrowSaturate(Vector<ulong> lower, Vector<ulong> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }


        /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned_AcceleratedTypes"/>
        public override TypeCodeFlags YNarrowSaturateUnsigned_AcceleratedTypes {
            get {
                return Statics.YNarrowSaturateUnsigned_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned_FullAcceleratedTypes"/>
        public override TypeCodeFlags YNarrowSaturateUnsigned_FullAcceleratedTypes {
            get {
                return Statics.YNarrowSaturateUnsigned_FullAcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned(Vector{short}, Vector{short})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YNarrowSaturateUnsigned(Vector<short> lower, Vector<short> upper) {
            return Statics.YNarrowSaturateUnsigned(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned(Vector{int}, Vector{int})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YNarrowSaturateUnsigned(Vector<int> lower, Vector<int> upper) {
            return Statics.YNarrowSaturateUnsigned(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned(Vector{long}, Vector{long})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YNarrowSaturateUnsigned(Vector<long> lower, Vector<long> upper) {
            return Statics.YNarrowSaturateUnsigned(lower, upper);
        }


        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleInsert_AcceleratedTypes {
            get {
                return Statics.YShuffleInsert_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{float}, Vector{float}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleInsert(Vector<float> back, Vector<float> vector, Vector<int> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{double}, Vector{double}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleInsert(Vector<double> back, Vector<double> vector, Vector<long> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleInsert(Vector<sbyte> back, Vector<sbyte> vector, Vector<sbyte> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleInsert(Vector<byte> back, Vector<byte> vector, Vector<byte> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleInsert(Vector<short> back, Vector<short> vector, Vector<short> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleInsert(Vector<ushort> back, Vector<ushort> vector, Vector<ushort> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleInsert(Vector<int> back, Vector<int> vector, Vector<int> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleInsert(Vector<uint> back, Vector<uint> vector, Vector<uint> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleInsert(Vector<long> back, Vector<long> vector, Vector<long> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleInsert(Vector<ulong> back, Vector<ulong> vector, Vector<ulong> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }


        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleKernel_AcceleratedTypes {
            get {
                return Statics.YShuffleKernel_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{float}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleKernel(Vector<float> vector, Vector<int> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{double}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleKernel(Vector<double> vector, Vector<long> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleKernel(Vector<sbyte> vector, Vector<sbyte> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleKernel(Vector<byte> vector, Vector<byte> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleKernel(Vector<short> vector, Vector<short> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleKernel(Vector<ushort> vector, Vector<ushort> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleKernel(Vector<int> vector, Vector<int> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleKernel(Vector<uint> vector, Vector<uint> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleKernel(Vector<long> vector, Vector<long> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleKernel(Vector<ulong> vector, Vector<ulong> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }


#endif // NETCOREAPP3_0_OR_GREATER
    }
}