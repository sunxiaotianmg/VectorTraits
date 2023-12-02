﻿using System;
using System.Collections.Generic;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Impl {
    partial interface IWVectorTraits256 {
#if NETCOREAPP3_0_OR_GREATER

        /// <summary>
        /// Types with hardware acceleration when running <c>Abs</c> (运行 <c>Abs</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Abs(Vector256{sbyte})"/>
        TypeCodeFlags Abs_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the absolute value of each element in a vector (计算向量中每个元素的绝对值).
        /// Mnemonic: <c>rt[i] := abs(vector[i])</c>.
        /// </summary>
        /// <param name="vector">The vector that will have its absolute value computed (将被计算其绝对值的向量).</param>
        /// <returns>A vector whose elements are the absolute value of the elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中各元素的绝对值).</returns>
        /// <seealso cref="Abs_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Abs{T}(Vector256{T})" />
        Vector256<float> Abs(Vector256<float> vector);

        /// <summary>
        /// Computes the absolute value of each element in a vector (计算向量中每个元素的绝对值).
        /// Mnemonic: <c>rt[i] := abs(vector[i])</c>.
        /// </summary>
        /// <param name="vector">The vector that will have its absolute value computed (将被计算其绝对值的向量).</param>
        /// <returns>A vector whose elements are the absolute value of the elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中各元素的绝对值).</returns>
        /// <seealso cref="Abs_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Abs{T}(Vector256{T})" />
        Vector256<double> Abs(Vector256<double> vector);

        /// <summary>
        /// Computes the absolute value of each element in a vector (计算向量中每个元素的绝对值).
        /// Mnemonic: <c>rt[i] := abs(vector[i])</c>.
        /// </summary>
        /// <param name="vector">The vector that will have its absolute value computed (将被计算其绝对值的向量).</param>
        /// <returns>A vector whose elements are the absolute value of the elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中各元素的绝对值).</returns>
        /// <seealso cref="Abs_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Abs{T}(Vector256{T})" />
        Vector256<sbyte> Abs(Vector256<sbyte> vector);

        /// <summary>
        /// Computes the absolute value of each element in a vector (计算向量中每个元素的绝对值).
        /// Mnemonic: <c>rt[i] := abs(vector[i])</c>.
        /// </summary>
        /// <param name="vector">The vector that will have its absolute value computed (将被计算其绝对值的向量).</param>
        /// <returns>A vector whose elements are the absolute value of the elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中各元素的绝对值).</returns>
        /// <seealso cref="Abs_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Abs{T}(Vector256{T})" />
        Vector256<short> Abs(Vector256<short> vector);

        /// <summary>
        /// Computes the absolute value of each element in a vector (计算向量中每个元素的绝对值).
        /// Mnemonic: <c>rt[i] := abs(vector[i])</c>.
        /// </summary>
        /// <param name="vector">The vector that will have its absolute value computed (将被计算其绝对值的向量).</param>
        /// <returns>A vector whose elements are the absolute value of the elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中各元素的绝对值).</returns>
        /// <seealso cref="Abs_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Abs{T}(Vector256{T})" />
        Vector256<int> Abs(Vector256<int> vector);

        /// <summary>
        /// Computes the absolute value of each element in a vector (计算向量中每个元素的绝对值).
        /// Mnemonic: <c>rt[i] := abs(vector[i])</c>.
        /// </summary>
        /// <param name="vector">The vector that will have its absolute value computed (将被计算其绝对值的向量).</param>
        /// <returns>A vector whose elements are the absolute value of the elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中各元素的绝对值).</returns>
        /// <seealso cref="Abs_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Abs{T}(Vector256{T})" />
        Vector256<long> Abs(Vector256<long> vector);


        /// <summary>
        /// Types with hardware acceleration when running <c>Add</c> (运行 <c>Add</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Add(Vector256{byte}, Vector256{byte})"/>
        TypeCodeFlags Add_AcceleratedTypes { get; }

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Add{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<float> Add(Vector256<float> left, Vector256<float> right);

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Add{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<double> Add(Vector256<double> left, Vector256<double> right);

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Add{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<sbyte> Add(Vector256<sbyte> left, Vector256<sbyte> right);

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Add{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<byte> Add(Vector256<byte> left, Vector256<byte> right);

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Add{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<short> Add(Vector256<short> left, Vector256<short> right);

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Add{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<ushort> Add(Vector256<ushort> left, Vector256<ushort> right);

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Add{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<int> Add(Vector256<int> left, Vector256<int> right);

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Add{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<uint> Add(Vector256<uint> left, Vector256<uint> right);

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Add{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<long> Add(Vector256<long> left, Vector256<long> right);

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Add{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<ulong> Add(Vector256<ulong> left, Vector256<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>AndNot</c> (运行 <c>AndNot</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="AndNot"/>
        TypeCodeFlags AndNot_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the bitwise-and of a given vector and the ones complement of another vector (计算一个给定的向量和另一个向量反码的位与).
        /// Mnemonic: <c>rt[i] := left[i] &amp; ~right[i]</c>.
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="left">The vector to bitwise-and with <paramref name="right" /> (将会与<paramref name="right" />进行位与运算的向量).</param>
        /// <param name="right">The vector to that is ones-complemented before being bitwise-and with <paramref name="left" /> (将会与<paramref name="left" />进行位与运算, 并使用反码的向量).</param>
        /// <returns>The bitwise-and of <paramref name="left" /> and the ones-complement of <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />反码 的位与运算结果).</returns>
        /// <seealso cref="AndNot_AcceleratedTypes"/>
        /// <seealso cref="Vector256.AndNot{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<T> AndNot<T>(Vector256<T> left, Vector256<T> right) where T : struct;


        /// <summary>
        /// Types with hardware acceleration when running <c>BitwiseAnd</c> (运行 <c>BitwiseAnd</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="BitwiseAnd"/>
        TypeCodeFlags BitwiseAnd_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the bitwise-and of two vectors (计算两个向量的位与).
        /// Mnemonic: <c>rt[i] := left[i] &amp; right[i]</c>.
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="left">The vector to bitwise-and with <paramref name="right" /> (将会与<paramref name="right" />进行位与运算的向量).</param>
        /// <param name="right">The vector to bitwise-and with <paramref name="left" /> (将会与<paramref name="left" />进行位与运算的向量).</param>
        /// <returns>The bitwise-and of <paramref name="left" /> and <paramref name="right"/> (<paramref name="left" /> 与 <paramref name="right" /> 的位与运算结果).</returns>
        /// <seealso cref="BitwiseAnd_AcceleratedTypes"/>
        /// <seealso cref="Vector256.BitwiseAnd{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<T> BitwiseAnd<T>(Vector256<T> left, Vector256<T> right) where T : struct;


        /// <summary>
        /// Types with hardware acceleration when running <c>BitwiseOr</c> (运行 <c>BitwiseOr</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="BitwiseOr"/>
        TypeCodeFlags BitwiseOr_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the bitwise-or of two vectors (计算两个向量的位或).
        /// Mnemonic: <c>rt[i] := left[i] | right[i]</c>.
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="left">The vector to bitwise-or with <paramref name="right" /> (将会与<paramref name="right" />进行位或运算的向量).</param>
        /// <param name="right">The vector to bitwise-or with <paramref name="left" /> (将会与<paramref name="left" />进行位或运算的向量).</param>
        /// <returns>The bitwise-or of <paramref name="left" /> and <paramref name="right"/> (<paramref name="left" /> 与 <paramref name="right" /> 的位或运算结果).</returns>
        /// <seealso cref="BitwiseOr_AcceleratedTypes"/>
        /// <seealso cref="Vector256.BitwiseOr{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<T> BitwiseOr<T>(Vector256<T> left, Vector256<T> right) where T : struct;


        /// <summary>
        /// Types with hardware acceleration when running <c>ConditionalSelect</c> (运行 <c>ConditionalSelect</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="ConditionalSelect{T}(Vector256{T}, Vector256{T}, Vector256{T})"/>
        TypeCodeFlags ConditionalSelect_AcceleratedTypes { get; }

        /// <summary>
        /// Conditionally selects a value from two vectors on a bitwise basis (按条件从两个向量中按位选择值).
        /// Mnemonic: <c>rt[i] := (left[i] &amp; condition[i]) | (right[i] &amp; ~condition[i])</c>.
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The vector that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的向量).</param>
        /// <param name="right">The vector that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的向量).</param>
        /// <returns>A vector whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个向量，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        /// <seealso cref="ConditionalSelect_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ConditionalSelect{T}(Vector256{T}, Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<T> ConditionalSelect<T>(Vector256<T> condition, Vector256<T> left, Vector256<T> right) where T : struct;

        /// <summary>
        /// Conditionally selects a value from two vectors on a bitwise basis (按条件从两个向量中按位选择值).
        /// Mnemonic: <c>rt[i] := (left[i] &amp; condition[i]) | (right[i] &amp; ~condition[i])</c>.
        /// </summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The vector that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的向量).</param>
        /// <param name="right">The vector that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的向量).</param>
        /// <returns>A vector whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个向量，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        /// <seealso cref="Vector256.ConditionalSelect{T}(Vector256{T}, Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<float> ConditionalSelect(Vector256<int> condition, Vector256<float> left, Vector256<float> right);

        /// <summary>
        /// Conditionally selects a value from two vectors on a bitwise basis (按条件从两个向量中按位选择值).
        /// Mnemonic: <c>rt[i] := (left[i] &amp; condition[i]) | (right[i] &amp; ~condition[i])</c>.
        /// </summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The vector that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的向量).</param>
        /// <param name="right">The vector that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的向量).</param>
        /// <returns>A vector whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个向量，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        /// <seealso cref="Vector256.ConditionalSelect{T}(Vector256{T}, Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<double> ConditionalSelect(Vector256<long> condition, Vector256<double> left, Vector256<double> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>Divide</c> (运行 <c>Divide</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Divide(Vector256{float}, Vector256{float})"/>
        TypeCodeFlags Divide_AcceleratedTypes { get; }

        /// <summary>
        /// Divides two vectors to compute their quotient (将两个向量相除来计算它们的商).
        /// Mnemonic: <c>rt[i] := left[i] / right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to divided with <paramref name="right" /> (将会与<paramref name="right" />进行相除的向量).</param>
        /// <param name="right">The vector that will divide left <paramref name="left" /> (将会与<paramref name="left" />进行相除的向量).</param>
        /// <returns>The quotient of <paramref name="left" /> divided <paramref name="right" /> (<paramref name="left" /> 除以 <paramref name="right" />的商).</returns>
        /// <seealso cref="Divide_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Divide{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<float> Divide(Vector256<float> left, Vector256<float> right);

        /// <summary>
        /// Divides two vectors to compute their quotient (将两个向量相除来计算它们的商).
        /// Mnemonic: <c>rt[i] := left[i] / right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to divided with <paramref name="right" /> (将会与<paramref name="right" />进行相除的向量).</param>
        /// <param name="right">The vector that will divide left <paramref name="left" /> (将会与<paramref name="left" />进行相除的向量).</param>
        /// <returns>The quotient of <paramref name="left" /> divided <paramref name="right" /> (<paramref name="left" /> 除以 <paramref name="right" />的商).</returns>
        /// <seealso cref="Divide_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Divide{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<double> Divide(Vector256<double> left, Vector256<double> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>Dot</c> (运行 <c>Dot</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Dot(Vector256{byte}, Vector256{byte})"/>
        TypeCodeFlags Dot_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the dot product of two vectors (计算两个向量的点积).
        /// Mnemonic: <c>rt := left[0]*right[0] + left[1]*right[1] + left[2]*right[2] + ... + left[Count-1]*right[Count-1]</c>.
        /// </summary>
        /// <param name="left">The vector that will be dotted with <paramref name="right" /> (将会与<paramref name="right" />进行点积的向量).</param>
        /// <param name="right">The vector that will be dotted with <paramref name="left" /> (将会与<paramref name="left" />进行点积的向量).</param>
        /// <returns>The dot product of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的点积).</returns>
        /// <seealso cref="Dot_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Dot{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        float Dot(Vector256<float> left, Vector256<float> right);

        /// <summary>
        /// Computes the dot product of two vectors (计算两个向量的点积).
        /// Mnemonic: <c>rt := left[0]*right[0] + left[1]*right[1] + left[2]*right[2] + ... + left[Count-1]*right[Count-1]</c>.
        /// </summary>
        /// <param name="left">The vector that will be dotted with <paramref name="right" /> (将会与<paramref name="right" />进行点积的向量).</param>
        /// <param name="right">The vector that will be dotted with <paramref name="left" /> (将会与<paramref name="left" />进行点积的向量).</param>
        /// <returns>The dot product of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的点积).</returns>
        /// <seealso cref="Dot_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Dot{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        double Dot(Vector256<double> left, Vector256<double> right);

        /// <summary>
        /// Computes the dot product of two vectors (计算两个向量的点积).
        /// Mnemonic: <c>rt := left[0]*right[0] + left[1]*right[1] + left[2]*right[2] + ... + left[Count-1]*right[Count-1]</c>.
        /// </summary>
        /// <param name="left">The vector that will be dotted with <paramref name="right" /> (将会与<paramref name="right" />进行点积的向量).</param>
        /// <param name="right">The vector that will be dotted with <paramref name="left" /> (将会与<paramref name="left" />进行点积的向量).</param>
        /// <returns>The dot product of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的点积).</returns>
        /// <seealso cref="Dot_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Dot{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        sbyte Dot(Vector256<sbyte> left, Vector256<sbyte> right);

        /// <summary>
        /// Computes the dot product of two vectors (计算两个向量的点积).
        /// Mnemonic: <c>rt := left[0]*right[0] + left[1]*right[1] + left[2]*right[2] + ... + left[Count-1]*right[Count-1]</c>.
        /// </summary>
        /// <param name="left">The vector that will be dotted with <paramref name="right" /> (将会与<paramref name="right" />进行点积的向量).</param>
        /// <param name="right">The vector that will be dotted with <paramref name="left" /> (将会与<paramref name="left" />进行点积的向量).</param>
        /// <returns>The dot product of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的点积).</returns>
        /// <seealso cref="Dot_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Dot{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        byte Dot(Vector256<byte> left, Vector256<byte> right);

        /// <summary>
        /// Computes the dot product of two vectors (计算两个向量的点积).
        /// Mnemonic: <c>rt := left[0]*right[0] + left[1]*right[1] + left[2]*right[2] + ... + left[Count-1]*right[Count-1]</c>.
        /// </summary>
        /// <param name="left">The vector that will be dotted with <paramref name="right" /> (将会与<paramref name="right" />进行点积的向量).</param>
        /// <param name="right">The vector that will be dotted with <paramref name="left" /> (将会与<paramref name="left" />进行点积的向量).</param>
        /// <returns>The dot product of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的点积).</returns>
        /// <seealso cref="Dot_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Dot{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        short Dot(Vector256<short> left, Vector256<short> right);

        /// <summary>
        /// Computes the dot product of two vectors (计算两个向量的点积).
        /// Mnemonic: <c>rt := left[0]*right[0] + left[1]*right[1] + left[2]*right[2] + ... + left[Count-1]*right[Count-1]</c>.
        /// </summary>
        /// <param name="left">The vector that will be dotted with <paramref name="right" /> (将会与<paramref name="right" />进行点积的向量).</param>
        /// <param name="right">The vector that will be dotted with <paramref name="left" /> (将会与<paramref name="left" />进行点积的向量).</param>
        /// <returns>The dot product of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的点积).</returns>
        /// <seealso cref="Dot_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Dot{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        ushort Dot(Vector256<ushort> left, Vector256<ushort> right);

        /// <summary>
        /// Computes the dot product of two vectors (计算两个向量的点积).
        /// Mnemonic: <c>rt := left[0]*right[0] + left[1]*right[1] + left[2]*right[2] + ... + left[Count-1]*right[Count-1]</c>.
        /// </summary>
        /// <param name="left">The vector that will be dotted with <paramref name="right" /> (将会与<paramref name="right" />进行点积的向量).</param>
        /// <param name="right">The vector that will be dotted with <paramref name="left" /> (将会与<paramref name="left" />进行点积的向量).</param>
        /// <returns>The dot product of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的点积).</returns>
        /// <seealso cref="Dot_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Dot{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        int Dot(Vector256<int> left, Vector256<int> right);

        /// <summary>
        /// Computes the dot product of two vectors (计算两个向量的点积).
        /// Mnemonic: <c>rt := left[0]*right[0] + left[1]*right[1] + left[2]*right[2] + ... + left[Count-1]*right[Count-1]</c>.
        /// </summary>
        /// <param name="left">The vector that will be dotted with <paramref name="right" /> (将会与<paramref name="right" />进行点积的向量).</param>
        /// <param name="right">The vector that will be dotted with <paramref name="left" /> (将会与<paramref name="left" />进行点积的向量).</param>
        /// <returns>The dot product of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的点积).</returns>
        /// <seealso cref="Dot_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Dot{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        uint Dot(Vector256<uint> left, Vector256<uint> right);

        /// <summary>
        /// Computes the dot product of two vectors (计算两个向量的点积).
        /// Mnemonic: <c>rt := left[0]*right[0] + left[1]*right[1] + left[2]*right[2] + ... + left[Count-1]*right[Count-1]</c>.
        /// </summary>
        /// <param name="left">The vector that will be dotted with <paramref name="right" /> (将会与<paramref name="right" />进行点积的向量).</param>
        /// <param name="right">The vector that will be dotted with <paramref name="left" /> (将会与<paramref name="left" />进行点积的向量).</param>
        /// <returns>The dot product of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的点积).</returns>
        /// <seealso cref="Dot_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Dot{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        long Dot(Vector256<long> left, Vector256<long> right);

        /// <summary>
        /// Computes the dot product of two vectors (计算两个向量的点积).
        /// Mnemonic: <c>rt := left[0]*right[0] + left[1]*right[1] + left[2]*right[2] + ... + left[Count-1]*right[Count-1]</c>.
        /// </summary>
        /// <param name="left">The vector that will be dotted with <paramref name="right" /> (将会与<paramref name="right" />进行点积的向量).</param>
        /// <param name="right">The vector that will be dotted with <paramref name="left" /> (将会与<paramref name="left" />进行点积的向量).</param>
        /// <returns>The dot product of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的点积).</returns>
        /// <seealso cref="Dot_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Dot{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        ulong Dot(Vector256<ulong> left, Vector256<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>Equals</c> (运行 <c>Equals</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Equals(Vector256{byte}, Vector256{byte})"/>
        TypeCodeFlags Equals_AcceleratedTypes { get; }

        /// <summary>
        /// Compares two vectors to determine if they are equal on a per-element basis (比较两个向量，确定它们每个元素是否相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] == right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否相等).</returns>
        /// <seealso cref="Equals_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Equals{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<float> Equals(Vector256<float> left, Vector256<float> right);

        /// <summary>
        /// Compares two vectors to determine if they are equal on a per-element basis (比较两个向量，确定它们每个元素是否相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] == right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否相等).</returns>
        /// <seealso cref="Equals_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Equals{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<double> Equals(Vector256<double> left, Vector256<double> right);

        /// <summary>
        /// Compares two vectors to determine if they are equal on a per-element basis (比较两个向量，确定它们每个元素是否相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] == right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否相等).</returns>
        /// <seealso cref="Equals_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Equals{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<sbyte> Equals(Vector256<sbyte> left, Vector256<sbyte> right);

        /// <summary>
        /// Compares two vectors to determine if they are equal on a per-element basis (比较两个向量，确定它们每个元素是否相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] == right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否相等).</returns>
        /// <seealso cref="Equals_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Equals{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<byte> Equals(Vector256<byte> left, Vector256<byte> right);

        /// <summary>
        /// Compares two vectors to determine if they are equal on a per-element basis (比较两个向量，确定它们每个元素是否相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] == right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否相等).</returns>
        /// <seealso cref="Equals_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Equals{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<short> Equals(Vector256<short> left, Vector256<short> right);

        /// <summary>
        /// Compares two vectors to determine if they are equal on a per-element basis (比较两个向量，确定它们每个元素是否相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] == right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否相等).</returns>
        /// <seealso cref="Equals_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Equals{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<ushort> Equals(Vector256<ushort> left, Vector256<ushort> right);

        /// <summary>
        /// Compares two vectors to determine if they are equal on a per-element basis (比较两个向量，确定它们每个元素是否相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] == right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否相等).</returns>
        /// <seealso cref="Equals_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Equals{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<int> Equals(Vector256<int> left, Vector256<int> right);

        /// <summary>
        /// Compares two vectors to determine if they are equal on a per-element basis (比较两个向量，确定它们每个元素是否相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] == right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否相等).</returns>
        /// <seealso cref="Equals_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Equals{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<uint> Equals(Vector256<uint> left, Vector256<uint> right);

        /// <summary>
        /// Compares two vectors to determine if they are equal on a per-element basis (比较两个向量，确定它们每个元素是否相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] == right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否相等).</returns>
        /// <seealso cref="Equals_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Equals{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<long> Equals(Vector256<long> left, Vector256<long> right);

        /// <summary>
        /// Compares two vectors to determine if they are equal on a per-element basis (比较两个向量，确定它们每个元素是否相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] == right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否相等).</returns>
        /// <seealso cref="Equals_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Equals{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<ulong> Equals(Vector256<ulong> left, Vector256<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>EqualsAll</c> (运行 <c>EqualsAll</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="EqualsAll(Vector256{byte}, Vector256{byte})"/>
        TypeCodeFlags EqualsAll_AcceleratedTypes { get; }

        /// <summary>
        /// Compares two vectors to determine if all elements are equal (比较两个向量以判定所有元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) &amp;&amp; (left[1] == right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.EqualsAll{T}(Vector256{T}, Vector256{T})"/>
        bool EqualsAll(Vector256<float> left, Vector256<float> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are equal (比较两个向量以判定所有元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) &amp;&amp; (left[1] == right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.EqualsAll{T}(Vector256{T}, Vector256{T})"/>
        bool EqualsAll(Vector256<double> left, Vector256<double> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are equal (比较两个向量以判定所有元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) &amp;&amp; (left[1] == right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.EqualsAll{T}(Vector256{T}, Vector256{T})"/>
        bool EqualsAll(Vector256<sbyte> left, Vector256<sbyte> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are equal (比较两个向量以判定所有元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) &amp;&amp; (left[1] == right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.EqualsAll{T}(Vector256{T}, Vector256{T})"/>
        bool EqualsAll(Vector256<byte> left, Vector256<byte> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are equal (比较两个向量以判定所有元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) &amp;&amp; (left[1] == right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.EqualsAll{T}(Vector256{T}, Vector256{T})"/>
        bool EqualsAll(Vector256<short> left, Vector256<short> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are equal (比较两个向量以判定所有元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) &amp;&amp; (left[1] == right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.EqualsAll{T}(Vector256{T}, Vector256{T})"/>
        bool EqualsAll(Vector256<ushort> left, Vector256<ushort> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are equal (比较两个向量以判定所有元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) &amp;&amp; (left[1] == right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.EqualsAll{T}(Vector256{T}, Vector256{T})"/>
        bool EqualsAll(Vector256<int> left, Vector256<int> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are equal (比较两个向量以判定所有元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) &amp;&amp; (left[1] == right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.EqualsAll{T}(Vector256{T}, Vector256{T})"/>
        bool EqualsAll(Vector256<uint> left, Vector256<uint> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are equal (比较两个向量以判定所有元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) &amp;&amp; (left[1] == right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.EqualsAll{T}(Vector256{T}, Vector256{T})"/>
        bool EqualsAll(Vector256<long> left, Vector256<long> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are equal (比较两个向量以判定所有元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) &amp;&amp; (left[1] == right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.EqualsAll{T}(Vector256{T}, Vector256{T})"/>
        bool EqualsAll(Vector256<ulong> left, Vector256<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>EqualsAny</c> (运行 <c>EqualsAny</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="EqualsAny(Vector256{byte}, Vector256{byte})"/>
        TypeCodeFlags EqualsAny_AcceleratedTypes { get; }

        /// <summary>
        /// Compares two vectors to determine if any elements are equal (比较两个向量以判定任一元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) || (left[1] == right[1]) || ... || (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.EqualsAny{T}(Vector256{T}, Vector256{T})"/>
        bool EqualsAny(Vector256<float> left, Vector256<float> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are equal (比较两个向量以判定任一元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) || (left[1] == right[1]) || ... || (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.EqualsAny{T}(Vector256{T}, Vector256{T})"/>
        bool EqualsAny(Vector256<double> left, Vector256<double> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are equal (比较两个向量以判定任一元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) || (left[1] == right[1]) || ... || (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.EqualsAny{T}(Vector256{T}, Vector256{T})"/>
        bool EqualsAny(Vector256<sbyte> left, Vector256<sbyte> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are equal (比较两个向量以判定任一元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) || (left[1] == right[1]) || ... || (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.EqualsAny{T}(Vector256{T}, Vector256{T})"/>
        bool EqualsAny(Vector256<byte> left, Vector256<byte> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are equal (比较两个向量以判定任一元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) || (left[1] == right[1]) || ... || (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.EqualsAny{T}(Vector256{T}, Vector256{T})"/>
        bool EqualsAny(Vector256<short> left, Vector256<short> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are equal (比较两个向量以判定任一元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) || (left[1] == right[1]) || ... || (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.EqualsAny{T}(Vector256{T}, Vector256{T})"/>
        bool EqualsAny(Vector256<ushort> left, Vector256<ushort> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are equal (比较两个向量以判定任一元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) || (left[1] == right[1]) || ... || (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.EqualsAny{T}(Vector256{T}, Vector256{T})"/>
        bool EqualsAny(Vector256<int> left, Vector256<int> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are equal (比较两个向量以判定任一元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) || (left[1] == right[1]) || ... || (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.EqualsAny{T}(Vector256{T}, Vector256{T})"/>
        bool EqualsAny(Vector256<uint> left, Vector256<uint> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are equal (比较两个向量以判定任一元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) || (left[1] == right[1]) || ... || (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.EqualsAny{T}(Vector256{T}, Vector256{T})"/>
        bool EqualsAny(Vector256<long> left, Vector256<long> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are equal (比较两个向量以判定任一元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) || (left[1] == right[1]) || ... || (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.EqualsAny{T}(Vector256{T}, Vector256{T})"/>
        bool EqualsAny(Vector256<ulong> left, Vector256<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>GreaterThan</c> (运行 <c>GreaterThan</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="GreaterThan(Vector256{byte}, Vector256{byte})"/>
        TypeCodeFlags GreaterThan_AcceleratedTypes { get; }

        /// <summary>
        /// Compares two vectors to determine which is greater on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更大).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大).</returns>
        /// <seealso cref="GreaterThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<float> GreaterThan(Vector256<float> left, Vector256<float> right);

        /// <summary>
        /// Compares two vectors to determine which is greater on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更大).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大).</returns>
        /// <seealso cref="GreaterThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<double> GreaterThan(Vector256<double> left, Vector256<double> right);

        /// <summary>
        /// Compares two vectors to determine which is greater on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更大).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大).</returns>
        /// <seealso cref="GreaterThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<sbyte> GreaterThan(Vector256<sbyte> left, Vector256<sbyte> right);

        /// <summary>
        /// Compares two vectors to determine which is greater on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更大).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大).</returns>
        /// <seealso cref="GreaterThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<byte> GreaterThan(Vector256<byte> left, Vector256<byte> right);

        /// <summary>
        /// Compares two vectors to determine which is greater on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更大).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大).</returns>
        /// <seealso cref="GreaterThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<short> GreaterThan(Vector256<short> left, Vector256<short> right);

        /// <summary>
        /// Compares two vectors to determine which is greater on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更大).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大).</returns>
        /// <seealso cref="GreaterThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<ushort> GreaterThan(Vector256<ushort> left, Vector256<ushort> right);

        /// <summary>
        /// Compares two vectors to determine which is greater on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更大).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大).</returns>
        /// <seealso cref="GreaterThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<int> GreaterThan(Vector256<int> left, Vector256<int> right);

        /// <summary>
        /// Compares two vectors to determine which is greater on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更大).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大).</returns>
        /// <seealso cref="GreaterThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<uint> GreaterThan(Vector256<uint> left, Vector256<uint> right);

        /// <summary>
        /// Compares two vectors to determine which is greater on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更大).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大).</returns>
        /// <seealso cref="GreaterThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<long> GreaterThan(Vector256<long> left, Vector256<long> right);

        /// <summary>
        /// Compares two vectors to determine which is greater on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更大).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大).</returns>
        /// <seealso cref="GreaterThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<ulong> GreaterThan(Vector256<ulong> left, Vector256<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>GreaterThanAll</c> (运行 <c>GreaterThanAll</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="GreaterThanAll(Vector256{byte}, Vector256{byte})"/>
        TypeCodeFlags GreaterThanAll_AcceleratedTypes { get; }

        /// <summary>
        /// Compares two vectors to determine if all elements are greater (比较两个向量以判定所有元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) &amp;&amp; (left[1] &gt; right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanAll{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanAll(Vector256<float> left, Vector256<float> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are greater (比较两个向量以判定所有元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) &amp;&amp; (left[1] &gt; right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanAll{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanAll(Vector256<double> left, Vector256<double> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are greater (比较两个向量以判定所有元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) &amp;&amp; (left[1] &gt; right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanAll{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanAll(Vector256<sbyte> left, Vector256<sbyte> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are greater (比较两个向量以判定所有元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) &amp;&amp; (left[1] &gt; right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanAll{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanAll(Vector256<byte> left, Vector256<byte> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are greater (比较两个向量以判定所有元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) &amp;&amp; (left[1] &gt; right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanAll{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanAll(Vector256<short> left, Vector256<short> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are greater (比较两个向量以判定所有元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) &amp;&amp; (left[1] &gt; right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanAll{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanAll(Vector256<ushort> left, Vector256<ushort> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are greater (比较两个向量以判定所有元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) &amp;&amp; (left[1] &gt; right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanAll{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanAll(Vector256<int> left, Vector256<int> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are greater (比较两个向量以判定所有元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) &amp;&amp; (left[1] &gt; right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanAll{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanAll(Vector256<uint> left, Vector256<uint> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are greater (比较两个向量以判定所有元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) &amp;&amp; (left[1] &gt; right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanAll{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanAll(Vector256<long> left, Vector256<long> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are greater (比较两个向量以判定所有元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) &amp;&amp; (left[1] &gt; right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanAll{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanAll(Vector256<ulong> left, Vector256<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>GreaterThanAny</c> (运行 <c>GreaterThanAny</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="GreaterThanAny(Vector256{byte}, Vector256{byte})"/>
        TypeCodeFlags GreaterThanAny_AcceleratedTypes { get; }

        /// <summary>
        /// Compares two vectors to determine if any elements are greater (比较两个向量以判定任一元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) || (left[1] &gt; right[1]) || ... || (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanAny{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanAny(Vector256<float> left, Vector256<float> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are greater (比较两个向量以判定任一元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) || (left[1] &gt; right[1]) || ... || (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanAny{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanAny(Vector256<double> left, Vector256<double> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are greater (比较两个向量以判定任一元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) || (left[1] &gt; right[1]) || ... || (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanAny{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanAny(Vector256<sbyte> left, Vector256<sbyte> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are greater (比较两个向量以判定任一元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) || (left[1] &gt; right[1]) || ... || (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanAny{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanAny(Vector256<byte> left, Vector256<byte> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are greater (比较两个向量以判定任一元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) || (left[1] &gt; right[1]) || ... || (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanAny{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanAny(Vector256<short> left, Vector256<short> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are greater (比较两个向量以判定任一元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) || (left[1] &gt; right[1]) || ... || (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanAny{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanAny(Vector256<ushort> left, Vector256<ushort> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are greater (比较两个向量以判定任一元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) || (left[1] &gt; right[1]) || ... || (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanAny{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanAny(Vector256<int> left, Vector256<int> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are greater (比较两个向量以判定任一元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) || (left[1] &gt; right[1]) || ... || (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanAny{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanAny(Vector256<uint> left, Vector256<uint> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are greater (比较两个向量以判定任一元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) || (left[1] &gt; right[1]) || ... || (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanAny{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanAny(Vector256<long> left, Vector256<long> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are greater (比较两个向量以判定任一元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) || (left[1] &gt; right[1]) || ... || (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanAny{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanAny(Vector256<ulong> left, Vector256<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>GreaterThanOrEqual</c> (运行 <c>GreaterThanOrEqual</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="GreaterThanOrEqual(Vector256{byte}, Vector256{byte})"/>
        TypeCodeFlags GreaterThanOrEqual_AcceleratedTypes { get; }

        /// <summary>
        /// Compares two vectors to determine which is greater or equal on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更大或等于).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt;= right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater or equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大或等于).</returns>
        /// <seealso cref="GreaterThanOrEqual_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanOrEqual{T}(Vector256{T}, Vector256{T})"/>
        Vector256<float> GreaterThanOrEqual(Vector256<float> left, Vector256<float> right);

        /// <summary>
        /// Compares two vectors to determine which is greater or equal on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更大或等于).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt;= right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater or equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大或等于).</returns>
        /// <seealso cref="GreaterThanOrEqual_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanOrEqual{T}(Vector256{T}, Vector256{T})"/>
        Vector256<double> GreaterThanOrEqual(Vector256<double> left, Vector256<double> right);

        /// <summary>
        /// Compares two vectors to determine which is greater or equal on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更大或等于).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt;= right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater or equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大或等于).</returns>
        /// <seealso cref="GreaterThanOrEqual_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanOrEqual{T}(Vector256{T}, Vector256{T})"/>
        Vector256<sbyte> GreaterThanOrEqual(Vector256<sbyte> left, Vector256<sbyte> right);

        /// <summary>
        /// Compares two vectors to determine which is greater or equal on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更大或等于).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt;= right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater or equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大或等于).</returns>
        /// <seealso cref="GreaterThanOrEqual_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanOrEqual{T}(Vector256{T}, Vector256{T})"/>
        Vector256<byte> GreaterThanOrEqual(Vector256<byte> left, Vector256<byte> right);

        /// <summary>
        /// Compares two vectors to determine which is greater or equal on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更大或等于).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt;= right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater or equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大或等于).</returns>
        /// <seealso cref="GreaterThanOrEqual_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanOrEqual{T}(Vector256{T}, Vector256{T})"/>
        Vector256<short> GreaterThanOrEqual(Vector256<short> left, Vector256<short> right);

        /// <summary>
        /// Compares two vectors to determine which is greater or equal on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更大或等于).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt;= right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater or equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大或等于).</returns>
        /// <seealso cref="GreaterThanOrEqual_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanOrEqual{T}(Vector256{T}, Vector256{T})"/>
        Vector256<ushort> GreaterThanOrEqual(Vector256<ushort> left, Vector256<ushort> right);

        /// <summary>
        /// Compares two vectors to determine which is greater or equal on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更大或等于).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt;= right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater or equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大或等于).</returns>
        /// <seealso cref="GreaterThanOrEqual_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanOrEqual{T}(Vector256{T}, Vector256{T})"/>
        Vector256<int> GreaterThanOrEqual(Vector256<int> left, Vector256<int> right);

        /// <summary>
        /// Compares two vectors to determine which is greater or equal on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更大或等于).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt;= right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater or equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大或等于).</returns>
        /// <seealso cref="GreaterThanOrEqual_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanOrEqual{T}(Vector256{T}, Vector256{T})"/>
        Vector256<uint> GreaterThanOrEqual(Vector256<uint> left, Vector256<uint> right);

        /// <summary>
        /// Compares two vectors to determine which is greater or equal on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更大或等于).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt;= right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater or equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大或等于).</returns>
        /// <seealso cref="GreaterThanOrEqual_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanOrEqual{T}(Vector256{T}, Vector256{T})"/>
        Vector256<long> GreaterThanOrEqual(Vector256<long> left, Vector256<long> right);

        /// <summary>
        /// Compares two vectors to determine which is greater or equal on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更大或等于).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt;= right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater or equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大或等于).</returns>
        /// <seealso cref="GreaterThanOrEqual_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanOrEqual{T}(Vector256{T}, Vector256{T})"/>
        Vector256<ulong> GreaterThanOrEqual(Vector256<ulong> left, Vector256<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>GreaterThanOrEqualAll</c> (运行 <c>GreaterThanOrEqualAll</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="GreaterThanOrEqualAll(Vector256{byte}, Vector256{byte})"/>
        TypeCodeFlags GreaterThanOrEqualAll_AcceleratedTypes { get; }

        /// <summary>
        /// Compares two vectors to determine if all elements are greater or equal (比较两个向量以判定所有元素是否大于或等于).
        /// Mnemonic: <c>rt := (left[0] &gt;= right[0]) &amp;&amp; (left[1] &gt;= right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &gt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were greater or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素大于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanOrEqualAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanOrEqualAll{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanOrEqualAll(Vector256<float> left, Vector256<float> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are greater or equal (比较两个向量以判定所有元素是否大于或等于).
        /// Mnemonic: <c>rt := (left[0] &gt;= right[0]) &amp;&amp; (left[1] &gt;= right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &gt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were greater or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素大于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanOrEqualAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanOrEqualAll{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanOrEqualAll(Vector256<double> left, Vector256<double> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are greater or equal (比较两个向量以判定所有元素是否大于或等于).
        /// Mnemonic: <c>rt := (left[0] &gt;= right[0]) &amp;&amp; (left[1] &gt;= right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &gt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were greater or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素大于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanOrEqualAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanOrEqualAll{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanOrEqualAll(Vector256<sbyte> left, Vector256<sbyte> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are greater or equal (比较两个向量以判定所有元素是否大于或等于).
        /// Mnemonic: <c>rt := (left[0] &gt;= right[0]) &amp;&amp; (left[1] &gt;= right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &gt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were greater or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素大于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanOrEqualAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanOrEqualAll{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanOrEqualAll(Vector256<byte> left, Vector256<byte> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are greater or equal (比较两个向量以判定所有元素是否大于或等于).
        /// Mnemonic: <c>rt := (left[0] &gt;= right[0]) &amp;&amp; (left[1] &gt;= right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &gt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were greater or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素大于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanOrEqualAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanOrEqualAll{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanOrEqualAll(Vector256<short> left, Vector256<short> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are greater or equal (比较两个向量以判定所有元素是否大于或等于).
        /// Mnemonic: <c>rt := (left[0] &gt;= right[0]) &amp;&amp; (left[1] &gt;= right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &gt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were greater or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素大于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanOrEqualAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanOrEqualAll{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanOrEqualAll(Vector256<ushort> left, Vector256<ushort> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are greater or equal (比较两个向量以判定所有元素是否大于或等于).
        /// Mnemonic: <c>rt := (left[0] &gt;= right[0]) &amp;&amp; (left[1] &gt;= right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &gt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were greater or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素大于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanOrEqualAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanOrEqualAll{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanOrEqualAll(Vector256<int> left, Vector256<int> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are greater or equal (比较两个向量以判定所有元素是否大于或等于).
        /// Mnemonic: <c>rt := (left[0] &gt;= right[0]) &amp;&amp; (left[1] &gt;= right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &gt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were greater or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素大于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanOrEqualAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanOrEqualAll{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanOrEqualAll(Vector256<uint> left, Vector256<uint> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are greater or equal (比较两个向量以判定所有元素是否大于或等于).
        /// Mnemonic: <c>rt := (left[0] &gt;= right[0]) &amp;&amp; (left[1] &gt;= right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &gt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were greater or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素大于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanOrEqualAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanOrEqualAll{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanOrEqualAll(Vector256<long> left, Vector256<long> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are greater or equal (比较两个向量以判定所有元素是否大于或等于).
        /// Mnemonic: <c>rt := (left[0] &gt;= right[0]) &amp;&amp; (left[1] &gt;= right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &gt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were greater or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素大于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanOrEqualAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanOrEqualAll{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanOrEqualAll(Vector256<ulong> left, Vector256<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>GreaterThanOrEqualAny</c> (运行 <c>GreaterThanOrEqualAny</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="GreaterThanOrEqualAny(Vector256{byte}, Vector256{byte})"/>
        TypeCodeFlags GreaterThanOrEqualAny_AcceleratedTypes { get; }

        /// <summary>
        /// Compares two vectors to determine if any elements are greater or equal (比较两个向量以判定任一元素是否大于或等于).
        /// Mnemonic: <c>rt := (left[0] &gt;= right[0]) || (left[1] &gt;= right[1]) || ... || (left[Count-1] &gt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were greater or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素大于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanOrEqualAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanOrEqualAny{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanOrEqualAny(Vector256<float> left, Vector256<float> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are greater or equal (比较两个向量以判定任一元素是否大于或等于).
        /// Mnemonic: <c>rt := (left[0] &gt;= right[0]) || (left[1] &gt;= right[1]) || ... || (left[Count-1] &gt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were greater or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素大于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanOrEqualAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanOrEqualAny{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanOrEqualAny(Vector256<double> left, Vector256<double> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are greater or equal (比较两个向量以判定任一元素是否大于或等于).
        /// Mnemonic: <c>rt := (left[0] &gt;= right[0]) || (left[1] &gt;= right[1]) || ... || (left[Count-1] &gt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were greater or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素大于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanOrEqualAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanOrEqualAny{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanOrEqualAny(Vector256<sbyte> left, Vector256<sbyte> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are greater or equal (比较两个向量以判定任一元素是否大于或等于).
        /// Mnemonic: <c>rt := (left[0] &gt;= right[0]) || (left[1] &gt;= right[1]) || ... || (left[Count-1] &gt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were greater or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素大于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanOrEqualAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanOrEqualAny{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanOrEqualAny(Vector256<byte> left, Vector256<byte> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are greater or equal (比较两个向量以判定任一元素是否大于或等于).
        /// Mnemonic: <c>rt := (left[0] &gt;= right[0]) || (left[1] &gt;= right[1]) || ... || (left[Count-1] &gt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were greater or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素大于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanOrEqualAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanOrEqualAny{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanOrEqualAny(Vector256<short> left, Vector256<short> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are greater or equal (比较两个向量以判定任一元素是否大于或等于).
        /// Mnemonic: <c>rt := (left[0] &gt;= right[0]) || (left[1] &gt;= right[1]) || ... || (left[Count-1] &gt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were greater or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素大于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanOrEqualAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanOrEqualAny{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanOrEqualAny(Vector256<ushort> left, Vector256<ushort> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are greater or equal (比较两个向量以判定任一元素是否大于或等于).
        /// Mnemonic: <c>rt := (left[0] &gt;= right[0]) || (left[1] &gt;= right[1]) || ... || (left[Count-1] &gt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were greater or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素大于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanOrEqualAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanOrEqualAny{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanOrEqualAny(Vector256<int> left, Vector256<int> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are greater or equal (比较两个向量以判定任一元素是否大于或等于).
        /// Mnemonic: <c>rt := (left[0] &gt;= right[0]) || (left[1] &gt;= right[1]) || ... || (left[Count-1] &gt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were greater or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素大于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanOrEqualAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanOrEqualAny{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanOrEqualAny(Vector256<uint> left, Vector256<uint> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are greater or equal (比较两个向量以判定任一元素是否大于或等于).
        /// Mnemonic: <c>rt := (left[0] &gt;= right[0]) || (left[1] &gt;= right[1]) || ... || (left[Count-1] &gt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were greater or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素大于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanOrEqualAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanOrEqualAny{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanOrEqualAny(Vector256<long> left, Vector256<long> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are greater or equal (比较两个向量以判定任一元素是否大于或等于).
        /// Mnemonic: <c>rt := (left[0] &gt;= right[0]) || (left[1] &gt;= right[1]) || ... || (left[Count-1] &gt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were greater or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素大于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanOrEqualAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThanOrEqualAny{T}(Vector256{T}, Vector256{T})"/>
        bool GreaterThanOrEqualAny(Vector256<ulong> left, Vector256<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>LessThan</c> (运行 <c>LessThan</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="LessThan(Vector256{byte}, Vector256{byte})"/>
        TypeCodeFlags LessThan_AcceleratedTypes { get; }

        /// <summary>
        /// Compares two vectors to determine which is less on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更小).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小).</returns>
        /// <seealso cref="LessThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<float> LessThan(Vector256<float> left, Vector256<float> right);

        /// <summary>
        /// Compares two vectors to determine which is less on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更小).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小).</returns>
        /// <seealso cref="LessThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<double> LessThan(Vector256<double> left, Vector256<double> right);

        /// <summary>
        /// Compares two vectors to determine which is less on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更小).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小).</returns>
        /// <seealso cref="LessThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<sbyte> LessThan(Vector256<sbyte> left, Vector256<sbyte> right);

        /// <summary>
        /// Compares two vectors to determine which is less on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更小).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小).</returns>
        /// <seealso cref="LessThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<byte> LessThan(Vector256<byte> left, Vector256<byte> right);

        /// <summary>
        /// Compares two vectors to determine which is less on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更小).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小).</returns>
        /// <seealso cref="LessThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<short> LessThan(Vector256<short> left, Vector256<short> right);

        /// <summary>
        /// Compares two vectors to determine which is less on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更小).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小).</returns>
        /// <seealso cref="LessThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<ushort> LessThan(Vector256<ushort> left, Vector256<ushort> right);

        /// <summary>
        /// Compares two vectors to determine which is less on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更小).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小).</returns>
        /// <seealso cref="LessThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<int> LessThan(Vector256<int> left, Vector256<int> right);

        /// <summary>
        /// Compares two vectors to determine which is less on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更小).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小).</returns>
        /// <seealso cref="LessThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<uint> LessThan(Vector256<uint> left, Vector256<uint> right);

        /// <summary>
        /// Compares two vectors to determine which is less on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更小).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小).</returns>
        /// <seealso cref="LessThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<long> LessThan(Vector256<long> left, Vector256<long> right);

        /// <summary>
        /// Compares two vectors to determine which is less on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更小).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小).</returns>
        /// <seealso cref="LessThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<ulong> LessThan(Vector256<ulong> left, Vector256<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>LessThanAll</c> (运行 <c>LessThanAll</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="LessThanAll(Vector256{byte}, Vector256{byte})"/>
        TypeCodeFlags LessThanAll_AcceleratedTypes { get; }

        /// <summary>
        /// Compares two vectors to determine if all elements are less (比较两个向量以判定所有元素是否小于).
        /// Mnemonic: <c>rt := (left[0] &lt; right[0]) &amp;&amp; (left[1] &lt; right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &lt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were less to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素小于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanAll{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanAll(Vector256<float> left, Vector256<float> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are less (比较两个向量以判定所有元素是否小于).
        /// Mnemonic: <c>rt := (left[0] &lt; right[0]) &amp;&amp; (left[1] &lt; right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &lt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were less to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素小于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanAll{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanAll(Vector256<double> left, Vector256<double> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are less (比较两个向量以判定所有元素是否小于).
        /// Mnemonic: <c>rt := (left[0] &lt; right[0]) &amp;&amp; (left[1] &lt; right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &lt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were less to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素小于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanAll{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanAll(Vector256<sbyte> left, Vector256<sbyte> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are less (比较两个向量以判定所有元素是否小于).
        /// Mnemonic: <c>rt := (left[0] &lt; right[0]) &amp;&amp; (left[1] &lt; right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &lt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were less to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素小于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanAll{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanAll(Vector256<byte> left, Vector256<byte> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are less (比较两个向量以判定所有元素是否小于).
        /// Mnemonic: <c>rt := (left[0] &lt; right[0]) &amp;&amp; (left[1] &lt; right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &lt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were less to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素小于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanAll{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanAll(Vector256<short> left, Vector256<short> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are less (比较两个向量以判定所有元素是否小于).
        /// Mnemonic: <c>rt := (left[0] &lt; right[0]) &amp;&amp; (left[1] &lt; right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &lt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were less to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素小于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanAll{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanAll(Vector256<ushort> left, Vector256<ushort> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are less (比较两个向量以判定所有元素是否小于).
        /// Mnemonic: <c>rt := (left[0] &lt; right[0]) &amp;&amp; (left[1] &lt; right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &lt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were less to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素小于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanAll{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanAll(Vector256<int> left, Vector256<int> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are less (比较两个向量以判定所有元素是否小于).
        /// Mnemonic: <c>rt := (left[0] &lt; right[0]) &amp;&amp; (left[1] &lt; right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &lt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were less to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素小于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanAll{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanAll(Vector256<uint> left, Vector256<uint> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are less (比较两个向量以判定所有元素是否小于).
        /// Mnemonic: <c>rt := (left[0] &lt; right[0]) &amp;&amp; (left[1] &lt; right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &lt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were less to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素小于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanAll{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanAll(Vector256<long> left, Vector256<long> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are less (比较两个向量以判定所有元素是否小于).
        /// Mnemonic: <c>rt := (left[0] &lt; right[0]) &amp;&amp; (left[1] &lt; right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &lt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were less to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素小于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanAll{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanAll(Vector256<ulong> left, Vector256<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>LessThanAny</c> (运行 <c>LessThanAny</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="LessThanAny(Vector256{byte}, Vector256{byte})"/>
        TypeCodeFlags LessThanAny_AcceleratedTypes { get; }

        /// <summary>
        /// Compares two vectors to determine if any elements are less (比较两个向量以判定任一元素是否小于).
        /// Mnemonic: <c>rt := (left[0] &lt; right[0]) || (left[1] &lt; right[1]) || ... || (left[Count-1] &lt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were less to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素小于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanAny{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanAny(Vector256<float> left, Vector256<float> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are less (比较两个向量以判定任一元素是否小于).
        /// Mnemonic: <c>rt := (left[0] &lt; right[0]) || (left[1] &lt; right[1]) || ... || (left[Count-1] &lt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were less to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素小于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanAny{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanAny(Vector256<double> left, Vector256<double> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are less (比较两个向量以判定任一元素是否小于).
        /// Mnemonic: <c>rt := (left[0] &lt; right[0]) || (left[1] &lt; right[1]) || ... || (left[Count-1] &lt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were less to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素小于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanAny{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanAny(Vector256<sbyte> left, Vector256<sbyte> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are less (比较两个向量以判定任一元素是否小于).
        /// Mnemonic: <c>rt := (left[0] &lt; right[0]) || (left[1] &lt; right[1]) || ... || (left[Count-1] &lt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were less to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素小于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanAny{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanAny(Vector256<byte> left, Vector256<byte> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are less (比较两个向量以判定任一元素是否小于).
        /// Mnemonic: <c>rt := (left[0] &lt; right[0]) || (left[1] &lt; right[1]) || ... || (left[Count-1] &lt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were less to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素小于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanAny{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanAny(Vector256<short> left, Vector256<short> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are less (比较两个向量以判定任一元素是否小于).
        /// Mnemonic: <c>rt := (left[0] &lt; right[0]) || (left[1] &lt; right[1]) || ... || (left[Count-1] &lt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were less to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素小于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanAny{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanAny(Vector256<ushort> left, Vector256<ushort> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are less (比较两个向量以判定任一元素是否小于).
        /// Mnemonic: <c>rt := (left[0] &lt; right[0]) || (left[1] &lt; right[1]) || ... || (left[Count-1] &lt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were less to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素小于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanAny{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanAny(Vector256<int> left, Vector256<int> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are less (比较两个向量以判定任一元素是否小于).
        /// Mnemonic: <c>rt := (left[0] &lt; right[0]) || (left[1] &lt; right[1]) || ... || (left[Count-1] &lt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were less to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素小于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanAny{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanAny(Vector256<uint> left, Vector256<uint> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are less (比较两个向量以判定任一元素是否小于).
        /// Mnemonic: <c>rt := (left[0] &lt; right[0]) || (left[1] &lt; right[1]) || ... || (left[Count-1] &lt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were less to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素小于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanAny{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanAny(Vector256<long> left, Vector256<long> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are less (比较两个向量以判定任一元素是否小于).
        /// Mnemonic: <c>rt := (left[0] &lt; right[0]) || (left[1] &lt; right[1]) || ... || (left[Count-1] &lt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were less to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素小于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanAny{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanAny(Vector256<ulong> left, Vector256<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>LessThanOrEqual</c> (运行 <c>LessThanOrEqual</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="LessThanOrEqual(Vector256{byte}, Vector256{byte})"/>
        TypeCodeFlags LessThanOrEqual_AcceleratedTypes { get; }

        /// <summary>
        /// Compares two vectors to determine which is less or equal on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更小或等于).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt;= right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less or equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小或等于).</returns>
        /// <seealso cref="LessThanOrEqual_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanOrEqual{T}(Vector256{T}, Vector256{T})"/>
        Vector256<float> LessThanOrEqual(Vector256<float> left, Vector256<float> right);

        /// <summary>
        /// Compares two vectors to determine which is less or equal on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更小或等于).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt;= right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less or equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小或等于).</returns>
        /// <seealso cref="LessThanOrEqual_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanOrEqual{T}(Vector256{T}, Vector256{T})"/>
        Vector256<double> LessThanOrEqual(Vector256<double> left, Vector256<double> right);

        /// <summary>
        /// Compares two vectors to determine which is less or equal on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更小或等于).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt;= right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less or equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小或等于).</returns>
        /// <seealso cref="LessThanOrEqual_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanOrEqual{T}(Vector256{T}, Vector256{T})"/>
        Vector256<sbyte> LessThanOrEqual(Vector256<sbyte> left, Vector256<sbyte> right);

        /// <summary>
        /// Compares two vectors to determine which is less or equal on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更小或等于).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt;= right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less or equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小或等于).</returns>
        /// <seealso cref="LessThanOrEqual_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanOrEqual{T}(Vector256{T}, Vector256{T})"/>
        Vector256<byte> LessThanOrEqual(Vector256<byte> left, Vector256<byte> right);

        /// <summary>
        /// Compares two vectors to determine which is less or equal on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更小或等于).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt;= right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less or equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小或等于).</returns>
        /// <seealso cref="LessThanOrEqual_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanOrEqual{T}(Vector256{T}, Vector256{T})"/>
        Vector256<short> LessThanOrEqual(Vector256<short> left, Vector256<short> right);

        /// <summary>
        /// Compares two vectors to determine which is less or equal on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更小或等于).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt;= right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less or equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小或等于).</returns>
        /// <seealso cref="LessThanOrEqual_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanOrEqual{T}(Vector256{T}, Vector256{T})"/>
        Vector256<ushort> LessThanOrEqual(Vector256<ushort> left, Vector256<ushort> right);

        /// <summary>
        /// Compares two vectors to determine which is less or equal on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更小或等于).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt;= right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less or equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小或等于).</returns>
        /// <seealso cref="LessThanOrEqual_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanOrEqual{T}(Vector256{T}, Vector256{T})"/>
        Vector256<int> LessThanOrEqual(Vector256<int> left, Vector256<int> right);

        /// <summary>
        /// Compares two vectors to determine which is less or equal on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更小或等于).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt;= right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less or equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小或等于).</returns>
        /// <seealso cref="LessThanOrEqual_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanOrEqual{T}(Vector256{T}, Vector256{T})"/>
        Vector256<uint> LessThanOrEqual(Vector256<uint> left, Vector256<uint> right);

        /// <summary>
        /// Compares two vectors to determine which is less or equal on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更小或等于).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt;= right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less or equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小或等于).</returns>
        /// <seealso cref="LessThanOrEqual_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanOrEqual{T}(Vector256{T}, Vector256{T})"/>
        Vector256<long> LessThanOrEqual(Vector256<long> left, Vector256<long> right);

        /// <summary>
        /// Compares two vectors to determine which is less or equal on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更小或等于).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt;= right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less or equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小或等于).</returns>
        /// <seealso cref="LessThanOrEqual_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanOrEqual{T}(Vector256{T}, Vector256{T})"/>
        Vector256<ulong> LessThanOrEqual(Vector256<ulong> left, Vector256<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>LessThanOrEqualAll</c> (运行 <c>LessThanOrEqualAll</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="LessThanOrEqualAll(Vector256{byte}, Vector256{byte})"/>
        TypeCodeFlags LessThanOrEqualAll_AcceleratedTypes { get; }

        /// <summary>
        /// Compares two vectors to determine if all elements are less or equal (比较两个向量以判定所有元素是否小于或等于).
        /// Mnemonic: <c>rt := (left[0] &lt;= right[0]) &amp;&amp; (left[1] &lt;= right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &lt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were less or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素小于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanOrEqualAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanOrEqualAll{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanOrEqualAll(Vector256<float> left, Vector256<float> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are less or equal (比较两个向量以判定所有元素是否小于或等于).
        /// Mnemonic: <c>rt := (left[0] &lt;= right[0]) &amp;&amp; (left[1] &lt;= right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &lt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were less or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素小于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanOrEqualAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanOrEqualAll{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanOrEqualAll(Vector256<double> left, Vector256<double> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are less or equal (比较两个向量以判定所有元素是否小于或等于).
        /// Mnemonic: <c>rt := (left[0] &lt;= right[0]) &amp;&amp; (left[1] &lt;= right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &lt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were less or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素小于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanOrEqualAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanOrEqualAll{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanOrEqualAll(Vector256<sbyte> left, Vector256<sbyte> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are less or equal (比较两个向量以判定所有元素是否小于或等于).
        /// Mnemonic: <c>rt := (left[0] &lt;= right[0]) &amp;&amp; (left[1] &lt;= right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &lt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were less or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素小于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanOrEqualAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanOrEqualAll{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanOrEqualAll(Vector256<byte> left, Vector256<byte> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are less or equal (比较两个向量以判定所有元素是否小于或等于).
        /// Mnemonic: <c>rt := (left[0] &lt;= right[0]) &amp;&amp; (left[1] &lt;= right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &lt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were less or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素小于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanOrEqualAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanOrEqualAll{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanOrEqualAll(Vector256<short> left, Vector256<short> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are less or equal (比较两个向量以判定所有元素是否小于或等于).
        /// Mnemonic: <c>rt := (left[0] &lt;= right[0]) &amp;&amp; (left[1] &lt;= right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &lt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were less or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素小于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanOrEqualAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanOrEqualAll{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanOrEqualAll(Vector256<ushort> left, Vector256<ushort> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are less or equal (比较两个向量以判定所有元素是否小于或等于).
        /// Mnemonic: <c>rt := (left[0] &lt;= right[0]) &amp;&amp; (left[1] &lt;= right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &lt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were less or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素小于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanOrEqualAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanOrEqualAll{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanOrEqualAll(Vector256<int> left, Vector256<int> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are less or equal (比较两个向量以判定所有元素是否小于或等于).
        /// Mnemonic: <c>rt := (left[0] &lt;= right[0]) &amp;&amp; (left[1] &lt;= right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &lt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were less or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素小于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanOrEqualAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanOrEqualAll{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanOrEqualAll(Vector256<uint> left, Vector256<uint> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are less or equal (比较两个向量以判定所有元素是否小于或等于).
        /// Mnemonic: <c>rt := (left[0] &lt;= right[0]) &amp;&amp; (left[1] &lt;= right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &lt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were less or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素小于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanOrEqualAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanOrEqualAll{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanOrEqualAll(Vector256<long> left, Vector256<long> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are less or equal (比较两个向量以判定所有元素是否小于或等于).
        /// Mnemonic: <c>rt := (left[0] &lt;= right[0]) &amp;&amp; (left[1] &lt;= right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &lt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were less or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素小于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanOrEqualAll_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanOrEqualAll{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanOrEqualAll(Vector256<ulong> left, Vector256<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>LessThanOrEqualAny</c> (运行 <c>LessThanOrEqualAny</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="LessThanOrEqualAny(Vector256{byte}, Vector256{byte})"/>
        TypeCodeFlags LessThanOrEqualAny_AcceleratedTypes { get; }

        /// <summary>
        /// Compares two vectors to determine if any elements are less or equal (比较两个向量以判定任一元素是否小于或等于).
        /// Mnemonic: <c>rt := (left[0] &lt;= right[0]) || (left[1] &lt;= right[1]) || ... || (left[Count-1] &lt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were less or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素小于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanOrEqualAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanOrEqualAny{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanOrEqualAny(Vector256<float> left, Vector256<float> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are less or equal (比较两个向量以判定任一元素是否小于或等于).
        /// Mnemonic: <c>rt := (left[0] &lt;= right[0]) || (left[1] &lt;= right[1]) || ... || (left[Count-1] &lt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were less or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素小于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanOrEqualAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanOrEqualAny{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanOrEqualAny(Vector256<double> left, Vector256<double> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are less or equal (比较两个向量以判定任一元素是否小于或等于).
        /// Mnemonic: <c>rt := (left[0] &lt;= right[0]) || (left[1] &lt;= right[1]) || ... || (left[Count-1] &lt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were less or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素小于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanOrEqualAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanOrEqualAny{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanOrEqualAny(Vector256<sbyte> left, Vector256<sbyte> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are less or equal (比较两个向量以判定任一元素是否小于或等于).
        /// Mnemonic: <c>rt := (left[0] &lt;= right[0]) || (left[1] &lt;= right[1]) || ... || (left[Count-1] &lt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were less or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素小于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanOrEqualAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanOrEqualAny{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanOrEqualAny(Vector256<byte> left, Vector256<byte> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are less or equal (比较两个向量以判定任一元素是否小于或等于).
        /// Mnemonic: <c>rt := (left[0] &lt;= right[0]) || (left[1] &lt;= right[1]) || ... || (left[Count-1] &lt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were less or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素小于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanOrEqualAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanOrEqualAny{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanOrEqualAny(Vector256<short> left, Vector256<short> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are less or equal (比较两个向量以判定任一元素是否小于或等于).
        /// Mnemonic: <c>rt := (left[0] &lt;= right[0]) || (left[1] &lt;= right[1]) || ... || (left[Count-1] &lt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were less or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素小于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanOrEqualAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanOrEqualAny{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanOrEqualAny(Vector256<ushort> left, Vector256<ushort> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are less or equal (比较两个向量以判定任一元素是否小于或等于).
        /// Mnemonic: <c>rt := (left[0] &lt;= right[0]) || (left[1] &lt;= right[1]) || ... || (left[Count-1] &lt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were less or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素小于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanOrEqualAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanOrEqualAny{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanOrEqualAny(Vector256<int> left, Vector256<int> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are less or equal (比较两个向量以判定任一元素是否小于或等于).
        /// Mnemonic: <c>rt := (left[0] &lt;= right[0]) || (left[1] &lt;= right[1]) || ... || (left[Count-1] &lt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were less or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素小于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanOrEqualAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanOrEqualAny{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanOrEqualAny(Vector256<uint> left, Vector256<uint> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are less or equal (比较两个向量以判定任一元素是否小于或等于).
        /// Mnemonic: <c>rt := (left[0] &lt;= right[0]) || (left[1] &lt;= right[1]) || ... || (left[Count-1] &lt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were less or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素小于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanOrEqualAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanOrEqualAny{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanOrEqualAny(Vector256<long> left, Vector256<long> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are less or equal (比较两个向量以判定任一元素是否小于或等于).
        /// Mnemonic: <c>rt := (left[0] &lt;= right[0]) || (left[1] &lt;= right[1]) || ... || (left[Count-1] &lt;= right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were less or equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素小于或等于时返回<c>true</c>).</returns>
        /// <seealso cref="LessThanOrEqualAny_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThanOrEqualAny{T}(Vector256{T}, Vector256{T})"/>
        bool LessThanOrEqualAny(Vector256<ulong> left, Vector256<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>Max</c> (运行 <c>Max</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Max(Vector256{byte}, Vector256{byte})"/>
        TypeCodeFlags Max_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the maximum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最大值).
        /// Mnemonic: <c>rt[i] := max(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the maximum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最大值).</returns>
        /// <seealso cref="Max_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Max{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<float> Max(Vector256<float> left, Vector256<float> right);

        /// <summary>
        /// Computes the maximum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最大值).
        /// Mnemonic: <c>rt[i] := max(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the maximum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最大值).</returns>
        /// <seealso cref="Max_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Max{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<double> Max(Vector256<double> left, Vector256<double> right);

        /// <summary>
        /// Computes the maximum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最大值).
        /// Mnemonic: <c>rt[i] := max(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the maximum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最大值).</returns>
        /// <seealso cref="Max_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Max{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<sbyte> Max(Vector256<sbyte> left, Vector256<sbyte> right);

        /// <summary>
        /// Computes the maximum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最大值).
        /// Mnemonic: <c>rt[i] := max(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the maximum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最大值).</returns>
        /// <seealso cref="Max_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Max{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<byte> Max(Vector256<byte> left, Vector256<byte> right);

        /// <summary>
        /// Computes the maximum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最大值).
        /// Mnemonic: <c>rt[i] := max(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the maximum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最大值).</returns>
        /// <seealso cref="Max_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Max{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<short> Max(Vector256<short> left, Vector256<short> right);

        /// <summary>
        /// Computes the maximum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最大值).
        /// Mnemonic: <c>rt[i] := max(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the maximum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最大值).</returns>
        /// <seealso cref="Max_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Max{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<ushort> Max(Vector256<ushort> left, Vector256<ushort> right);

        /// <summary>
        /// Computes the maximum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最大值).
        /// Mnemonic: <c>rt[i] := max(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the maximum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最大值).</returns>
        /// <seealso cref="Max_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Max{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<int> Max(Vector256<int> left, Vector256<int> right);

        /// <summary>
        /// Computes the maximum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最大值).
        /// Mnemonic: <c>rt[i] := max(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the maximum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最大值).</returns>
        /// <seealso cref="Max_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Max{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<uint> Max(Vector256<uint> left, Vector256<uint> right);

        /// <summary>
        /// Computes the maximum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最大值).
        /// Mnemonic: <c>rt[i] := max(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the maximum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最大值).</returns>
        /// <seealso cref="Max_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Max{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<long> Max(Vector256<long> left, Vector256<long> right);

        /// <summary>
        /// Computes the maximum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最大值).
        /// Mnemonic: <c>rt[i] := max(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the maximum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最大值).</returns>
        /// <seealso cref="Max_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Max{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<ulong> Max(Vector256<ulong> left, Vector256<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>Min</c> (运行 <c>Min</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Min(Vector256{byte}, Vector256{byte})"/>
        TypeCodeFlags Min_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the minimum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最小值).
        /// Mnemonic: <c>rt[i] := min(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the minimum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最小值).</returns>
        /// <seealso cref="Min_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Min{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<float> Min(Vector256<float> left, Vector256<float> right);

        /// <summary>
        /// Computes the minimum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最小值).
        /// Mnemonic: <c>rt[i] := min(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the minimum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最小值).</returns>
        /// <seealso cref="Min_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Min{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<double> Min(Vector256<double> left, Vector256<double> right);

        /// <summary>
        /// Computes the minimum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最小值).
        /// Mnemonic: <c>rt[i] := min(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the minimum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最小值).</returns>
        /// <seealso cref="Min_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Min{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<sbyte> Min(Vector256<sbyte> left, Vector256<sbyte> right);

        /// <summary>
        /// Computes the minimum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最小值).
        /// Mnemonic: <c>rt[i] := min(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the minimum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最小值).</returns>
        /// <seealso cref="Min_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Min{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<byte> Min(Vector256<byte> left, Vector256<byte> right);

        /// <summary>
        /// Computes the minimum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最小值).
        /// Mnemonic: <c>rt[i] := min(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the minimum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最小值).</returns>
        /// <seealso cref="Min_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Min{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<short> Min(Vector256<short> left, Vector256<short> right);

        /// <summary>
        /// Computes the minimum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最小值).
        /// Mnemonic: <c>rt[i] := min(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the minimum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最小值).</returns>
        /// <seealso cref="Min_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Min{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<ushort> Min(Vector256<ushort> left, Vector256<ushort> right);

        /// <summary>
        /// Computes the minimum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最小值).
        /// Mnemonic: <c>rt[i] := min(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the minimum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最小值).</returns>
        /// <seealso cref="Min_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Min{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<int> Min(Vector256<int> left, Vector256<int> right);

        /// <summary>
        /// Computes the minimum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最小值).
        /// Mnemonic: <c>rt[i] := min(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the minimum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最小值).</returns>
        /// <seealso cref="Min_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Min{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<uint> Min(Vector256<uint> left, Vector256<uint> right);

        /// <summary>
        /// Computes the minimum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最小值).
        /// Mnemonic: <c>rt[i] := min(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the minimum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最小值).</returns>
        /// <seealso cref="Min_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Min{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<long> Min(Vector256<long> left, Vector256<long> right);

        /// <summary>
        /// Computes the minimum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最小值).
        /// Mnemonic: <c>rt[i] := min(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the minimum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最小值).</returns>
        /// <seealso cref="Min_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Min{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<ulong> Min(Vector256<ulong> left, Vector256<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>Multiply</c> (运行 <c>Multiply</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Multiply(Vector256{byte}, Vector256{byte})"/>
        /// <seealso cref="Multiply_FullAcceleratedTypes"/>
        TypeCodeFlags Multiply_AcceleratedTypes { get; }

        /// <summary>
        /// Types with full hardware acceleration when running <c>Multiply</c> (运行 <c>Multiply</c> 时具有完全硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>`AcceleratedTypes` only indicates the presence of hardware acceleration, possibly indirectly through some algorithm. And `FullAcceleratedTypes` means that dedicated instructions are used to achieve full hardware acceleration. (`AcceleratedTypes`仅表示存在硬件加速,有可能是通过一些算法间接实现的. 而 `FullAcceleratedTypes`意味着使用了专用指令，实现了完全的硬件加速)</para>
        /// </remarks>
        /// <seealso cref="Multiply(Vector256{byte}, Vector256{byte})"/>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        TypeCodeFlags Multiply_FullAcceleratedTypes { get; }

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们各元素的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Multiply{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<float> Multiply(Vector256<float> left, Vector256<float> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们各元素的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Multiply{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<double> Multiply(Vector256<double> left, Vector256<double> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们各元素的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Multiply{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<sbyte> Multiply(Vector256<sbyte> left, Vector256<sbyte> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们各元素的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Multiply{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<byte> Multiply(Vector256<byte> left, Vector256<byte> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们各元素的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Multiply{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<short> Multiply(Vector256<short> left, Vector256<short> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们各元素的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Multiply{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<ushort> Multiply(Vector256<ushort> left, Vector256<ushort> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们各元素的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Multiply{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<int> Multiply(Vector256<int> left, Vector256<int> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们各元素的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Multiply{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<uint> Multiply(Vector256<uint> left, Vector256<uint> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们各元素的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Multiply{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<long> Multiply(Vector256<long> left, Vector256<long> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们各元素的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Multiply{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<ulong> Multiply(Vector256<ulong> left, Vector256<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>Negate</c> (运行 <c>Negate</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Negate(Vector256{sbyte})"/>
        TypeCodeFlags Negate_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the negate of a vector (计算向量的相反数).
        /// Mnemonic: <c>rt[i] := -vector[i]</c>.
        /// </summary>
        /// <param name="vector">The vector to negate (将计算相反数的向量).</param>
        /// <returns>A vector whose elements are the negate of the elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中各元素的相反数).</returns>
        /// <seealso cref="Negate_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Negate{T}(Vector256{T})" />
        Vector256<float> Negate(Vector256<float> vector);

        /// <summary>
        /// Computes the negate of a vector (计算向量的相反数).
        /// Mnemonic: <c>rt[i] := -vector[i]</c>.
        /// </summary>
        /// <param name="vector">The vector to negate (将计算相反数的向量).</param>
        /// <returns>A vector whose elements are the negate of the elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中各元素的相反数).</returns>
        /// <seealso cref="Negate_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Negate{T}(Vector256{T})" />
        Vector256<double> Negate(Vector256<double> vector);

        /// <summary>
        /// Computes the negate of a vector (计算向量的相反数).
        /// Mnemonic: <c>rt[i] := -vector[i]</c>.
        /// </summary>
        /// <param name="vector">The vector to negate (将计算相反数的向量).</param>
        /// <returns>A vector whose elements are the negate of the elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中各元素的相反数).</returns>
        /// <seealso cref="Negate_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Negate{T}(Vector256{T})" />
        Vector256<sbyte> Negate(Vector256<sbyte> vector);

        /// <summary>
        /// Computes the negate of a vector (计算向量的相反数).
        /// Mnemonic: <c>rt[i] := -vector[i]</c>.
        /// </summary>
        /// <param name="vector">The vector to negate (将计算相反数的向量).</param>
        /// <returns>A vector whose elements are the negate of the elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中各元素的相反数).</returns>
        /// <seealso cref="Negate_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Negate{T}(Vector256{T})" />
        Vector256<short> Negate(Vector256<short> vector);

        /// <summary>
        /// Computes the negate of a vector (计算向量的相反数).
        /// Mnemonic: <c>rt[i] := -vector[i]</c>.
        /// </summary>
        /// <param name="vector">The vector to negate (将计算相反数的向量).</param>
        /// <returns>A vector whose elements are the negate of the elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中各元素的相反数).</returns>
        /// <seealso cref="Negate_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Negate{T}(Vector256{T})" />
        Vector256<int> Negate(Vector256<int> vector);

        /// <summary>
        /// Computes the negate of a vector (计算向量的相反数).
        /// Mnemonic: <c>rt[i] := -vector[i]</c>.
        /// </summary>
        /// <param name="vector">The vector to negate (将计算相反数的向量).</param>
        /// <returns>A vector whose elements are the negate of the elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中各元素的相反数).</returns>
        /// <seealso cref="Negate_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Negate{T}(Vector256{T})" />
        Vector256<long> Negate(Vector256<long> vector);


        /// <summary>
        /// Types with hardware acceleration when running <c>OnesComplement</c> (运行 <c>OnesComplement</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="OnesComplement"/>
        TypeCodeFlags OnesComplement_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the ones-complement of a vector (计算向量的反码).
        /// Mnemonic: <c>rt[i] := ~vector[i]</c>.
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="vector">The vector whose ones-complement is to be computed (要计算其反码的向量).</param>
        /// <returns>A vector whose elements are the ones-complement of the corresponding elements in <paramref name="vector" /> (一个向量，其元素是<paramref name="vector" />相应元素的反码).</returns>
        /// <seealso cref="OnesComplement_AcceleratedTypes"/>
        /// <seealso cref="Vector256.OnesComplement{T}(Vector256{T})"/> // Since: .NET 7
        Vector256<T> OnesComplement<T>(Vector256<T> vector) where T : struct;


        /// <summary>
        /// Types with hardware acceleration when running <c>Sqrt</c> (运行 <c>Sqrt</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Sqrt(Vector256{double})"/>
        /// <seealso cref="BitMath.Sqrt(double)"/>
        TypeCodeFlags Sqrt_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the square root of a vector on a per-element basis (计算向量中每个元素的平方根).
        /// Mnemonic: <c>rt[i] := sqrt(vector[i]) = pow(vector[i], 1.0/2)</c>. When x is less than 0, floating-point types return NaN, integer types return 0.
        /// </summary>
        /// <param name="vector">The vector whose square root is to be computed (将被计算其平方根的向量).</param>
        /// <returns>A vector whose elements are the square root of the corresponding elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中对应元素的平方根).</returns>
        /// <seealso cref="Sqrt_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Sqrt{T}(Vector256{T})" />
        Vector256<float> Sqrt(Vector256<float> vector);

        /// <summary>
        /// Computes the square root of a vector on a per-element basis (计算向量中每个元素的平方根).
        /// Mnemonic: <c>rt[i] := sqrt(vector[i]) = pow(vector[i], 1.0/2)</c>. When x is less than 0, floating-point types return NaN, integer types return 0.
        /// </summary>
        /// <param name="vector">The vector whose square root is to be computed (将被计算其平方根的向量).</param>
        /// <returns>A vector whose elements are the square root of the corresponding elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中对应元素的平方根).</returns>
        /// <seealso cref="Sqrt_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Sqrt{T}(Vector256{T})" />
        Vector256<double> Sqrt(Vector256<double> vector);

        /// <summary>
        /// Computes the square root of a vector on a per-element basis (计算向量中每个元素的平方根).
        /// Mnemonic: <c>rt[i] := sqrt(vector[i]) = pow(vector[i], 1.0/2)</c>. When x is less than 0, floating-point types return NaN, integer types return 0.
        /// </summary>
        /// <param name="vector">The vector whose square root is to be computed (将被计算其平方根的向量).</param>
        /// <returns>A vector whose elements are the square root of the corresponding elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中对应元素的平方根).</returns>
        /// <seealso cref="Sqrt_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Sqrt{T}(Vector256{T})" />
        Vector256<sbyte> Sqrt(Vector256<sbyte> vector);

        /// <summary>
        /// Computes the square root of a vector on a per-element basis (计算向量中每个元素的平方根).
        /// Mnemonic: <c>rt[i] := sqrt(vector[i]) = pow(vector[i], 1.0/2)</c>. When x is less than 0, floating-point types return NaN, integer types return 0.
        /// </summary>
        /// <param name="vector">The vector whose square root is to be computed (将被计算其平方根的向量).</param>
        /// <returns>A vector whose elements are the square root of the corresponding elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中对应元素的平方根).</returns>
        /// <seealso cref="Sqrt_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Sqrt{T}(Vector256{T})" />
        Vector256<byte> Sqrt(Vector256<byte> vector);

        /// <summary>
        /// Computes the square root of a vector on a per-element basis (计算向量中每个元素的平方根).
        /// Mnemonic: <c>rt[i] := sqrt(vector[i]) = pow(vector[i], 1.0/2)</c>. When x is less than 0, floating-point types return NaN, integer types return 0.
        /// </summary>
        /// <param name="vector">The vector whose square root is to be computed (将被计算其平方根的向量).</param>
        /// <returns>A vector whose elements are the square root of the corresponding elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中对应元素的平方根).</returns>
        /// <seealso cref="Sqrt_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Sqrt{T}(Vector256{T})" />
        Vector256<short> Sqrt(Vector256<short> vector);

        /// <summary>
        /// Computes the square root of a vector on a per-element basis (计算向量中每个元素的平方根).
        /// Mnemonic: <c>rt[i] := sqrt(vector[i]) = pow(vector[i], 1.0/2)</c>. When x is less than 0, floating-point types return NaN, integer types return 0.
        /// </summary>
        /// <param name="vector">The vector whose square root is to be computed (将被计算其平方根的向量).</param>
        /// <returns>A vector whose elements are the square root of the corresponding elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中对应元素的平方根).</returns>
        /// <seealso cref="Sqrt_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Sqrt{T}(Vector256{T})" />
        Vector256<ushort> Sqrt(Vector256<ushort> vector);

        /// <summary>
        /// Computes the square root of a vector on a per-element basis (计算向量中每个元素的平方根).
        /// Mnemonic: <c>rt[i] := sqrt(vector[i]) = pow(vector[i], 1.0/2)</c>. When x is less than 0, floating-point types return NaN, integer types return 0.
        /// </summary>
        /// <param name="vector">The vector whose square root is to be computed (将被计算其平方根的向量).</param>
        /// <returns>A vector whose elements are the square root of the corresponding elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中对应元素的平方根).</returns>
        /// <seealso cref="Sqrt_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Sqrt{T}(Vector256{T})" />
        Vector256<int> Sqrt(Vector256<int> vector);

        /// <summary>
        /// Computes the square root of a vector on a per-element basis (计算向量中每个元素的平方根).
        /// Mnemonic: <c>rt[i] := sqrt(vector[i]) = pow(vector[i], 1.0/2)</c>. When x is less than 0, floating-point types return NaN, integer types return 0.
        /// </summary>
        /// <param name="vector">The vector whose square root is to be computed (将被计算其平方根的向量).</param>
        /// <returns>A vector whose elements are the square root of the corresponding elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中对应元素的平方根).</returns>
        /// <seealso cref="Sqrt_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Sqrt{T}(Vector256{T})" />
        Vector256<uint> Sqrt(Vector256<uint> vector);

        /// <summary>
        /// Computes the square root of a vector on a per-element basis (计算向量中每个元素的平方根).
        /// Mnemonic: <c>rt[i] := sqrt(vector[i]) = pow(vector[i], 1.0/2)</c>. When x is less than 0, floating-point types return NaN, integer types return 0.
        /// </summary>
        /// <param name="vector">The vector whose square root is to be computed (将被计算其平方根的向量).</param>
        /// <returns>A vector whose elements are the square root of the corresponding elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中对应元素的平方根).</returns>
        /// <seealso cref="Sqrt_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Sqrt{T}(Vector256{T})" />
        Vector256<long> Sqrt(Vector256<long> vector);

        /// <summary>
        /// Computes the square root of a vector on a per-element basis (计算向量中每个元素的平方根).
        /// Mnemonic: <c>rt[i] := sqrt(vector[i]) = pow(vector[i], 1.0/2)</c>. When x is less than 0, floating-point types return NaN, integer types return 0.
        /// </summary>
        /// <param name="vector">The vector whose square root is to be computed (将被计算其平方根的向量).</param>
        /// <returns>A vector whose elements are the square root of the corresponding elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中对应元素的平方根).</returns>
        /// <seealso cref="Sqrt_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Sqrt{T}(Vector256{T})" />
        Vector256<ulong> Sqrt(Vector256<ulong> vector);


        /// <summary>
        /// Types with hardware acceleration when running <c>Subtract</c> (运行 <c>Subtract</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Subtract(Vector256{byte}, Vector256{byte})"/>
        TypeCodeFlags Subtract_AcceleratedTypes { get; }

        /// <summary>
        /// Subtracts two vectors to compute their difference (将两个向量相减来计算它们的差).
        /// Mnemonic: <c>rt[i] := left[i] - right[i]</c>.
        /// </summary>
        /// <param name="left">The vector from which <paramref name="right" /> will be subtracted (将被减去<paramref name="right" />的向量).</param>
        /// <param name="right">The vector to subtract from <paramref name="left" /> (要从<paramref name="left" />减去的向量).</param>
        /// <returns>The difference of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" />与<paramref name="right" />的差).</returns>
        /// <seealso cref="Subtract_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Subtract{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<float> Subtract(Vector256<float> left, Vector256<float> right);

        /// <summary>
        /// Subtracts two vectors to compute their difference (将两个向量相减来计算它们的差).
        /// Mnemonic: <c>rt[i] := left[i] - right[i]</c>.
        /// </summary>
        /// <param name="left">The vector from which <paramref name="right" /> will be subtracted (将被减去<paramref name="right" />的向量).</param>
        /// <param name="right">The vector to subtract from <paramref name="left" /> (要从<paramref name="left" />减去的向量).</param>
        /// <returns>The difference of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" />与<paramref name="right" />的差).</returns>
        /// <seealso cref="Subtract_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Subtract{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<double> Subtract(Vector256<double> left, Vector256<double> right);

        /// <summary>
        /// Subtracts two vectors to compute their difference (将两个向量相减来计算它们的差).
        /// Mnemonic: <c>rt[i] := left[i] - right[i]</c>.
        /// </summary>
        /// <param name="left">The vector from which <paramref name="right" /> will be subtracted (将被减去<paramref name="right" />的向量).</param>
        /// <param name="right">The vector to subtract from <paramref name="left" /> (要从<paramref name="left" />减去的向量).</param>
        /// <returns>The difference of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" />与<paramref name="right" />的差).</returns>
        /// <seealso cref="Subtract_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Subtract{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<sbyte> Subtract(Vector256<sbyte> left, Vector256<sbyte> right);

        /// <summary>
        /// Subtracts two vectors to compute their difference (将两个向量相减来计算它们的差).
        /// Mnemonic: <c>rt[i] := left[i] - right[i]</c>.
        /// </summary>
        /// <param name="left">The vector from which <paramref name="right" /> will be subtracted (将被减去<paramref name="right" />的向量).</param>
        /// <param name="right">The vector to subtract from <paramref name="left" /> (要从<paramref name="left" />减去的向量).</param>
        /// <returns>The difference of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" />与<paramref name="right" />的差).</returns>
        /// <seealso cref="Subtract_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Subtract{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<byte> Subtract(Vector256<byte> left, Vector256<byte> right);

        /// <summary>
        /// Subtracts two vectors to compute their difference (将两个向量相减来计算它们的差).
        /// Mnemonic: <c>rt[i] := left[i] - right[i]</c>.
        /// </summary>
        /// <param name="left">The vector from which <paramref name="right" /> will be subtracted (将被减去<paramref name="right" />的向量).</param>
        /// <param name="right">The vector to subtract from <paramref name="left" /> (要从<paramref name="left" />减去的向量).</param>
        /// <returns>The difference of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" />与<paramref name="right" />的差).</returns>
        /// <seealso cref="Subtract_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Subtract{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<short> Subtract(Vector256<short> left, Vector256<short> right);

        /// <summary>
        /// Subtracts two vectors to compute their difference (将两个向量相减来计算它们的差).
        /// Mnemonic: <c>rt[i] := left[i] - right[i]</c>.
        /// </summary>
        /// <param name="left">The vector from which <paramref name="right" /> will be subtracted (将被减去<paramref name="right" />的向量).</param>
        /// <param name="right">The vector to subtract from <paramref name="left" /> (要从<paramref name="left" />减去的向量).</param>
        /// <returns>The difference of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" />与<paramref name="right" />的差).</returns>
        /// <seealso cref="Subtract_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Subtract{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<ushort> Subtract(Vector256<ushort> left, Vector256<ushort> right);

        /// <summary>
        /// Subtracts two vectors to compute their difference (将两个向量相减来计算它们的差).
        /// Mnemonic: <c>rt[i] := left[i] - right[i]</c>.
        /// </summary>
        /// <param name="left">The vector from which <paramref name="right" /> will be subtracted (将被减去<paramref name="right" />的向量).</param>
        /// <param name="right">The vector to subtract from <paramref name="left" /> (要从<paramref name="left" />减去的向量).</param>
        /// <returns>The difference of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" />与<paramref name="right" />的差).</returns>
        /// <seealso cref="Subtract_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Subtract{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<int> Subtract(Vector256<int> left, Vector256<int> right);

        /// <summary>
        /// Subtracts two vectors to compute their difference (将两个向量相减来计算它们的差).
        /// Mnemonic: <c>rt[i] := left[i] - right[i]</c>.
        /// </summary>
        /// <param name="left">The vector from which <paramref name="right" /> will be subtracted (将被减去<paramref name="right" />的向量).</param>
        /// <param name="right">The vector to subtract from <paramref name="left" /> (要从<paramref name="left" />减去的向量).</param>
        /// <returns>The difference of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" />与<paramref name="right" />的差).</returns>
        /// <seealso cref="Subtract_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Subtract{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<uint> Subtract(Vector256<uint> left, Vector256<uint> right);

        /// <summary>
        /// Subtracts two vectors to compute their difference (将两个向量相减来计算它们的差).
        /// Mnemonic: <c>rt[i] := left[i] - right[i]</c>.
        /// </summary>
        /// <param name="left">The vector from which <paramref name="right" /> will be subtracted (将被减去<paramref name="right" />的向量).</param>
        /// <param name="right">The vector to subtract from <paramref name="left" /> (要从<paramref name="left" />减去的向量).</param>
        /// <returns>The difference of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" />与<paramref name="right" />的差).</returns>
        /// <seealso cref="Subtract_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Subtract{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<long> Subtract(Vector256<long> left, Vector256<long> right);

        /// <summary>
        /// Subtracts two vectors to compute their difference (将两个向量相减来计算它们的差).
        /// Mnemonic: <c>rt[i] := left[i] - right[i]</c>.
        /// </summary>
        /// <param name="left">The vector from which <paramref name="right" /> will be subtracted (将被减去<paramref name="right" />的向量).</param>
        /// <param name="right">The vector to subtract from <paramref name="left" /> (要从<paramref name="left" />减去的向量).</param>
        /// <returns>The difference of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" />与<paramref name="right" />的差).</returns>
        /// <seealso cref="Subtract_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Subtract{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<ulong> Subtract(Vector256<ulong> left, Vector256<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>Xor</c> (运行 <c>Xor</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Xor"/>
        TypeCodeFlags Xor_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the exclusive-or of two vectors (计算两个向量的位异或).
        /// Mnemonic: <c>rt[i] := left[i] ^ right[i]</c>.
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="left">The vector to exclusive-or with <paramref name="right" /> (将会与<paramref name="right" />进行位异或运算的向量).</param>
        /// <param name="right">The vector to exclusive-or with <paramref name="left" /> (将会与<paramref name="left" />进行位异或运算的向量).</param>
        /// <returns>The exclusive-or of <paramref name="left" /> and <paramref name="right"/> (<paramref name="left" /> 与 <paramref name="right" /> 的位异或运算结果).</returns>
        /// <seealso cref="Xor_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Xor{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<T> Xor<T>(Vector256<T> left, Vector256<T> right) where T : struct;


#endif
    }
}
