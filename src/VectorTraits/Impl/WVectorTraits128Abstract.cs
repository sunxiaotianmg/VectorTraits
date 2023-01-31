﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Impl {
    using Statics = WVectorTraits128Base.Statics;

    /// <summary>
    /// <see cref="Vector128{T}"/> traits - abstract.
    /// </summary>
    public abstract class WVectorTraits128Abstract : IWVectorTraits128, IBaseTraits {

        /// <summary>
        /// Get best instance.
        /// </summary>
        /// <returns>Returns best instance.</returns>
        [CLSCompliant(false)]
        public static IWVectorTraits128 GetBestInstance() {
            if (WVectorTraits128AdvSimdB64.Instance.IsSupported) return WVectorTraits128AdvSimdB64.Instance;
            if (WVectorTraits128AdvSimd.Instance.IsSupported) return WVectorTraits128AdvSimd.Instance;
            return WVectorTraits128Base.Instance;
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

        /// <inheritdoc cref="IWVectorTraits128.Add_AcceleratedTypes"/>
        public virtual TypeCodeFlags Add_AcceleratedTypes {
            get {
                return Statics.Add_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> Add(Vector128<float> left, Vector128<float> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> Add(Vector128<double> left, Vector128<double> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> Add(Vector128<sbyte> left, Vector128<sbyte> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> Add(Vector128<byte> left, Vector128<byte> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> Add(Vector128<short> left, Vector128<short> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> Add(Vector128<ushort> left, Vector128<ushort> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> Add(Vector128<int> left, Vector128<int> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> Add(Vector128<uint> left, Vector128<uint> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> Add(Vector128<long> left, Vector128<long> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ulong> Add(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.Add(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.AndNot_AcceleratedTypes"/>
        public virtual TypeCodeFlags AndNot_AcceleratedTypes {
            get {
                return Statics.AndNot_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.AndNot{T}(Vector128{T}, Vector128{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<T> AndNot<T>(Vector128<T> left, Vector128<T> right) where T : struct {
            return Statics.AndNot(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.BitwiseAnd_AcceleratedTypes"/>
        public virtual TypeCodeFlags BitwiseAnd_AcceleratedTypes {
            get {
                return Statics.BitwiseAnd_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.BitwiseAnd{T}(Vector128{T}, Vector128{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<T> BitwiseAnd<T>(Vector128<T> left, Vector128<T> right) where T : struct {
            return Statics.BitwiseAnd(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.BitwiseOr_AcceleratedTypes"/>
        public virtual TypeCodeFlags BitwiseOr_AcceleratedTypes {
            get {
                return Statics.BitwiseOr_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.BitwiseOr{T}(Vector128{T}, Vector128{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<T> BitwiseOr<T>(Vector128<T> left, Vector128<T> right) where T : struct {
            return Statics.BitwiseOr(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.Ceiling_AcceleratedTypes"/>
        public virtual TypeCodeFlags Ceiling_AcceleratedTypes {
            get {
                return Statics.Ceiling_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Ceiling(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> Ceiling(Vector128<float> value) {
            return Statics.Ceiling(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Ceiling(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> Ceiling(Vector128<double> value) {
            return Statics.Ceiling(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.ConditionalSelect_AcceleratedTypes"/>
        public virtual TypeCodeFlags ConditionalSelect_AcceleratedTypes {
            get {
                return Statics.ConditionalSelect_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.ConditionalSelect{T}(Vector128{T}, Vector128{T}, Vector128{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<T> ConditionalSelect<T>(Vector128<T> condition, Vector128<T> left, Vector128<T> right) where T : struct {
            return Statics.ConditionalSelect(condition, left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.ConditionalSelect(Vector128{int}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> ConditionalSelect(Vector128<int> condition, Vector128<float> left, Vector128<float> right) {
            return ConditionalSelect<float>(condition.AsSingle(), left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.ConditionalSelect(Vector128{long}, Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> ConditionalSelect(Vector128<long> condition, Vector128<double> left, Vector128<double> right) {
            return ConditionalSelect<double>(condition.AsDouble(), left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.Floor_AcceleratedTypes"/>
        public virtual TypeCodeFlags Floor_AcceleratedTypes {
            get {
                return Statics.Floor_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Floor(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> Floor(Vector128<float> value) {
            return Statics.Floor(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Floor(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> Floor(Vector128<double> value) {
            return Statics.Floor(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.GreaterThan_AcceleratedTypes"/>
        public virtual TypeCodeFlags GreaterThan_AcceleratedTypes {
            get {
                return Statics.GreaterThan_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> GreaterThan(Vector128<float> left, Vector128<float> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> GreaterThan(Vector128<double> left, Vector128<double> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> GreaterThan(Vector128<sbyte> left, Vector128<sbyte> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> GreaterThan(Vector128<byte> left, Vector128<byte> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> GreaterThan(Vector128<short> left, Vector128<short> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> GreaterThan(Vector128<ushort> left, Vector128<ushort> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> GreaterThan(Vector128<int> left, Vector128<int> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> GreaterThan(Vector128<uint> left, Vector128<uint> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> GreaterThan(Vector128<long> left, Vector128<long> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ulong> GreaterThan(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.GreaterThan(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.LessThan_AcceleratedTypes"/>
        public virtual TypeCodeFlags LessThan_AcceleratedTypes {
            get {
                return Statics.LessThan_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> LessThan(Vector128<float> left, Vector128<float> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> LessThan(Vector128<double> left, Vector128<double> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> LessThan(Vector128<sbyte> left, Vector128<sbyte> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> LessThan(Vector128<byte> left, Vector128<byte> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> LessThan(Vector128<short> left, Vector128<short> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> LessThan(Vector128<ushort> left, Vector128<ushort> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> LessThan(Vector128<int> left, Vector128<int> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> LessThan(Vector128<uint> left, Vector128<uint> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> LessThan(Vector128<long> left, Vector128<long> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ulong> LessThan(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.LessThan(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.Max_AcceleratedTypes"/>
        public virtual TypeCodeFlags Max_AcceleratedTypes {
            get {
                return Statics.Max_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> Max(Vector128<float> left, Vector128<float> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> Max(Vector128<double> left, Vector128<double> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> Max(Vector128<sbyte> left, Vector128<sbyte> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> Max(Vector128<byte> left, Vector128<byte> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> Max(Vector128<short> left, Vector128<short> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> Max(Vector128<ushort> left, Vector128<ushort> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> Max(Vector128<int> left, Vector128<int> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> Max(Vector128<uint> left, Vector128<uint> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> Max(Vector128<long> left, Vector128<long> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ulong> Max(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.Max(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.Min_AcceleratedTypes"/>
        public virtual TypeCodeFlags Min_AcceleratedTypes {
            get {
                return Statics.Min_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> Min(Vector128<float> left, Vector128<float> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> Min(Vector128<double> left, Vector128<double> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> Min(Vector128<sbyte> left, Vector128<sbyte> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> Min(Vector128<byte> left, Vector128<byte> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> Min(Vector128<short> left, Vector128<short> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> Min(Vector128<ushort> left, Vector128<ushort> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> Min(Vector128<int> left, Vector128<int> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> Min(Vector128<uint> left, Vector128<uint> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> Min(Vector128<long> left, Vector128<long> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ulong> Min(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.Min(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.Negate_AcceleratedTypes"/>
        public virtual TypeCodeFlags Negate_AcceleratedTypes {
            get {
                return Statics.Negate_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> Negate(Vector128<float> value) {
            return Statics.Negate(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> Negate(Vector128<double> value) {
            return Statics.Negate(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> Negate(Vector128<sbyte> value) {
            return Statics.Negate(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> Negate(Vector128<short> value) {
            return Statics.Negate(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> Negate(Vector128<int> value) {
            return Statics.Negate(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> Negate(Vector128<long> value) {
            return Statics.Negate(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.OnesComplement_AcceleratedTypes"/>
        public virtual TypeCodeFlags OnesComplement_AcceleratedTypes {
            get {
                return Statics.OnesComplement_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.OnesComplement{T}(Vector128{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<T> OnesComplement<T>(Vector128<T> vector) where T : struct {
            return Statics.OnesComplement(vector);
        }


        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_AcceleratedTypes"/>
        public virtual TypeCodeFlags ShiftLeft_AcceleratedTypes {
            get {
                return Statics.ShiftLeft_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> ShiftLeft(Vector128<sbyte> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> ShiftLeft(Vector128<byte> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> ShiftLeft(Vector128<short> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> ShiftLeft(Vector128<ushort> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> ShiftLeft(Vector128<int> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> ShiftLeft(Vector128<uint> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> ShiftLeft(Vector128<long> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ulong> ShiftLeft(Vector128<ulong> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> ShiftLeftFast(Vector128<sbyte> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> ShiftLeftFast(Vector128<byte> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> ShiftLeftFast(Vector128<short> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> ShiftLeftFast(Vector128<ushort> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> ShiftLeftFast(Vector128<int> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> ShiftLeftFast(Vector128<uint> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> ShiftLeftFast(Vector128<long> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ulong> ShiftLeftFast(Vector128<ulong> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }


        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_AcceleratedTypes"/>
        public virtual TypeCodeFlags ShiftRightArithmetic_AcceleratedTypes {
            get {
                return Statics.ShiftRightArithmetic_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> ShiftRightArithmetic(Vector128<sbyte> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> ShiftRightArithmetic(Vector128<short> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> ShiftRightArithmetic(Vector128<int> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> ShiftRightArithmetic(Vector128<long> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmeticFast(Vector128{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> ShiftRightArithmeticFast(Vector128<sbyte> value, int shiftAmount) {
            return Statics.ShiftRightArithmeticFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmeticFast(Vector128{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> ShiftRightArithmeticFast(Vector128<short> value, int shiftAmount) {
            return Statics.ShiftRightArithmeticFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmeticFast(Vector128{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> ShiftRightArithmeticFast(Vector128<int> value, int shiftAmount) {
            return Statics.ShiftRightArithmeticFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmeticFast(Vector128{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> ShiftRightArithmeticFast(Vector128<long> value, int shiftAmount) {
            return Statics.ShiftRightArithmeticFast(value, shiftAmount);
        }


        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_AcceleratedTypes"/>
        public virtual TypeCodeFlags ShiftRightLogical_AcceleratedTypes {
            get {
                return Statics.ShiftRightLogical_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> ShiftRightLogical(Vector128<sbyte> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> ShiftRightLogical(Vector128<byte> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> ShiftRightLogical(Vector128<short> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> ShiftRightLogical(Vector128<ushort> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> ShiftRightLogical(Vector128<int> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> ShiftRightLogical(Vector128<uint> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> ShiftRightLogical(Vector128<long> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ulong> ShiftRightLogical(Vector128<ulong> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> ShiftRightLogicalFast(Vector128<sbyte> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> ShiftRightLogicalFast(Vector128<byte> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> ShiftRightLogicalFast(Vector128<short> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> ShiftRightLogicalFast(Vector128<ushort> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> ShiftRightLogicalFast(Vector128<int> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> ShiftRightLogicalFast(Vector128<uint> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> ShiftRightLogicalFast(Vector128<long> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ulong> ShiftRightLogicalFast(Vector128<ulong> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }


        /// <inheritdoc cref="IWVectorTraits128.Subtract_AcceleratedTypes"/>
        public virtual TypeCodeFlags Subtract_AcceleratedTypes {
            get {
                return Statics.Subtract_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> Subtract(Vector128<float> left, Vector128<float> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> Subtract(Vector128<double> left, Vector128<double> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> Subtract(Vector128<sbyte> left, Vector128<sbyte> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> Subtract(Vector128<byte> left, Vector128<byte> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> Subtract(Vector128<short> left, Vector128<short> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> Subtract(Vector128<ushort> left, Vector128<ushort> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> Subtract(Vector128<int> left, Vector128<int> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> Subtract(Vector128<uint> left, Vector128<uint> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> Subtract(Vector128<long> left, Vector128<long> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ulong> Subtract(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.Subtract(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.Xor_AcceleratedTypes"/>
        public virtual TypeCodeFlags Xor_AcceleratedTypes {
            get {
                return Statics.Xor_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Xor{T}(Vector128{T}, Vector128{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<T> Xor<T>(Vector128<T> left, Vector128<T> right) where T : struct {
            return Statics.Xor(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.YClamp_AcceleratedTypes"/>
        public virtual TypeCodeFlags YClamp_AcceleratedTypes {
            get {
                return Statics.YClamp_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> YClamp(Vector128<float> value, Vector128<float> amin, Vector128<float> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{double}, Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> YClamp(Vector128<double> value, Vector128<double> amin, Vector128<double> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> YClamp(Vector128<sbyte> value, Vector128<sbyte> amin, Vector128<sbyte> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> YClamp(Vector128<byte> value, Vector128<byte> amin, Vector128<byte> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> YClamp(Vector128<short> value, Vector128<short> amin, Vector128<short> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> YClamp(Vector128<ushort> value, Vector128<ushort> amin, Vector128<ushort> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> YClamp(Vector128<int> value, Vector128<int> amin, Vector128<int> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> YClamp(Vector128<uint> value, Vector128<uint> amin, Vector128<uint> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> YClamp(Vector128<long> value, Vector128<long> amin, Vector128<long> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ulong> YClamp(Vector128<ulong> value, Vector128<ulong> amin, Vector128<ulong> amax) {
            return Statics.YClamp(value, amin, amax);
        }

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
