﻿//#undef BENCHMARKS_OFF

using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Benchmarks.AVector.M {
#if BENCHMARKS_OFF
    using BenchmarkAttribute = FakeBenchmarkAttribute;
#else
#endif // BENCHMARKS_OFF

    // My type.
    using TMy = SByte;

    /// <summary>
    /// Multiply benchmark - SByte.
    /// </summary>
#if NETCOREAPP3_0_OR_GREATER && DRY_JOB
    [DryJob]
#endif // NETCOREAPP3_0_OR_GREATER && DRY_JOB
    public partial class MultiplyBenchmark_SByte : AbstractSharedBenchmark_SByte {

        // -- var --

        /// <summary>
        /// Sum Multiply - Scalar.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMy StaticSumMultiplyScalar(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int p = 0;
            for (int i = 0; i < cntBlock; ++i) {
                for (int j = 0; j < VectorWidth; ++j) {
                    rt += (TMy)(src[p + j] * src[p + j + VectorWidth]);
                }
                p += nBlockWidth;
            }
            return rt;
        }

        [Benchmark(Baseline = true)]
        public void SumMultiplyScalar() {
            dstTMy = StaticSumMultiplyScalar(srcArray, srcArray.Length);
            if (CheckMode) {
                baselineTMy = dstTMy;
                BenchmarkUtil.WriteItem("# SumMultiplyScalar", string.Format("{0}", baselineTMy));
            }
        }

        /// <summary>
        /// Sum Multiply - BCL.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMy StaticSumMultiplyBcl(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            //int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            ref Vector<TMy> p0 = ref Unsafe.As<TMy, Vector<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                vrt += Vector.Multiply(p0, Unsafe.Add(ref p0, 1));
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            //ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            //for (i = 0; i < cntRem; ++i) {
            //    rt += (TMy)Unsafe.Add(ref p, i);
            //}
            // Reduce.
            for (i = 0; i < Vector<TMy>.Count; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumMultiplyBcl() {
            dstTMy = StaticSumMultiplyBcl(srcArray, srcArray.Length);
            CheckResult("SumMultiplyBcl");
        }
        /// <summary>
        /// Sum Multiply - BCL - Widen.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMy StaticSumMultiplyBcl_Widen(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            //int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            ref Vector<TMy> p0 = ref Unsafe.As<TMy, Vector<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                vrt += VectorTraitsBase.Statics.Multiply_Widen(p0, Unsafe.Add(ref p0, 1));
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            //ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            //for (i = 0; i < cntRem; ++i) {
            //    rt += (TMy)Unsafe.Add(ref p, i);
            //}
            // Reduce.
            for (i = 0; i < Vector<TMy>.Count; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumMultiplyBcl_Widen() {
            dstTMy = StaticSumMultiplyBcl_Widen(srcArray, srcArray.Length);
            CheckResult("SumMultiplyBcl_Widen");
        }


        #region BENCHMARKS_RAW
#if BENCHMARKS_RAW


#endif // BENCHMARKS_RAW
        #endregion // BENCHMARKS_RAW


        /// <summary>
        /// Sum Multiply - Vector Traits - static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMy StaticSumMultiplyVectorTraits(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            //int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            ref Vector<TMy> p0 = ref Unsafe.As<TMy, Vector<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                vrt += Vectors.Multiply(p0, Unsafe.Add(ref p0, 1));
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            //ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            //for (i = 0; i < cntRem; ++i) {
            //    rt += (TMy)Unsafe.Add(ref p, i);
            //}
            // Reduce.
            for (i = 0; i < Vector<TMy>.Count; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumMultiplyVectorTraits() {
            dstTMy = StaticSumMultiplyVectorTraits(srcArray, srcArray.Length);
            CheckResult("SumMultiplyVectorTraits");
        }


#if NETCOREAPP3_0_OR_GREATER

        #region BENCHMARKS_128ALGORITHM
#if BENCHMARKS_128ALGORITHM

        /// <summary>
        /// Sum Multiply - Vector128 - Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMy StaticSumMultiplyVector128Traits(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            //int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector128 result.
            Vector128<TMy> t;
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector128 processs.
            for (i = 0; i < cntBlock; ++i) {
                t = Vector128s.Multiply(p0, Unsafe.Add(ref p0, 1));
                vrt = Vector128s.Add(vrt, t);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            //ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            //for (i = 0; i < cntRem; ++i) {
            //    rt += (TMy)Unsafe.Add(ref p, i);
            //}
            // Reduce.
            for (i = 0; i < Vector128<TMy>.Count; ++i) {
                rt += vrt.GetElement(i);
            }
            return rt;
        }

        [Benchmark]
        public void SumMultiplyVector128Traits() {
            Vector128s.ThrowForUnsupported(true);
            dstTMy = StaticSumMultiplyVector128Traits(srcArray, srcArray.Length);
            CheckResult("SumMultiplyVector128Traits");
        }

        #region BENCHMARKS_ALGORITHM
#if BENCHMARKS_ALGORITHM
#if NET5_0_OR_GREATER

#endif // NET5_0_OR_GREATER

#endif // BENCHMARKS_ALGORITHM
        #endregion // BENCHMARKS_ALGORITHM


#endif // BENCHMARKS_128ALGORITHM
        #endregion // BENCHMARKS_128ALGORITHM

        #region BENCHMARKS_256ALGORITHM
#if BENCHMARKS_256ALGORITHM

        /// <summary>
        /// Sum Multiply - Vector256 - Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMy StaticSumMultiplyVector256Traits(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            //int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector256 result.
            Vector256<TMy> t;
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector256 processs.
            for (i = 0; i < cntBlock; ++i) {
                t = Vector256s.Multiply(p0, Unsafe.Add(ref p0, 1));
                vrt = Vector256s.Add(vrt, t);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            //ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            //for (i = 0; i < cntRem; ++i) {
            //    rt += (TMy)Unsafe.Add(ref p, i);
            //}
            // Reduce.
            for (i = 0; i < Vector256<TMy>.Count; ++i) {
                rt += vrt.GetElement(i);
            }
            return rt;
        }

        [Benchmark]
        public void SumMultiplyVector256Traits() {
            Vector256s.ThrowForUnsupported(true);
            dstTMy = StaticSumMultiplyVector256Traits(srcArray, srcArray.Length);
            CheckResult("SumMultiplyVector256Traits");
        }

#endif // BENCHMARKS_256ALGORITHM
        #endregion // BENCHMARKS_256ALGORITHM

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
