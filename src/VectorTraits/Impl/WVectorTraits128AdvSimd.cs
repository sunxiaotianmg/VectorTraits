﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
#if NET5_0_OR_GREATER
using System.Runtime.Intrinsics.Arm;
#endif // NET5_0_OR_GREATER

namespace Zyl.VectorTraits.Impl {
    using SuperStatics = WVectorTraits128Base.Statics;

    /// <summary>
    /// <see cref="Vector128{T}"/> traits - AdvSimd .
    /// </summary>
    public sealed partial class WVectorTraits128AdvSimd : WVectorTraits128AdvSimdAbstract {
        private static readonly WVectorTraits128AdvSimd _instance = new WVectorTraits128AdvSimd(); // Default instance.

        /// <summary>Default instance. </summary>
        public static WVectorTraits128AdvSimd Instance {
            get { return _instance; }
        }

#if NETCOREAPP3_0_OR_GREATER


#endif // NETCOREAPP3_0_OR_GREATER

        /// <summary>
        /// <see cref="Vector128{T}"/> traits.Statics - AdvSimd.
        /// </summary>
        public static partial class Statics {

            /// <inheritdoc cref="IBaseTraits.ByteCount"/>
            public static int ByteCount {
                get { return ByteCountValue; }
            }

            /// <inheritdoc cref="IBaseTraits.IsSupported"/>
            public static bool IsSupported {
                get {
                    return GetIsSupported();
                }
            }

            /// <inheritdoc cref="IBaseTraits.GetIsSupported"/>
            public static bool GetIsSupported(bool noStrict = false) {
                bool rt = false;
#if NET5_0_OR_GREATER
                rt = AdvSimd.IsSupported;
#else
#endif // NET5_0_OR_GREATER
                if (!noStrict) {
                    rt = rt && (sizeof(int) == IntPtr.Size);
                }
                return rt;
            }

            /// <inheritdoc cref="IBaseTraits.GetUnsupportedMessage"/>
            public static string GetUnsupportedMessage(bool noStrict = false) {
                string rt = "Requires hardware support AdvSimd!";
#if NETCOREAPP3_0_OR_GREATER
#else
                rt = "Vector128 type is not supported! " + rt;
#endif // NETCOREAPP3_0_OR_GREATER
                if (!noStrict) {
                    if (!(sizeof(int) == IntPtr.Size)) {
                        rt += string.Format("This process({0}bit) is not 32-bit!", IntPtr.Size * 8);
                    }
                }
                return rt;
            }

            /// <inheritdoc cref="IBaseTraits.ThrowForUnsupported"/>
            public static void ThrowForUnsupported(bool noStrict = false) {
                if (GetIsSupported(noStrict)) return;
                throw new NotSupportedException(GetUnsupportedMessage(noStrict));
            }

#if NET5_0_OR_GREATER

            /// <summary>
            /// Debug test.
            /// </summary>
            public static void DebugTest() {
                Vector128<sbyte> src = Vector128<sbyte>.AllBitsSet;
                byte shiftAmount = 0;
                try {
                    Vector128<sbyte> dst = AdvSimd.ShiftLeftLogical(src, shiftAmount);
                    Trace.WriteLine($"ShiftLeftLogical:\tOK. {dst}");
                } catch(Exception ex) {
                    Trace.WriteLine($"ShiftLeftLogical:\tFail!. {ex}");
                }
                try {
                    Vector128<sbyte> dst = AdvSimd.ShiftRightArithmetic(src, shiftAmount);
                    Trace.WriteLine($"ShiftRightArithmetic:\tOK. {dst}");
                } catch (Exception ex) {
                    Trace.WriteLine($"ShiftRightArithmetic:\tFail!. {ex}");
                }
                try {
                    Vector128<sbyte> dst = AdvSimd.ShiftRightLogical(src, shiftAmount);
                    Trace.WriteLine($"ShiftRightLogical:\tOK. {dst}");
                } catch (Exception ex) {
                    Trace.WriteLine($"ShiftRightLogical:\tFail!. {ex}");
                }
                // Output:
                // ShiftLeftLogical:	OK. <-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1>
                // Exception thrown: 'System.ArgumentOutOfRangeException' in System.Private.CoreLib.dll
                // ShiftRightArithmetic:	Fail!. System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                // Exception thrown: 'System.ArgumentOutOfRangeException' in System.Private.CoreLib.dll
                // ShiftRightLogical:	Fail!. System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
            }


