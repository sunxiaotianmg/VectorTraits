﻿using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Reflection;
using System.Runtime.Versioning;
using System.Text;

namespace Zyl.VectorTraits.Benchmarks {
    /// <summary>
    /// Benchmark util.
    /// </summary>
    internal static class BenchmarkUtil {
        /// <summary>Indent next separator (增加缩进的分隔符).</summary>
        public static readonly string IndentNextSeparator = TraitsUtil.IndentNextSeparator;


        /// <summary>Current <see cref="TextWriter"/>.</summary>
        public static TextWriter? CurrentTextWriter { get; set; }

        /// <summary>
        /// Output Environment.
        /// </summary>
        /// <param name="writer">Output <see cref="TextWriter"/>.</param>
        /// <param name="indent">The indent.</param>
        public static void OutputEnvironment(TextWriter writer, string? indent = null) {
            TraitsOutput.OutputEnvironment(writer, indent);
            writer.WriteLine(indent + string.Format("Vectors.Instance:\t{0}", Vectors.Instance.GetType().Name));
            writer.WriteLine(indent + string.Format("Vectors.BaseInstance:\t{0}", Vectors.BaseInstance.GetType().Name));
        }

        /// <summary>
        /// Run action test.
        /// </summary>
        /// <param name="writer">Output <see cref="TextWriter"/>.</param>
        /// <param name="indent">The indent.</param>
        /// <param name="name">Test name.</param>
        /// <param name="action">Test action</param>
        /// <param name="srcCount">Source count within an <paramref name="action"/>.</param>
        /// <param name="mopsBaseline">Baseline's MOPS/s</param>
        /// <returns>Returns MOPS/s.</returns>
        public static double RunTest(TextWriter writer, string indent, string name, Action action, int srcCount, double mopsBaseline) {
            double us;
            double rt = RunTestCore(action, srcCount, mopsBaseline, out us);
            if (mopsBaseline>0) {
                double scale = rt / mopsBaseline;
                writer.WriteLine(indent + string.Format("{0}:\tus={1:F3}, MOPS/s={2}, scale={3}", name, us, rt, scale));
            } else {
                writer.WriteLine(indent + string.Format("{0}:\tus={1:F3}, MOPS/s={2}", name, us, rt));
            }
            return rt;
        }

        /// <summary>
        /// Run action test core.
        /// </summary>
        /// <param name="action">The action.</param>
        /// <param name="srcCount">Source count within an <paramref name="action"/>.</param>
        /// <param name="mopsBaseline">Baseline's MOPS/s</param>
        /// <param name="us">Run time ms.</param>
        /// <returns>Returns MOPS/s.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "<Pending>")]
        public static double RunTestCore(Action action, int srcCount, double mopsBaseline, out double us) {
            double rt;
            const int aMillion = 1000 * 1000;
            const int usPerSecond = 1000 * 1000;
            long tickPerSecond = Stopwatch.Frequency;
            double tickPerUs = tickPerSecond / (double)usPerSecond;
            long tickMax = tickPerSecond / 8;
            const int RepeatCount = 10;
            const int RepeatCountUsed = 6;
            Stopwatch stopwatch = new Stopwatch();
            //int tickBegin;
            long tickUsed;
            int loops = 1;
            int i, j;
            // Find best loops.
            for(; ; ) {
                stopwatch.Restart();
                for (i = 0; i < loops; ++i) {
                    action();
                }
                stopwatch.Stop();
                tickUsed = stopwatch.ElapsedTicks;
                // Check.
                int loopsNext = loops * 2;
                bool flag = (tickUsed >= tickMax || loopsNext < loops);
                if (flag) {
                    break;
                }
                loops = loopsNext;
            }
            // Repeat.
            long tickSum = 0;
            //long[] tickArray = new long[RepeatCount];
            Span<long> tickArray = stackalloc long[RepeatCount];
            for (j = 0; j < RepeatCount; ++j) {
                stopwatch.Restart();
                for (i = 0; i < loops; ++i) {
                    action();
                }
                stopwatch.Stop();
                tickUsed = stopwatch.ElapsedTicks;
                tickArray[j] = tickUsed;
            }
            // done.
            tickArray.Sort();
            int jStart = (RepeatCount - RepeatCountUsed) / 2;
            for (j = 0; j < RepeatCountUsed; ++j) {
                tickSum += tickArray[jStart + j];
            }
            us = tickSum / (tickPerUs * RepeatCountUsed * loops);
            rt = (double)srcCount * usPerSecond / aMillion / us;
            return rt;
        }

        /// <summary>
        /// Fill <see cref="MethodInfo"/> of benchmark .
        /// </summary>
        /// <typeparam name="T">The benchmark class.</typeparam>
        /// <param name="dst">Destination list</param>
        /// <param name="src">Source object.</param>
        public static void FillMethodInfoOfBenchmark<T>(ICollection<MethodInfo> dst, T src) where T : class {
            foreach (MethodInfo mi in src.GetType().GetMethods()) {
                if (mi.ContainsGenericParameters) continue;
                if (mi.IsStatic) continue;
                if (mi.IsAbstract) continue;
                if (mi.GetParameters().Length != 0) continue;
                BenchmarkAttribute? attr = mi.GetCustomAttribute<BenchmarkAttribute>();
                if (null == attr) continue;
                // ok.
                dst.Add(mi);
            }
        }

