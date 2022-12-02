﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Tests.Impl {
    [TestFixture()]
    public class IWVectorTraits256Tests {
#if NETCOREAPP3_0_OR_GREATER

        //[TestCase((sbyte)3)]
        [TestCase((byte)4)]
        [TestCase((short)5)]
        //[TestCase((ushort)6)]
        [TestCase((int)7)]
        //[TestCase((uint)8)]
        //[TestCase((long)9)]
        //[TestCase((ulong)10)]
        public void ShiftLeft<T>(T src) where T : struct {
            //Vector256<T> vzero = Vector256<T>.Zero;
            //T zero = default;
            int iMax = Vector256s<T>.ElementBitSize + 1;
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            IWVectorTraits256 instance0 = instances[0];
            Vector256<T>[] samples = {
                Vector256s.Create(src),
                Vector256s<T>.Demo,
                Vector256s<T>.Serial,
            };
            foreach (Vector256<T> vsrc in samples) {
                for (int i = -1; i <= iMax; ++i) {
                    Vector256<T> vbaseline = (Vector256<T>)(object)instance0.ShiftLeft((dynamic)vsrc, i);
                    for (int j = 1; j < instances.Count; ++j) {
                        IWVectorTraits256 instance = instances[j];
                        if (!instance.IsSupported) continue;
                        Vector256<T> vdst = (Vector256<T>)(object)instance.ShiftLeft((dynamic)vsrc, i);
                        Assert.AreEqual(vbaseline, vdst, $"{instance.GetType().Name}, shiftCount={i}, vsrc={vsrc}");
                    }
                }
            }
        }


#endif
    }
}