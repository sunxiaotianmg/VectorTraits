﻿using System;
using System.Collections.Generic;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// <see cref="Vector256{T}"/> traits interface (<see cref="Vector256{T}"/> 的特征接口).
    /// </summary>
    [CLSCompliant(false)]
    public interface IWVectorTraits256 : IWVectorTraits {
#if NETCOREAPP3_0_OR_GREATER
        /// <summary>
        /// Types with hardware acceleration when running <c>ShiftLeft</c> (运行 <c>ShiftLeft</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="ShiftLeft"/>
        TypeCodeFlags ShiftLeft_AcceleratedTypes { get; }

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>f({ value[i] }, shiftAmount) = { value[i] &lt;&lt; shiftAmount }</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="Vector256.ShiftLeft(Vector256{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeftFast(Vector256{sbyte}, int)"/> // Since: VectorTraits 1.0
        Vector256<sbyte> ShiftLeft(Vector256<sbyte> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>f({ value[i] }, shiftAmount) = { value[i] &lt;&lt; shiftAmount }</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="Vector256.ShiftLeft(Vector256{byte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeftFast(Vector256{byte}, int)"/> // Since: VectorTraits 1.0
        Vector256<byte> ShiftLeft(Vector256<byte> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>f({ value[i] }, shiftAmount) = { value[i] &lt;&lt; shiftAmount }</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="Vector256.ShiftLeft(Vector256{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeftFast(Vector256{short}, int)"/> // Since: VectorTraits 1.0
        Vector256<short> ShiftLeft(Vector256<short> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>f({ value[i] }, shiftAmount) = { value[i] &lt;&lt; shiftAmount }</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="Vector256.ShiftLeft(Vector256{ushort}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeftFast(Vector256{ushort}, int)"/> // Since: VectorTraits 1.0
        Vector256<ushort> ShiftLeft(Vector256<ushort> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>f({ value[i] }, shiftAmount) = { value[i] &lt;&lt; shiftAmount }</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="Vector256.ShiftLeft(Vector256{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeftFast(Vector256{int}, int)"/> // Since: VectorTraits 1.0
        Vector256<int> ShiftLeft(Vector256<int> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>f({ value[i] }, shiftAmount) = { value[i] &lt;&lt; shiftAmount }</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="Vector256.ShiftLeft(Vector256{uint}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeftFast(Vector256{uint}, int)"/> // Since: VectorTraits 1.0
        Vector256<uint> ShiftLeft(Vector256<uint> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>f({ value[i] }, shiftAmount) = { value[i] &lt;&lt; shiftAmount }</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="Vector256.ShiftLeft(Vector256{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeftFast(Vector256{long}, int)"/> // Since: VectorTraits 1.0
        Vector256<long> ShiftLeft(Vector256<long> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>f({ value[i] }, shiftAmount) = { value[i] &lt;&lt; shiftAmount }</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="Vector256.ShiftLeft(Vector256{ulong}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeftFast(Vector256{ulong}, int)"/> // Since: VectorTraits 1.0
        Vector256<ulong> ShiftLeft(Vector256<ulong> value, int shiftAmount);

        /// <summary>
        /// Types with hardware acceleration when running <c>ShiftLeftFast</c> (运行 <c>ShiftLeftFast</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="ShiftLeftFast"/>
        TypeCodeFlags ShiftLeftFast_AcceleratedTypes { get; }

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>f({ value[i] }, shiftAmount) = { value[i] &lt;&lt; shiftAmount }</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="Vector256.ShiftLeft(Vector256{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector256{sbyte}, int)"/> // Since: VectorTraits 1.0
        Vector256<sbyte> ShiftLeftFast(Vector256<sbyte> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>f({ value[i] }, shiftAmount) = { value[i] &lt;&lt; shiftAmount }</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="Vector256.ShiftLeft(Vector256{byte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector256{byte}, int)"/> // Since: VectorTraits 1.0
        Vector256<byte> ShiftLeftFast(Vector256<byte> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>f({ value[i] }, shiftAmount) = { value[i] &lt;&lt; shiftAmount }</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="Vector256.ShiftLeft(Vector256{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector256{short}, int)"/> // Since: VectorTraits 1.0
        Vector256<short> ShiftLeftFast(Vector256<short> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>f({ value[i] }, shiftAmount) = { value[i] &lt;&lt; shiftAmount }</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="Vector256.ShiftLeft(Vector256{ushort}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector256{ushort}, int)"/> // Since: VectorTraits 1.0
        Vector256<ushort> ShiftLeftFast(Vector256<ushort> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>f({ value[i] }, shiftAmount) = { value[i] &lt;&lt; shiftAmount }</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="Vector256.ShiftLeft(Vector256{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector256{int}, int)"/> // Since: VectorTraits 1.0
        Vector256<int> ShiftLeftFast(Vector256<int> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>f({ value[i] }, shiftAmount) = { value[i] &lt;&lt; shiftAmount }</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="Vector256.ShiftLeft(Vector256{uint}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector256{uint}, int)"/> // Since: VectorTraits 1.0
        Vector256<uint> ShiftLeftFast(Vector256<uint> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>f({ value[i] }, shiftAmount) = { value[i] &lt;&lt; shiftAmount }</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="Vector256.ShiftLeft(Vector256{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector256{long}, int)"/> // Since: VectorTraits 1.0
        Vector256<long> ShiftLeftFast(Vector256<long> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>f({ value[i] }, shiftAmount) = { value[i] &lt;&lt; shiftAmount }</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="Vector256.ShiftLeft(Vector256{ulong}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector256{ulong}, int)"/> // Since: VectorTraits 1.0
        Vector256<ulong> ShiftLeftFast(Vector256<ulong> value, int shiftAmount);


        /// <summary>
        /// Types with hardware acceleration when running <c>ShiftRightArithmetic</c> (运行 <c>ShiftRightArithmetic</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="ShiftRightArithmetic"/>
        TypeCodeFlags ShiftRightArithmetic_AcceleratedTypes { get; }

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量).
        /// Mnemonic: <c>f({ value[i] }, shiftAmount) = { value[i] &gt;&gt; shiftAmount }</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="Vector256.ShiftRightArithmetic(Vector256{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmeticFast(Vector256{sbyte}, int)"/> // Since: VectorTraits 1.0
        Vector256<sbyte> ShiftRightArithmetic(Vector256<sbyte> value, int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量).
        /// Mnemonic: <c>f({ value[i] }, shiftAmount) = { value[i] &gt;&gt; shiftAmount }</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="Vector256.ShiftRightArithmetic(Vector256{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmeticFast(Vector256{short}, int)"/> // Since: VectorTraits 1.0
        Vector256<short> ShiftRightArithmetic(Vector256<short> value, int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量).
        /// Mnemonic: <c>f({ value[i] }, shiftAmount) = { value[i] &gt;&gt; shiftAmount }</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="Vector256.ShiftRightArithmetic(Vector256{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmeticFast(Vector256{int}, int)"/> // Since: VectorTraits 1.0
        Vector256<int> ShiftRightArithmetic(Vector256<int> value, int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量).
        /// Mnemonic: <c>f({ value[i] }, shiftAmount) = { value[i] &gt;&gt; shiftAmount }</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="Vector256.ShiftRightArithmetic(Vector256{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmeticFast(Vector256{long}, int)"/> // Since: VectorTraits 1.0
        Vector256<long> ShiftRightArithmetic(Vector256<long> value, int shiftAmount);

        /// <summary>
        /// Types with hardware acceleration when running <c>ShiftRightArithmeticFast</c> (运行 <c>ShiftRightArithmeticFast</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="ShiftRightArithmeticFast"/>
        TypeCodeFlags ShiftRightArithmeticFast_AcceleratedTypes { get; }

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount - Fast(将向量的每个有符号元素算术右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>f({ value[i] }, shiftAmount) = { value[i] &lt;&lt; shiftAmount }</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="Vector256.ShiftRightArithmetic(Vector256{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic(Vector256{sbyte}, int)"/> // Since: VectorTraits 1.0
        Vector256<sbyte> ShiftRightArithmeticFast(Vector256<sbyte> value, int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount - Fast(将向量的每个有符号元素算术右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>f({ value[i] }, shiftAmount) = { value[i] &lt;&lt; shiftAmount }</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="Vector256.ShiftRightArithmetic(Vector256{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic(Vector256{short}, int)"/> // Since: VectorTraits 1.0
        Vector256<short> ShiftRightArithmeticFast(Vector256<short> value, int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount - Fast(将向量的每个有符号元素算术右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>f({ value[i] }, shiftAmount) = { value[i] &lt;&lt; shiftAmount }</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="Vector256.ShiftRightArithmetic(Vector256{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic(Vector256{int}, int)"/> // Since: VectorTraits 1.0
        Vector256<int> ShiftRightArithmeticFast(Vector256<int> value, int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount - Fast(将向量的每个有符号元素算术右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>f({ value[i] }, shiftAmount) = { value[i] &lt;&lt; shiftAmount }</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="Vector256.ShiftRightArithmetic(Vector256{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic(Vector256{long}, int)"/> // Since: VectorTraits 1.0
        Vector256<long> ShiftRightArithmeticFast(Vector256<long> value, int shiftAmount);

#endif
    }
}