        /// <summary>
        /// Writes a string to the text stream, followed by a line terminator.
        /// </summary>
        /// <param name="value">The string to write. If value is null, only the line terminator is written.</param>
        public static void WriteLine(string? value) {
            if (null != CurrentTextWriter) {
                CurrentTextWriter.WriteLine(value);
            } else {
                // ignore.
            }
        }

        /// <summary>
        /// CheckAllBenchmark - default onafter.
        /// </summary>
        /// <param name="mi">The MethodInfo.</param>
        /// <param name="ex">The Exception. null is no exception.</param>
        public static void CheckAllBenchmark_Default(MethodInfo mi, Exception? ex) {
            string msg = "";
            string name = mi.Name;
            if (null == ex) {
                // Succeed. No output.
                //msg = string.Format("Check-{0}: Succeed.", name);
            } else {
                msg = string.Format("Check-{0}: Fail! {1}", name, ex.Message);
                Debug.WriteLine(ex);
                bool ignoreException = ex is NotSupportedException;
                if (ignoreException) return;
            }
            if (string.IsNullOrEmpty(msg)) return;
            WriteLine(msg);
        }

        /// <summary>
        /// Check all Benchmark.
        /// </summary>
        /// <typeparam name="T">The benchmark class.</typeparam>
        /// <param name="src">Source object.</param>
        public static void CheckAllBenchmark<T>(T src, Action<MethodInfo, Exception?>? onafter = null) where T : AbstractBenchmark {
            if (null == onafter) onafter = CheckAllBenchmark_Default;
            bool oldCheckMode = src.CheckMode;
            src.CheckMode = true;
            try {
                List<MethodInfo> lst = new List<MethodInfo>();
                FillMethodInfoOfBenchmark(lst, src);
                if (lst.Count <= 0) return;
                foreach (MethodInfo mi in lst) {
                    string name = mi.Name;
                    Exception? ex1 = null;
                    try {
                        Action action = (Action)mi.CreateDelegate(typeof(Action), src);
                        //Action action = (Action)Delegate.CreateDelegate(typeof(Action), obj, mi);
                        action();
                    } catch (Exception ex) {
                        //writer.WriteLine(indent + string.Format("{0}:\tRun fail! {1}", name, ex.Message));
                        ex1 = ex;
                    }
                    onafter?.Invoke(mi, ex1);
                }
            } finally {
                src.CheckMode = oldCheckMode;
            }
        }


        /// <summary>
        /// Run benchmark object
        /// </summary>
        /// <param name="writer">Output <see cref="TextWriter"/>.</param>
        /// <param name="indent">The indent.</param>
        /// <param name="typ">The type.</param>
        /// <param name="obj">The object.</param>
        public static void RunBenchmarkObject(TextWriter writer, string indent, Type typ, AbstractBenchmark? obj) {
            if (null == obj) return;
            List<MethodInfo> lst = new List<MethodInfo>();
            FillMethodInfoOfBenchmark(lst, obj);
            if (lst.Count <= 0) return;
            foreach (int n in AbstractBenchmark.ValuesForN) {
                double mopsBaseline = 0.0;
                writer.WriteLine();
                writer.WriteLine(indent + string.Format("[{0}: {1}]", typ.Name, n));
                // GlobalSetup.
                obj.N = n;
                obj.GlobalSetup();
                // Tests.
                foreach (MethodInfo mi in lst) {
                    string name = mi.Name;
                    try {
                        Action action = (Action)mi.CreateDelegate(typeof(Action), obj);
                        //Action action = (Action)Delegate.CreateDelegate(typeof(Action), obj, mi);
                        double mops = BenchmarkUtil.RunTest(writer, indent, name, action, n, mopsBaseline);
                        bool isBaseline = false;
                        BenchmarkAttribute? attr = mi.GetCustomAttribute<BenchmarkAttribute>();
                        if (null!= attr) {
                            isBaseline = attr.Baseline;
                        }
                        bool mopsFlag = (0 == mopsBaseline || isBaseline) && mops > 0;
                        if (mopsFlag) {
                            mopsBaseline = mops;
                        }
                    } catch (Exception ex) {
                        writer.WriteLine(indent + string.Format("{0}:\tRun fail! {1}", name, ex.Message));
                    }
                }
            }
        }

        /// <summary>
        /// Run benchmark.
        /// </summary>
        /// <param name="writer">Output <see cref="TextWriter"/>.</param>
        /// <param name="indent">The indent.</param>
        /// <param name="assembly">The assembly.</param>
        public static void RunBenchmark(TextWriter writer, string indent, Assembly assembly) {
            Type baseType = typeof(AbstractBenchmark);
            foreach (Type typ in assembly.GetTypes()) {
                if (typ.ContainsGenericParameters) continue;
                if (typ.IsAbstract) continue;
                if (!typ.IsSubclassOf(baseType)) continue;
                try {
                    AbstractBenchmark? obj = Activator.CreateInstance(typ) as AbstractBenchmark;
                    RunBenchmarkObject(writer, indent, typ, obj);
                } catch (Exception ex) {
                    writer.WriteLine(indent + string.Format("Run `{0} fail! {1}`", typ.FullName, ex.Message));
                }
            }
        }
    }
}
