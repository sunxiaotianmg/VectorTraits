﻿using System;
using System.Collections.Generic;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// <see cref="Vector256{T}"/> traits interface.
    /// </summary>
    public interface IWVectorTraits256 : IWVectorTraits {
#if NETCOREAPP3_0_OR_GREATER
        /// <summary>
        /// Shifts each element of a vector left by the specified amount.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted.</param>
        /// <param name="shiftCount">The number of bits by which to shift each element.</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftCount"/>.</returns>
        /// <seealso cref="Vector256.ShiftLeft(Vector256{byte}, int)"/> // .NET 7
        Vector256<byte> ShiftLeft(Vector256<byte> value, int shiftCount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted.</param>
        /// <param name="shiftCount">The number of bits by which to shift each element.</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftCount"/>.</returns>
        /// <seealso cref="Vector256.ShiftLeft(Vector256{short}, int)"/> // .NET 7
        Vector256<short> ShiftLeft(Vector256<short> value, int shiftCount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted.</param>
        /// <param name="shiftCount">The number of bits by which to shift each element.</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftCount"/>.</returns>
        /// <seealso cref="Vector256.ShiftLeft(Vector256{int}, int)"/>
        Vector256<int> ShiftLeft(Vector256<int> value, int shiftCount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted.</param>
        /// <param name="shiftCount">The number of bits by which to shift each element.</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftCount"/>.</returns>
        /// <seealso cref="Vector256.ShiftRightArithmetic(Vector256{int}, int)"/> // .NET 7
        Vector256<int> ShiftRightArithmetic(Vector256<int> value, int shiftCount);

#endif
    }
}
