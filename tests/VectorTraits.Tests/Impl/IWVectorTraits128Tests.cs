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
    public class IWVectorTraits128Tests {
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
            //Vector128<T> vzero = Vector128<T>.Zero;
            //T zero = default;
            int iMax = Vector128s<T>.ElementBitSize + 1;
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            IWVectorTraits128 instance0 = instances[0];
            Vector128<T>[] samples = {
                Vector128s.Create(src),
                Vector128s<T>.Demo,
                Vector128s<T>.Serial,
            };
            foreach (Vector128<T> vsrc in samples) {
                for (int i = -1; i <= iMax; ++i) {
                    Vector128<T> vbaseline = (Vector128<T>)(object)instance0.ShiftLeft((dynamic)vsrc, i);
                    for (int j = 1; j < instances.Count; ++j) {
                        IWVectorTraits128 instance = instances[j];
                        if (!instance.IsSupported) continue;
                        Vector128<T> vdst = (Vector128<T>)(object)instance.ShiftLeft((dynamic)vsrc, i);
                        Assert.AreEqual(vbaseline, vdst, $"{instance.GetType().Name}, shiftCount={i}, vsrc={vsrc}");
                    }
                }
            }
        }


#endif
    }
}