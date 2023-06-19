﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.Benchmarks {

    // My type.
    using TMy = Single;
    using TMyOut = UInt32;

    /// <summary>
    /// Abstract shared array benchmark - Single to UInt32.
    /// </summary>
    public class AbstractSharedBenchmark_Single_UInt32 : AbstractSharedBenchmark {
        // -- TMy ref --
        protected static ref TMyOut dstTMy => ref dstUInt32;
        protected static ref TMyOut baselineTMy => ref baselineUInt32;
        protected static TMy[] srcArray => srcArraySingle;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected override void CheckResult(string name) {
            CheckResultUInt32(name);
        }


        // -- Params --
        public override int ShiftAmountMin {
            get {
                //return 1;
                return -1;
            }
        }
        public override int ShiftAmountMax {
            get {
                //return 1;
                return Scalars<TMy>.BitSize + 1;
            }
        }

    }
}