            /// <inheritdoc cref="IWVectorTraits128.Ceiling_AcceleratedTypes"/>
            public static TypeCodeFlags Ceiling_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Ceiling(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Ceiling(Vector128<float> value) {
                return AdvSimd.Ceiling(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.Ceiling(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Ceiling(Vector128<double> value) {
                Vector64<double> lower = AdvSimd.CeilingScalar(Vector128.GetLower(value));
                Vector64<double> upper = AdvSimd.CeilingScalar(Vector128.GetUpper(value));
                Vector128<double> rt = Vector128.Create(lower, upper);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.Floor_AcceleratedTypes"/>
            public static TypeCodeFlags Floor_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Floor(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Floor(Vector128<float> value) {
                return AdvSimd.Floor(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.Floor(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Floor(Vector128<double> value) {
                Vector64<double> lower = AdvSimd.FloorScalar(Vector128.GetLower(value));
                Vector64<double> upper = AdvSimd.FloorScalar(Vector128.GetUpper(value));
                Vector128<double> rt = Vector128.Create(lower, upper);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftLeft_AcceleratedTypes {
                get {
                    return TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftLeft(Vector128<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftLeftFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftLeft(Vector128<byte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftLeftFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftLeft(Vector128<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftLeftFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftLeft(Vector128<ushort> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftLeftFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftLeft(Vector128<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftLeftFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftLeft(Vector128<uint> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftLeftFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftLeft(Vector128<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftLeftFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftLeft(Vector128<ulong> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftLeftFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftLeftFast(Vector128<sbyte> value, int shiftAmount) {
                return AdvSimd.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftLeftFast(Vector128<byte> value, int shiftAmount) {
                return AdvSimd.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftLeftFast(Vector128<short> value, int shiftAmount) {
                return AdvSimd.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftLeftFast(Vector128<ushort> value, int shiftAmount) {
                return AdvSimd.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftLeftFast(Vector128<int> value, int shiftAmount) {
                return Vector128.AsInt32(AdvSimd.ShiftLeftLogical(Vector128.AsUInt32(value), (byte)shiftAmount));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftLeftFast(Vector128<uint> value, int shiftAmount) {
                return AdvSimd.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftLeftFast(Vector128<long> value, int shiftAmount) {
                return AdvSimd.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftLeftFast(Vector128<ulong> value, int shiftAmount) {
                return AdvSimd.ShiftLeftLogical(value, (byte)shiftAmount);
            }


            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftRightArithmetic_AcceleratedTypes {
                get {
                    return TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightArithmetic(Vector128<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                if (0 == shiftAmount) {
                    // AdvSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                    return value;
                }
                return ShiftRightArithmeticFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightArithmetic(Vector128<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                if (0 == shiftAmount) {
                    // AdvSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                    return value;
                }
                return ShiftRightArithmeticFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightArithmetic(Vector128<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                if (0 == shiftAmount) {
                    // AdvSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                    return value;
                }
                return ShiftRightArithmeticFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightArithmetic(Vector128<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                if (0 == shiftAmount) {
                    // AdvSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                    return value;
                }
                return ShiftRightArithmeticFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmeticFast(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightArithmeticFast(Vector128<sbyte> value, int shiftAmount) {
                Debug.Assert(1 <= shiftAmount && shiftAmount <= 7, "The shiftAmount parameter must be in the range [1,7]."); // AdvSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                return AdvSimd.ShiftArithmetic(value, Vector128.Create((sbyte)(-shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmeticFast(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightArithmeticFast(Vector128<short> value, int shiftAmount) {
                Debug.Assert(1 <= shiftAmount && shiftAmount <= 15, "The shiftAmount parameter must be in the range [1,15]."); // AdvSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                return AdvSimd.ShiftArithmetic(value, Vector128.Create((short)(-shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmeticFast(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightArithmeticFast(Vector128<int> value, int shiftAmount) {
                Debug.Assert(1 <= shiftAmount && shiftAmount <= 31, "The shiftAmount parameter must be in the range [1,31]."); // AdvSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                return AdvSimd.ShiftArithmetic(value, Vector128.Create((int)(-shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmeticFast(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightArithmeticFast(Vector128<long> value, int shiftAmount) {
                Debug.Assert(1 <= shiftAmount && shiftAmount <= 63, "The shiftAmount parameter must be in the range [1,63]."); // AdvSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                return AdvSimd.ShiftArithmetic(value, Vector128.Create((long)(-shiftAmount)));
            }


            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftRightLogical_AcceleratedTypes {
                get {
                    return TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightLogical(Vector128<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                //if (0 == shiftAmount) {
                //    // AdvSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                //    return value;
                //}
                return ShiftRightLogicalFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftRightLogical(Vector128<byte> value, int shiftAmount) {
                shiftAmount &= 7;
                //if (0 == shiftAmount) {
                //    // AdvSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                //    return value;
                //}
                return ShiftRightLogicalFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightLogical(Vector128<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                //if (0 == shiftAmount) {
                //    // AdvSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                //    return value;
                //}
                return ShiftRightLogicalFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftRightLogical(Vector128<ushort> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                //if (0 == shiftAmount) {
                //    // AdvSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                //    return value;
                //}
                return ShiftRightLogicalFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightLogical(Vector128<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                //if (0 == shiftAmount) {
                //    // AdvSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                //    return value;
                //}
                return ShiftRightLogicalFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftRightLogical(Vector128<uint> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                //if (0 == shiftAmount) {
                //    // AdvSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                //    return value;
                //}
                return ShiftRightLogicalFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightLogical(Vector128<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                //if (0 == shiftAmount) {
                //    // AdvSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                //    return value;
                //}
                return ShiftRightLogicalFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftRightLogical(Vector128<ulong> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                if (0 == shiftAmount) {
                    // AdvSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                    return value;
                }
                return ShiftRightLogicalFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightLogicalFast(Vector128<sbyte> value, int shiftAmount) {
                return AdvSimd.ShiftLogical(value, Vector128.Create((sbyte)(-shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftRightLogicalFast(Vector128<byte> value, int shiftAmount) {
                return AdvSimd.ShiftLogical(value, Vector128.Create((sbyte)(-shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightLogicalFast(Vector128<short> value, int shiftAmount) {
                return AdvSimd.ShiftLogical(value, Vector128.Create((short)(-shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftRightLogicalFast(Vector128<ushort> value, int shiftAmount) {
                return AdvSimd.ShiftLogical(value, Vector128.Create((short)(-shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightLogicalFast(Vector128<int> value, int shiftAmount) {
                return AdvSimd.ShiftLogical(value, Vector128.Create((int)(-shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftRightLogicalFast(Vector128<uint> value, int shiftAmount) {
                return AdvSimd.ShiftLogical(value, Vector128.Create((int)(-shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightLogicalFast(Vector128<long> value, int shiftAmount) {
                return AdvSimd.ShiftLogical(value, Vector128.Create((long)(-shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftRightLogicalFast(Vector128<ulong> value, int shiftAmount) {
                return ShiftRightLogicalFast_HwVar(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftRightLogicalFast_HwVar(Vector128<ulong> value, int shiftAmount) {
                Vector128<long> vshift = Vector128.Create((long)(-shiftAmount));
                // NEON intrinsics for shifts by signed variable
                // uint64x2_t vshlq_u64(uint64x2_t a, int64x2_t b);  // VSHL.U64 q0,q0,q0
                return AdvSimd.ShiftLogical(value, vshift);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftRightLogicalFast_HwImm(Vector128<ulong> value, int shiftAmount) {
                Debug.Assert(1 <= shiftAmount && shiftAmount <= 63, "The shiftAmount parameter must be in the range [1,63]."); // AdvSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                return AdvSimd.ShiftRightLogical(value, (byte)shiftAmount);
            }


            /// <inheritdoc cref="IWVectorTraits128.Widen_AcceleratedTypes"/>
            public static TypeCodeFlags Widen_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{float}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector128<float> source, out Vector128<double> lower, out Vector128<double> upper) {
                // TypeCodeFlags.Single: Need 64bit .
                SuperStatics.Widen(source, out lower, out upper);
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{sbyte}, out Vector128{short}, out Vector128{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector128<sbyte> source, out Vector128<short> lower, out Vector128<short> upper) {
                lower = AdvSimd.SignExtendWideningLower(source.GetLower());
                upper = AdvSimd.SignExtendWideningUpper(source);
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{byte}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector128<byte> source, out Vector128<ushort> lower, out Vector128<ushort> upper) {
                lower = AdvSimd.ZeroExtendWideningLower(source.GetLower());
                upper = AdvSimd.ZeroExtendWideningUpper(source);
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{short}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector128<short> source, out Vector128<int> lower, out Vector128<int> upper) {
                lower = AdvSimd.SignExtendWideningLower(source.GetLower());
                upper = AdvSimd.SignExtendWideningUpper(source);
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{ushort}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector128<ushort> source, out Vector128<uint> lower, out Vector128<uint> upper) {
                lower = AdvSimd.ZeroExtendWideningLower(source.GetLower());
                upper = AdvSimd.ZeroExtendWideningUpper(source);
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{int}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector128<int> source, out Vector128<long> lower, out Vector128<long> upper) {
                lower = AdvSimd.SignExtendWideningLower(source.GetLower());
                upper = AdvSimd.SignExtendWideningUpper(source);
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{uint}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector128<uint> source, out Vector128<ulong> lower, out Vector128<ulong> upper) {
                lower = AdvSimd.ZeroExtendWideningLower(source.GetLower());
                upper = AdvSimd.ZeroExtendWideningUpper(source);
            }


#endif // NET5_0_OR_GREATER
        }

    }
}
