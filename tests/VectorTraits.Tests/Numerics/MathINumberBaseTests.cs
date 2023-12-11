﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Zyl.VectorTraits;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits.Tests.Numerics {
    internal class MathINumberBaseTests {

        [TestCase((float)1)]
        [TestCase((double)2)]
        public void IsFiniteTest<T>(T src) where T : struct {
            T[] samples = new T[8];
            samples[0] = default;
            samples[1] = Scalars<T>.NegativeZero;
            samples[2] = src;
            samples[3] = Scalars<T>.MaxValue;
            samples[4] = Scalars<T>.MinValue;
            samples[5] = Scalars<T>.PositiveInfinity;
            samples[6] = Scalars<T>.NegativeInfinity;
            samples[7] = Scalars<T>.NaN;
            // run.
            bool allowLog = false;
            for (int i = 0; i < samples.Length; ++i) {
                T x = samples[i];
                bool expected = BitMath.IsFinite((dynamic)x);
                if (allowLog) {
                    Console.WriteLine("IsFinite({0}):\t{1}", x, expected);
                }
                // IsFinite_Bit.
                bool dst = MathINumberBase.IsFinite_Bit((dynamic)x);
                Assert.AreEqual(expected, dst, string.Format("IsFinite_Bit({0})", x));
                // IsFinite_Bcl.
#if NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                dst = MathINumberBase.IsFinite_Bcl((dynamic)x);
                Assert.AreEqual(expected, dst, string.Format("IsFinite_Bcl({0})", x));
#endif // NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            }
        }

        [TestCase((float)1)]
        [TestCase((double)2)]
        public void IsInfinityTest<T>(T src) where T : struct {
            T[] samples = new T[8];
            samples[0] = default;
            samples[1] = Scalars<T>.NegativeZero;
            samples[2] = src;
            samples[3] = Scalars<T>.MaxValue;
            samples[4] = Scalars<T>.MinValue;
            samples[5] = Scalars<T>.PositiveInfinity;
            samples[6] = Scalars<T>.NegativeInfinity;
            samples[7] = Scalars<T>.NaN;
            // run.
            bool allowLog = false;
            for (int i = 0; i < samples.Length; ++i) {
                T x = samples[i];
                bool expected = BitMath.IsInfinity((dynamic)x);
                if (allowLog) {
                    Console.WriteLine("IsInfinity({0}):\t{1}", x, expected);
                }
                // IsInfinity_Bit.
                bool dst = MathINumberBase.IsInfinity_Bit((dynamic)x);
                Assert.AreEqual(expected, dst, string.Format("IsInfinity_Bit({0})", x));
                // IsInfinity_Bcl.
#if NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                dst = MathINumberBase.IsInfinity_Bcl((dynamic)x);
                Assert.AreEqual(expected, dst, string.Format("IsInfinity_Bcl({0})", x));
#endif // NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            }
        }

        [TestCase((float)1)]
        [TestCase((double)2)]
        public void IsInfinityOrNaNTest<T>(T src) where T : struct {
            T[] samples = new T[8];
            samples[0] = default;
            samples[1] = Scalars<T>.NegativeZero;
            samples[2] = src;
            samples[3] = Scalars<T>.MaxValue;
            samples[4] = Scalars<T>.MinValue;
            samples[5] = Scalars<T>.PositiveInfinity;
            samples[6] = Scalars<T>.NegativeInfinity;
            samples[7] = Scalars<T>.NaN;
            // run.
            bool allowLog = false;
            for (int i = 0; i < samples.Length; ++i) {
                T x = samples[i];
                bool expected = BitMath.IsInfinityOrNaN((dynamic)x);
                if (allowLog) {
                    Console.WriteLine("IsInfinityOrNaN({0}):\t{1}", x, expected);
                }
                // IsInfinityOrNaN_Bit.
                bool dst = MathINumberBase.IsInfinityOrNaN_Bit((dynamic)x);
                Assert.AreEqual(expected, dst, string.Format("IsInfinityOrNaN_Bit({0})", x));
                // IsInfinityOrNaN_Bcl.
#if NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                dst = MathINumberBase.IsInfinityOrNaN_Bcl((dynamic)x);
                Assert.AreEqual(expected, dst, string.Format("IsInfinityOrNaN_Bcl({0})", x));
#endif // NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            }
        }

    }
}